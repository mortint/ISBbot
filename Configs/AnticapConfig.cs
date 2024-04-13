using Newtonsoft.Json;
using System.IO;

namespace ISP.Configs {
    internal enum SelectedMode {
        /// <summary>
        /// RuCaptcha
        /// </summary>
        Rucaptcha,
        /// <summary>
        /// AntiCaptcha (ex anti-gate)
        /// </summary>
        Anticaptcha,
        /// <summary>
        /// ISB GPT (custom solver)
        /// </summary>
        IsbGPT,
        /// <summary>
        /// Ручной ввод
        /// </summary>
        Manual
    };

    internal sealed class AnticapConfig : ISBConfig {
        /// <summary>
        /// Ключ rucaptcha.com
        /// </summary>
        public string RucaptchaKey;
        /// <summary>
        /// Ключ anti-captcha.com
        /// </summary>
        public string AnticaptchaKey;
        /// <summary>
        /// Ключ gpt.isbsystem.ru
        /// </summary>
        public string ISBGptKey;
        /// <summary>
        /// Текущий выбор сервиса
        /// </summary>
        public SelectedMode SelectedMode;

        public AnticapConfig() {
            RucaptchaKey = AnticaptchaKey = ISBGptKey = "";
            SelectedMode = SelectedMode.Manual;
        }
        /// <summary>
        /// Сохранение конфигурации антикапчи
        /// </summary>
        public void Save() {
            File.WriteAllText("Configs\\anticapConfig.json", JsonConvert.SerializeObject(this));
        }
    }
}
