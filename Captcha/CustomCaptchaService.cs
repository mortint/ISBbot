using ISP.Configs;
using ISP.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Utils.AntiCaptcha;

namespace ISP.Captcha {
    /// <summary>
    /// Класс для работы с капчей на ИИ
    /// </summary>
    internal class CustomCaptchaService : ICaptchaSolver {
        private const SelectedMode CaptchaMode = SelectedMode.IsbGPT;
        private static readonly SemaphoreSlim _captchaSolverSemaphore = new SemaphoreSlim(1, 1);
        private readonly HttpClient _httpClient = new HttpClient() {
            BaseAddress = new Uri(Globals.GptCaptchaUrl),
            Timeout = TimeSpan.FromMinutes(1)
        };

        public string Solve(string url) {
            LogForm.PushToLog($"[{CaptchaMode}]: Упс, у нас капча, пытаюсь решить...");
            var stopwatch = new Stopwatch();

            var key = ExtractKey();

            try {
                var loadedCaptcha = DownloadCaptchaByUrl(url);

                var request = new HttpRequestMessage {
                    RequestUri = new Uri($"{Globals.GptCaptchaUrl}/api/v1/solver"),
                    Method = HttpMethod.Post,
                    Content = new MultipartFormDataContent
                    {
                        {
                            new ByteArrayContent(loadedCaptcha)
                            {
                                Headers =
                                {
                                    ContentType = new MediaTypeHeaderValue("image/jpeg"),
                                }
                            },
                            "captcha",
                            "captcha.jpg"
                        },
                        {
                            new StringContent(key),
                            "key"
                        }
                    }
                };

                stopwatch.Start();

                var response = _httpClient.SendAsync(request).GetAwaiter().GetResult();
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                stopwatch.Stop();

                var solvedSeconds = stopwatch.Elapsed.TotalSeconds;
                var json = JObject.Parse(content);

                if (!json.Value<bool>("response")) {
                    LogForm.PushToLog($"[{CaptchaMode}]: При решении капчи произошла ошибка\n{json.ToString(Formatting.None)}");
                    return null;
                }

                var data = json.GetValue("data") as JObject;
                if (data == null || data["solved"] == null) {
                    LogForm.PushToLog($"[{CaptchaMode}]: При решении капчи произошла ошибка\n{json.ToString(Formatting.None)}");
                    return null;
                }

                var solved = data["solved"]?.ToObject<string>();
                if (string.IsNullOrEmpty(solved)) {
                    LogForm.PushToLog($"[{CaptchaMode}]: При решении капчи произошла ошибка\n{json.ToString(Formatting.None)}");
                    return null;
                }

                LogForm.PushToLog($"[{CaptchaMode}]: Капча решена {solved} за {solvedSeconds} секунд");

                Task.Delay(1000).Wait();

                return solved;
            }
            catch (Exception ex) {
                LogForm.PushToLog($"[{CaptchaMode}]: При решении капчи произошла ошибка\n{ex.Message}");
                return null;
            }
        }

        public void CaptchaIsFalse() {
            LogForm.PushToLog("Капча была распознана неверно");
        }

        private static string ExtractKey() {
            var key = ConfigController.AnticapConfig?.ISBGptKey.Trim();
            if (string.IsNullOrEmpty(key)) {
                throw new NullReferenceException($"[{CaptchaMode}]: заполните ключ");
            }

            return key;
        }

        private byte[] DownloadCaptchaByUrl(string url) {
            var response = _httpClient.GetAsync(url).GetAwaiter().GetResult();
            var content = response.Content;

            return content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
        }
    }
}
