using Newtonsoft.Json;
using System.Drawing;
using System.IO;

namespace ISP.Configs {
    internal sealed class InterfaceConfig : ISBConfig {
        /// <summary>
        /// Путь к изображению на фон приложения
        /// </summary>
        public string PathToBackgroundImgGeneral;
        /// <summary>
        /// Путь к изображению на фон вкладок
        /// </summary>
        public string PathToBackgroundImgTabs;
        /// <summary>
        /// Цвет текста приложения
        /// </summary>
        public int ForColorAsArgb;
        /// <summary>
        /// Цвет фона приложения
        /// </summary>
        public int ForColorApplications;

        public InterfaceConfig() {
            PathToBackgroundImgGeneral = PathToBackgroundImgTabs = null;
            ForColorAsArgb = Color.Black.ToArgb();
            ForColorApplications = Color.FromArgb(100, 100, 100).ToArgb();
        }
        /// <summary>
        /// Сохранение настроек интерфейса приложения
        /// </summary>
        public void Save() {
            File.WriteAllText("Configs\\interfaceConfig.json", JsonConvert.SerializeObject(this));
        }
    }
}
