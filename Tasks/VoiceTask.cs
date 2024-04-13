using ISP.Engine.Accounts;
using ISP.Engine.Helpers;
using ISP.Forms;
using System;
using System.Threading.Tasks;

namespace ISP.Tasks {
    internal sealed class VoiceTask : ISBTask {
        private void AsyncWorker(Account acc) {
            try {
                var vts = acc.VoiceTaskSettings;

                if (!vts.SendCustomAudio) {
                    if (vts.Yandexapi == "" || vts.Target == "" || vts.Message == "") {
                        LogForm.PushToLog(acc, "Невозможно отправить голосовое сообщение - не заполнены все поля");
                        return;
                    }
                }
                else {
                    if (vts.AudioMp3Name == null) {
                        LogForm.PushToLog("Не выбран файл аудиозаписи");
                        return;
                    }
                }

                MessageSender.SendVoiceMessage(acc, LinkParser.Parse(acc, vts.Target), vts.Message);
                LogForm.PushToLog(acc, "Голосовое сообщение успешно отправлено");
            }
            catch (Exception ex) {
                LogForm.PushToLog(acc, $"Ошибка во время отправки голосового сообщения: {ex.Message}");
            }
        }

        public override void LaunchTask(Account acc) {
            new Task(() => AsyncWorker(acc)).Start();
        }

        public override void StopTask() {

        }
    }
}
