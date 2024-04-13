using ISP.Configs;
using ISP.Engine.Accounts;
using ISP.Engine.Helpers;
using ISP.Engine.Network;
using ISP.Enums.Parser;
using ISP.Forms;
using ISP.Misc;
using ISP.Objects.Targets;
using ISP.Tasks.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using VkNet.Model;

namespace ISP.Tasks {
    internal sealed class FlooderTask : ISBTask {
        /// <summary>
        /// Random ID. Указывается в метод messages.send
        /// </summary>
        public int RandomId = 0;
        /// <summary>
        /// Парсинг фраз с сайта damn.ru
        /// </summary>
        /// <returns></returns>
        private string BuildFromDamn(FlooderTarget to) {
            string resp = Network.GET($"https://damn.ru/?name={to.Name}&sex=m");
            resp = StrWrk.GetBetween(resp, "<div class=\"damn\" ", "</div>").Replace("<span class=\"name\">", "").Replace("</span>", "");
            return StrWrk.QSubstr(resp, ">").Replace("&mdash;", "--");
        }
        /// <summary>
        /// Сгенерировать текст сообщения
        /// </summary>
        /// <returns></returns>
        private string BuildRandomMessage(Account acc, FlooderTaskSettings fts, FlooderTarget to) {
            string msg = to.NamePlace != "Вместо ..." ? fts.GetPhrase(acc, to) : fts.GetPhraseWithDots(acc, to);

            switch (to.NamePlace) {
                case "Начало":
                    msg = to.Name + msg;
                    break;
                case "Конец":
                    msg = msg + to.Name;
                    break;
                case "Вместо ...":
                    msg = msg.Replace("...", to.Name);
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
        private void SendFlood(Account acc, FlooderTarget ftg) {
            var api = acc.VkApi;
            var targetData = LinkParser.Parse(acc, ftg.Link);
            var fts = acc.FlooderTaskSettings;

            List<MediaAttachment> attachments = new List<MediaAttachment>();
            string message = "";
            long stickerId = -1;

            switch (ftg.Contains) {
                case "Текст":
                    message = BuildRandomMessage(acc, fts, ftg);
                    break;
                case "Изображение":
                    message = ftg.Name;
                    attachments.AddRange(fts.RandomImage());
                    break;
                case "Изображение+текст":
                    attachments.AddRange(fts.RandomImage());
                    message = BuildRandomMessage(acc, fts, ftg);
                    break;
                case "Голосовое сообщение":
                    attachments.AddRange(fts.VoiceMessage(acc, BuildRandomMessage(acc, fts, ftg)));
                    break;
                case "Стикер":
                    stickerId = (long)fts.RandomSticker(acc, ftg).Last().Id;
                    break;
                case "Текст+стикер": {
                        FlooderTarget ftgtxt = new FlooderTarget(ftg) {
                            Contains = "Текст"
                        };
                        SendFlood(acc, ftgtxt);
                        FlooderTarget ftgstc = new FlooderTarget(ftg) {
                            Contains = "Стикер"
                        };
                        SendFlood(acc, ftgstc);
                    }
                    return;
                case "Видеозапись":
                    attachments.AddRange(fts.RandomVideo());
                    break;
                case "Видеозапись+текст":
                    attachments.AddRange(fts.RandomVideo());
                    message = BuildRandomMessage(acc, fts, ftg);
                    break;
                case "Аудиозапись+текст":
                    attachments.AddRange(fts.RandomAudio());
                    message = BuildRandomMessage(acc, fts, ftg);
                    break;
                case "Аудиозапись+текст+картинка":
                    attachments.AddRange(fts.RandomAudio());
                    message = BuildRandomMessage(acc, fts, ftg);
                    attachments.AddRange(fts.RandomImage());
                    break;
                case "Аудиозапись+картинка":
                    attachments.AddRange(fts.RandomAudio());
                    attachments.AddRange(fts.RandomImage());
                    break;
                case "Документ+текст":
                    attachments.AddRange(fts.RandomDocument());
                    message = BuildRandomMessage(acc, fts, ftg);
                    break;
                case "damn.ru":
                    message = BuildFromDamn(ftg);
                    break;
            }

            switch (targetData.Type) {
                case TypeOfTarget.Chat: {
                        if (ConfigController.AntikickConfig.LeavedIntentionallyFrom != null
                            && ConfigController.AntikickConfig.LeavedIntentionallyFrom.ContainsKey(acc.Login)
                                && ConfigController.AntikickConfig.LeavedIntentionallyFrom[acc.Login]
                                .Contains((ulong)targetData.Id1))
                            break;
                        MessagesSendParams msp = new MessagesSendParams() {
                            ChatId = targetData.Id1,
                            Message = message,
                            Attachments = attachments,
                            RandomId = RandomId
                        };
                        if (stickerId != -1)
                            msp.StickerId = (uint)stickerId;
                        api.Messages.Send(msp);
                    }
                    break;
                case TypeOfTarget.PersonalMessage: {
                        MessagesSendParams msp = new MessagesSendParams() {
                            UserId = targetData.Id1,
                            Message = message,
                            Attachments = attachments,
                            RandomId = RandomId
                        };
                        if (stickerId != -1)
                            msp.StickerId = (uint)stickerId;
                        api.Messages.Send(msp);
                    }
                    break;
                case TypeOfTarget.Photo: {
                        PhotoCreateCommentParams msp = new PhotoCreateCommentParams() {
                            OwnerId = targetData.Id1,
                            PhotoId = (ulong)targetData.Id2,
                            Message = message,
                            Attachments = attachments,
                        };
                        if (stickerId != -1)
                            msp.StickerId = (uint)stickerId;
                        api.Photo.CreateComment(msp);
                    }
                    break;
                case TypeOfTarget.Topic: {
                        BoardCreateCommentParams msp = new BoardCreateCommentParams() {
                            GroupId = targetData.Id1,
                            TopicId = (long)targetData.Id2,
                            Message = message,
                            Attachments = attachments
                        };
                        if (stickerId != -1)
                            msp.StickerId = (uint)stickerId;
                        api.Board.CreateComment(msp);
                    }
                    break;
                case TypeOfTarget.Video: {
                        VideoCreateCommentParams msp = new VideoCreateCommentParams() {
                            OwnerId = targetData.Id1,
                            VideoId = (long)targetData.Id2,
                            Message = message,
                            Attachments = attachments
                        };
                        if (stickerId != -1)
                            msp.StickerId = (uint)stickerId;
                        api.Video.CreateComment(msp);
                    }
                    break;
                case TypeOfTarget.Wall: {
                        WallCreateCommentParams msp = new WallCreateCommentParams {
                            OwnerId = targetData.Id1,
                            PostId = (long)targetData.Id2,
                            Message = message,
                            Attachments = attachments
                        };
                        if (stickerId != -1)
                            msp.StickerId = (uint)stickerId;
                        api.Wall.CreateComment(msp);
                    }
                    break;
                case TypeOfTarget.NotFound:
                    break;
                default:
                    LogForm.PushToLog(acc, $"[Флудер]: \"{ftg.Link}\" - неподдерживаемый формат ссылки");
                    break;
            }
        }

        private void AsyncWorker(Account acc) {
            Random random = new Random();
            var fts = acc.FlooderTaskSettings;
            fts.LoadAccountSpecific(acc);
            var targets = fts.Targets;

            int targetIter = -1;

            void DoFlood() {
                if (!fts.Enabled) {
                    PeriodicTimer?.Dispose();
                    PeriodicTimer = null;
                    return;
                }

                lock (targets) {
                    targetIter = (targetIter + 1) % targets.Count;

                    try {
                        FlooderTarget ftg = targets[targetIter];

                        SendFlood(acc, ftg);
                    }
                    catch (Exception ex) {
                        LogForm.PushToLog(acc, "[Флудер]: " + ex.Message);
                    }
                }
            }

            switch (fts.SelectionDelay) {
                case "Обычная":
                    PeriodicTimer = new SingleSimrunTimer(DoFlood, fts.Delay);
                    break;
                case "Рандомная":
                    PeriodicTimer = new SingleSimrunTimer(DoFlood, random.Next(fts.Delay, fts.DelayMax));
                    break;
            }
        }
        public override void LaunchTask(Account acc) {
            var wc = new WebClient();

            if (!acc.FlooderTaskSettings.Enabled)
                return;
            if (acc.FlooderTaskSettings.Targets.Count == 0) {
                LogForm.PushToLog(acc, "[Флудер]: ошибка запуска - отсутствуют цели");
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
