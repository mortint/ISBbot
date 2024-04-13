using ISP.Configs;
using ISP.Engine.Accounts;
using ISP.Engine.Helpers;
using ISP.Enums.Parser;
using ISP.Forms;
using ISP.Misc;
using ISP.Objects.Targets;
using ISP.Tasks.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Tasks {
    internal sealed class ChatsTask : ISBTask {
        private Dictionary<string, string> _avatarsCache;
        /// <summary>
        /// Получить аватар для смены
        /// </summary>
        /// <returns></returns>
        private string GetAvatarFor(Account acc, long chatId, string avatar) {
            if (_avatarsCache.Keys.Contains($"{chatId}{avatar}"))
                return _avatarsCache[$"{chatId}{avatar}"];
            LogForm.PushToLog(acc, $"Загрузка аватара {avatar}");
            avatar = $"Upload\\Avatars\\{avatar}";
            var api = acc.VkApi;
            var wc = new WebClient();
            var uploadServer = api.Photo.GetChatUploadServer((ulong)chatId);
            var fileOnServer
                = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(
                    Encoding.ASCII.GetString(wc.UploadFile(uploadServer.UploadUrl, avatar)))["response"];
            _avatarsCache[$"{chatId}{avatar}"] = fileOnServer;
            return fileOnServer;
        }
        /// <summary>
        /// Обработка чата
        /// </summary>
        private void ProcessChat(Account acc, ChatsTarget ctg) {
            var api = acc.VkApi;
            var targetData = LinkParser.Parse(acc, ctg.Link);
            var cts = acc.ChatsTaskSettings;

            if (targetData.Type == TypeOfTarget.NotFound)
                return;

            if (targetData.Type != TypeOfTarget.Chat) {
                LogForm.PushToLog(acc, $"[Беседы]: \"{ctg.Link}\" - неподдерживаемый формат ссылки");
                return;
            }

            if (ConfigController.AntikickConfig.LeavedIntentionallyFrom != null
                && ConfigController.AntikickConfig.LeavedIntentionallyFrom.ContainsKey(acc.Login)
                && ConfigController.AntikickConfig.LeavedIntentionallyFrom[acc.Login].Contains((ulong)targetData.Id1))
                return;

            var chatInfo = api.Messages.GetChat((long)targetData.Id1);

            switch (ctg.TitleMode) {
                case "Заменять на ->":
                    if (ctg.Title != chatInfo.Title)
                        api.Messages.EditChat(chatInfo.Id, ctg.Title);
                    break;
                case "Флудить названиями": {
                        var title = cts.GetTitle(acc, ctg);
                        if (title != null)
                            api.Messages.EditChat(chatInfo.Id, title);
                    }
                    break;
            }

            if (ConfigController.AntikickConfig.LeavedIntentionallyFrom != null
                && ConfigController.AntikickConfig.LeavedIntentionallyFrom.ContainsKey(acc.Login)
                && ConfigController.AntikickConfig.LeavedIntentionallyFrom[acc.Login].Contains((ulong)targetData.Id1))
                return;

            if (ctg.AvatarMode != "Ничего не делать") {
                if (ctg.AvatarMode == "Удалять" && chatInfo.Photo200 != null)
                    api.Messages.DeleteChatPhoto((ulong)chatInfo.Id);
                else {
                    if (chatInfo.Photo200 == null) {
                        api.Call("messages.setChatPhoto", new VkNet.Utils.VkParameters
                        {
                            { "message_id", 0 },
                            { "file",  GetAvatarFor(acc, chatInfo.Id, ctg.AvatarMode) }
                        });
                    }
                }
            }
        }

        private void AsyncWorker(Account acc) {
            var cts = acc.ChatsTaskSettings;
            var targets = cts.Targets;

            int targetIter = -1;

            void DoChats() {
                if (!cts.Enabled) {
                    PeriodicTimer?.Dispose();
                    PeriodicTimer = null;
                    return;
                }

                lock (targets) {
                    targetIter = (targetIter + 1) % targets.Count;
                    try {
                        ChatsTarget ctg = targets[targetIter];
                        ProcessChat(acc, ctg);
                    }
                    catch (Exception ex) {
                        LogForm.PushToLog(acc, "[Беседы]: " + ex.Message);
                    }
                }
            }

            PeriodicTimer = new SingleSimrunTimer(DoChats, cts.Delay);
        }

        public override void LaunchTask(Account acc) {
            if (!acc.ChatsTaskSettings.Enabled)
                return;
            if (acc.ChatsTaskSettings.Targets.Count == 0) {
                LogForm.PushToLog(acc, "[Беседы]: ошибка запуска - отсутствуют цели");
                return;
            }

            _avatarsCache = new Dictionary<string, string>();

            new Task(() => AsyncWorker(acc)).Start();
        }

        public override void StopTask() {
            PeriodicTimer?.Dispose();
            PeriodicTimer = null;
        }
    }
}
