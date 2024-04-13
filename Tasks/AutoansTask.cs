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
using System.Threading.Tasks;
using VkNet.Model;

namespace ISP.Tasks {

    internal sealed class AutoansTask : ISBTask {
        /// <summary>
        /// Сгенерировать сообщение
        /// </summary>
        /// <returns></returns>
        private string BuildRandomMessage(Account acc, AutoansTaskSettings ats, AutoansTarget to) {
            string msg = ats.GetPhrase(acc, to);

            switch (to.NamePlace) {
                case "Начало":
                    msg = to.Name + msg;
                    break;
                case "Конец":
                    msg = msg + to.Name;
                    break;
                case "В начале и в конце (через :)": {
                        string[] twon = to.Name.Split(':');
                        msg = twon[0] + msg + (twon.Length == 1 ? twon[0] : twon[1]);
                    }
                    break;
            }

            return msg;
        }
        /// <summary>
        /// Отправить сообщение
        /// </summary>
        private void SendFlood(Account acc, AutoansTarget atg) {
            var api = acc.VkApi;
            var targetData = LinkParser.Parse(acc, atg.Link);
            var ats = acc.AutoansTaskSettings;
            var history = GetHistory(acc, atg);
            List<MediaAttachment> attachments = new List<MediaAttachment>();
            string message = "";
            long stickerId = -1;
            var userId = GetUserId(acc);
            switch (atg.Contains) {
                case "Текст":
                    message = BuildRandomMessage(acc, ats, atg);
                    break;
                case "Изображение":
                    message = atg.Name;
                    attachments.AddRange(ats.RandomImage());
                    break;
                case "Изображение+текст":
                    attachments.AddRange(ats.RandomImage());
                    message = BuildRandomMessage(acc, ats, atg);
                    break;
                case "Текст-ссылка":
                    message = $"*id{userId} ({BuildRandomMessage(acc, ats, atg)})";
                    break;
                case "Текст+стикер": {
                        stickerId = (long)ats.RandomSticker(acc, atg).Last().Id;

                        AutoansTarget ftgtxt = new AutoansTarget(atg) {
                            Contains = "Текст"
                        };
                        SendFlood(acc, ftgtxt);
                        AutoansTarget ftgstc = new AutoansTarget(atg) {
                            Contains = "Стикер"
                        };
                        SendFlood(acc, ftgstc);
                    }
                    return;
                case "Видеозапись":
                    attachments.AddRange(ats.RandomVideo());
                    break;
                case "Видеозапись+текст":
                    attachments.AddRange(ats.RandomVideo());
                    message = BuildRandomMessage(acc, ats, atg);
                    break;
                case "Документ+текст":
                    attachments.AddRange(ats.RandomDocument());
                    message = BuildRandomMessage(acc, ats, atg);
                    break;
            }

            switch (targetData.Type) {
                case TypeOfTarget.Chat: {
                        if (ConfigController.AntikickConfig.LeavedIntentionallyFrom != null
                            && ConfigController.AntikickConfig.LeavedIntentionallyFrom.ContainsKey(acc.Login)
                                && ConfigController.AntikickConfig.LeavedIntentionallyFrom[acc.Login]
                                .Contains((ulong)targetData.Id1))
                            break;

                        foreach (var msg in history.Messages) {
                            MessagesSendParams msp = new MessagesSendParams() {
                                ChatId = targetData.Id1,
                                Message = message,
                                Attachments = attachments,
                                RandomId = new Random().Next()
                            };

                            if (msg.FromId != acc.Myself.Id) {
                                msp.ForwardMessages = new List<long> { msg.Id.Value };
                                api.Messages.Send(msp);

                                if (stickerId != -1)
                                    msp.StickerId = (uint)stickerId;
                                api.Messages.Send(msp);
                            }
                        }
                    }
                    break;
                case TypeOfTarget.PersonalMessage: {
                        MessagesSendParams msp = new MessagesSendParams() {
                            UserId = targetData.Id1,
                            Message = message,
                            Attachments = attachments,
                            RandomId = new Random().Next()
                        };

                        foreach (var msg in history.Messages) {
                            if (msg.FromId != acc.Myself.Id) {
                                msp.ForwardMessages = new List<long> { msg.Id.Value };
                                api.Messages.Send(msp);

                                if (stickerId != -1)
                                    msp.StickerId = (uint)stickerId;
                                api.Messages.Send(msp);
                            }
                        }
                    }
                    break;
                case TypeOfTarget.NotFound:
                    break;
                default:
                    LogForm.PushToLog(acc, $"[Автоответчик]: \"{atg.Link}\" - неподдерживаемый формат ссылки");
                    break;
            }
        }
        /// <summary>
        /// Получить историю чата
        /// </summary>
        /// <returns></returns>
        private MessageGetHistoryObject GetHistory(Account acc, AutoansTarget at) {
            var api = acc.VkApi;
            var targetData = LinkParser.Parse(acc, at.Link);

            MessageGetHistoryObject history = null;
            switch (targetData.Type) {
                case TypeOfTarget.PersonalMessage:
                    history = api.Messages.GetHistory(new MessagesGetHistoryParams() {
                        Count = 1,
                        UserId = targetData.Id1
                    });
                    break;
                case TypeOfTarget.Chat:
                    history = api.Messages.GetHistory(new MessagesGetHistoryParams() {
                        Count = 1,
                        PeerId = 2000000000 + targetData.Id1
                    });
                    break;
            }


            return history;
        }
        /// <summary>
        /// Получить ID пользователя
        /// </summary>
        /// <param name="acc"></param>
        /// <returns></returns>
        private string GetUserId(Account acc) {
            var api = acc.VkApi;
            var userInfo = api.Users.Get(new[] { acc.Myself.Id }).FirstOrDefault();
            return $"{userInfo.Id}";
        }
        private void AsyncWorker(Account acc) {
            Random random = new Random();
            var ats = acc.AutoansTaskSettings;
            ats.LoadAccountSpecific(acc);
            var targets = ats.Targets;

            int targetIter = -1;


            void DoFlood() {
                if (!ats.Enabled) {
                    PeriodicTimer?.Dispose();
                    PeriodicTimer = null;
                    return;
                }

                lock (targets) {
                    targetIter = (targetIter + 1) % targets.Count;

                    try {
                        AutoansTarget atg = targets[targetIter];

                        SendFlood(acc, atg);
                    }
                    catch (Exception ex) {
                        LogForm.PushToLog(acc, "[Автоответчик]: " + ex.Message);
                    }
                }
            }

            PeriodicTimer = new SingleSimrunTimer(DoFlood, ats.Delay);
        }

        public override void LaunchTask(Account acc) {
            if (!acc.AutoansTaskSettings.Enabled)
                return;
            if (acc.AutoansTaskSettings.Targets.Count == 0) {
                LogForm.PushToLog(acc, "[Автоответчик]: ошибка запуска - отсутствуют цели");
                return;
            }

            new Task(() => AsyncWorker(acc)).Start();
        }

        public override void StopTask() {
            PeriodicTimer?.Dispose();
            PeriodicTimer = null;
        }
    }
}
