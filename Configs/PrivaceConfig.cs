using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace ISP.Configs {
    internal sealed class PrivaceConfig : ISBConfig {
        /// <summary>
        /// Флаг закрыт ли профиль vk.com
        /// </summary>
        public bool ClosedProfile;
        /// <summary>
        /// Версия приложения
        /// </summary>
        public string AppVersion;

        public PrivaceConfig() {
            ClosedProfile = false;
            AppVersion = Application.ProductVersion;
        }
        /// <summary>
        /// Сохранить настройки приватности
        /// </summary>
        public void Save()
            => File.WriteAllText("Configs\\privaceConfig.json", JsonConvert.SerializeObject(this, Formatting.Indented));
    }
}
