using ISP.Engine.Accounts;
using ISP.Enums.Parser;
using ISP.Forms;
using ISP.Objects.Targets;
using System;
using System.Windows.Forms;
using VkNet.Model;

namespace ISP.Engine.Helpers {
    internal static class MessageSender {
        /// <summary>
        /// Отправить голосовое сообщение
        /// </summary>
        /// <param name="from">Аккаунт, с которого отправить</param>
        /// <param name="to">Параметры функции</param>
        /// <param name="message">Текст сообщения</param>
        public static void SendVoiceMessage(Account from, TargetData to, string message) {
            var msp = new MessagesSendParams();
            msp.RandomId = new Random().Next();
            switch (to.Type) {
                case TypeOfTarget.Chat:
                    msp.ChatId = to.Id1;
                    break;
                case TypeOfTarget.PersonalMessage:
                    msp.UserId = to.Id1;
                    break;
                default:
                    LogForm.PushToLog(from, "Неверный формат цели голосового сообщения");
                    return;
            }

            var api = from.VkApi;

            if (from.VoiceTaskSettings.SendCustomAudio)
                msp.Attachments = from.FlooderTaskSettings.CustomSendVoiceMessage(from);
            else
                msp.Attachments = from.FlooderTaskSettings.VoiceMessage(from, message);
            api.Messages.Send(msp);

            MessageBox.Show("Голосовое сообщение успешно отправлено", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
