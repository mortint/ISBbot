using ISP.Configs;
using ISP.Forms;
using ISP.Misc;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using VkNet.Utils.AntiCaptcha;

namespace ISP.Captcha {
    /// <summary>
    /// Класс для работы с капчей ручного ввода
    /// </summary>
    internal class ManualCaptchaService : ICaptchaSolver {
        public static readonly Queue<string> CaptchaManualIdsToSolve = new Queue<string>();
        public static readonly Dictionary<string, string> CaptchaManualAnswers = new Dictionary<string, string>();
        private const SelectedMode CaptchaMode = SelectedMode.Manual;

        public async void DownloadFileAsync(string url, string fileName) {
            using (HttpClient client = new HttpClient()) {
                byte[] fileBytes = await client.GetByteArrayAsync(url);

                if (fileBytes != null)
                    File.WriteAllBytes(fileName, fileBytes);
                else
                    LogForm.PushToLog("[Капча]: Не удалось загрузить картинку");
            }
        }
        public string Solve(string url) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var sid = StrWrk.GetBetween(url, "sid=", "&").Trim();
            var fileName = $"Tmp\\{sid}.png";
            DownloadFileAsync(url, fileName);
            CaptchaManualIdsToSolve.Enqueue(sid);

            var tcs = new TaskCompletionSource<string>();

            LogForm.PushToLog($"[{CaptchaMode}]: Капча поставлена на ручной ввод...");

            while (!CaptchaManualAnswers.ContainsKey(sid))
                Task.Delay(1000).Wait();

            tcs.SetResult(CaptchaManualAnswers[sid]);

            var result = tcs.Task.Result;

            stopwatch.Stop();
            var solvedSeconds = stopwatch.Elapsed.TotalSeconds;

            CaptchaManualAnswers.Remove(sid);

            LogForm.PushToLog($"[{CaptchaMode}]: Капча решена {result} за {solvedSeconds} секунд");
            return result;
        }
        public void CaptchaIsFalse() {
            LogForm.PushToLog("Капча была распознана неверно");
        }
    }
}
