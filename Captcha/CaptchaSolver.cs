using ISP.Configs;
using ISP.Forms;
using VkNet.Utils.AntiCaptcha;

namespace ISP.Captcha {
    /// <summary>
    /// Основной класс для работы с капчей
    /// </summary>
    internal sealed class CaptchaSolver : ICaptchaSolver {
        public void CaptchaIsFalse() {
            LogForm.PushToLog("Капча была распознана неверно");
        }
        /// <summary>
        /// Выбор сервиса капчи
        /// </summary>
        /// <param name="url">Ссылка на капчу</param>
        /// <returns></returns>
        public string Solve(string url) {
            switch (ConfigController.AnticapConfig.SelectedMode) {
                case SelectedMode.Rucaptcha:
                    return new AntiCaptchaService().Solve(url);
                case SelectedMode.Anticaptcha:
                    return new AntiCaptchaService().Solve(url);
                case SelectedMode.IsbGPT:
                    return new CustomCaptchaService().Solve(url);
                default:
                    return "Не выбран сервис антикапчи";
            }
        }
    }
}