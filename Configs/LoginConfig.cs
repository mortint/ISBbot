using Newtonsoft.Json;
using System.IO;

namespace ISP.Configs {
    internal sealed class LoginConfig : ISBConfig {
        /// <summary>
        /// Пароль для входа
        /// </summary>
        public string Password;
        public LoginConfig() {
            Password = "";
        }
        /// <summary>
        /// Сохранение конфигурации приложения (форма авторизации)
        /// </summary>
        public void Save()
            => File.WriteAllText("Configs\\loginConfig.json", JsonConvert.SerializeObject(this, Formatting.Indented));
    }
}
