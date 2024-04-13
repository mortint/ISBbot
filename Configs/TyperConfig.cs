using Newtonsoft.Json;
using System.IO;

namespace ISP.Configs {
    internal sealed class TyperConfig : ISBConfig {
        /// <summary>
        /// Задержка набора текста
        /// </summary>
        public int TypingDelay;
        /// <summary>
        /// Задержка перед нажатиями клавиш
        /// </summary>
        public int SendingDelay;
        /// <summary>
        /// Обращение
        /// </summary>
        public string Name;
        /// <summary>
        /// Расположение обращения
        /// </summary>
        public int NamePlacement;
        /// <summary>
        /// Фразы по порядку
        /// </summary>
        public bool InOrder;

        public TyperConfig() {
            TypingDelay = 100;
            SendingDelay = 1000;
            Name = "";
            NamePlacement = 0;
        }
        /// <summary>
        /// Сохранение настроек Typer
        /// </summary>
        public void Save() {
            File.WriteAllText("Configs\\typerConfig.json", JsonConvert.SerializeObject(this));
        }
    }
}
