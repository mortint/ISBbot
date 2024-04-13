using ISP.Configs;
using ISP.Forms;
using ISP.Misc;
using JungFranco.AntiCaptcha;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using VkNet.Utils.AntiCaptcha;

namespace ISP.Captcha {
    /// <summary>
    /// Класс для работы с сервисом anti-captcha.com
    /// </summary>
    internal class AntiCaptchaService : ICaptchaSolver {
        private static SelectedMode CaptchaMode = SelectedMode.Rucaptcha;

        public static string GetBalance(string host, string key) {
            var cc = new CaptchaClient(host, key);
            var balance = cc.GetBalance();

            return balance.ToString("F");
        }

        public string Solve(string url) {
            LogForm.PushToLog($"[{CaptchaMode}]: Упс, у нас капча, пытаюсь решить...");
            var stopwatch = new Stopwatch();
            var sid = StrWrk.GetBetween(url, "sid=", "&").Trim();
            var filename = $"tmp\\{sid}.png";
            var host = "";
            var key = "";


            switch (CaptchaMode) {
                case SelectedMode.Anticaptcha:
                    host = Globals.AntiCaptchaUrl;
                    key = ConfigController.AnticapConfig.AnticaptchaKey;
                    break;
                case SelectedMode.Rucaptcha:
                    host = Globals.RuCaptchaUrl;
                    key = ConfigController.AnticapConfig.RucaptchaKey;
                    break;
            }

            try {

                var cc = new CaptchaClient(host, key);
                var capId = cc.UploadCaptchaFile(filename);

                File.Delete(filename);

                string answer = null;

                while (string.IsNullOrEmpty(answer)) {
                    Task.Delay(TimeSpan.FromSeconds(1)).Wait();

                    try {
                        answer = cc.GetCaptcha(capId);
                    }
                    catch (Exception ex) {
                        if (!ex.Message.Contains("CAPCHA_NOT_READY"))
                            LogForm.PushToLog("Ошибка обработки капчи: " + ex.Message);
                    }
                }

                LogForm.PushToLog($"[{CaptchaMode}]: Капча {answer} решена за {stopwatch.Elapsed.TotalSeconds} сек");

                return answer;
            }
            catch (Exception ex) {
                LogForm.PushToLog($"[{CaptchaMode}]: При решении капчи произошла ошибка: {ex.Message}");
                return null;
            }
        }

        public void CaptchaIsFalse() {
            LogForm.PushToLog("Капча была распознана неверно");
        }
    }
}
