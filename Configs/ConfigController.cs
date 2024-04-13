using Newtonsoft.Json;
using System.IO;

namespace ISP.Configs {
    /// <summary>
    /// Основной класс для работы с конфигурацией
    /// </summary>
    internal static class ConfigController {
        /// <summary>
        /// Объект для работы с конфигурацией интерфейса приложения
        /// </summary>
        public static InterfaceConfig InterfaceConfig;

        /// <summary>
        /// Объект для работы с конфигурацией антикапчи
        /// </summary>
        public static AnticapConfig AnticapConfig;

        /// <summary>
        /// Объект для работы с конфигурацией Typer
        /// </summary>
        public static TyperConfig TyperConfig;

        /// <summary>
        /// Объект для работы с конфигурацией Antikick
        /// </summary>
        public static AntikickConfig AntikickConfig;

        /// <summary>
        /// Объект для работы с конфигурацией входа в систему
        /// </summary>
        public static LoginConfig LoginConfig;

        /// <summary>
        /// Объект для работы с конфигурацией приватности аккаунта
        /// </summary>
        public static PrivaceConfig PrivaceConfig;

        /// <summary>
        /// Объект для работы с конфигурацией логирования
        /// </summary>
        public static LoggerConfig LoggerConfig;
        /// <summary>
        /// Восстановление конфигурации 
        /// </summary>
        public static void Load() {
            try {
                PrivaceConfig = JsonConvert.DeserializeObject<PrivaceConfig>(File.ReadAllText("Configs\\privaceConfig.json"));
            }
            catch {
                PrivaceConfig = new PrivaceConfig();
            }

            try {
                LoginConfig = JsonConvert.DeserializeObject<LoginConfig>(File.ReadAllText("Configs\\loginConfig.json"));
            }
            catch {
                LoginConfig = new LoginConfig();
            }
            try {
                InterfaceConfig = JsonConvert.DeserializeObject<InterfaceConfig>(File.ReadAllText("Configs\\interfaceConfig.json"));
            }
            catch {
                InterfaceConfig = new InterfaceConfig();
            }
            try {
                TyperConfig = JsonConvert.DeserializeObject<TyperConfig>(File.ReadAllText("Configs\\typerConfig.json"));
            }
            catch {
                TyperConfig = new TyperConfig();
            }
            try {
                AnticapConfig = JsonConvert.DeserializeObject<AnticapConfig>(File.ReadAllText("Configs\\anticapConfig.json"));
            }
            catch {
                AnticapConfig = new AnticapConfig();
            }
            try {
                AntikickConfig = JsonConvert.DeserializeObject<AntikickConfig>(File.ReadAllText("Configs\\antikickConfig.json"));
            }
            catch {
                AntikickConfig = new AntikickConfig();
            }

            try {
                LoggerConfig = JsonConvert.DeserializeObject<LoggerConfig>(File.ReadAllText("Configs\\logger.json"));
            }
            catch {
                LoggerConfig = new LoggerConfig();
            }
        }
    }
}
