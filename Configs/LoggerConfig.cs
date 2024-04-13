using Newtonsoft.Json;
using System.IO;

namespace ISP.Configs {
    internal class LoggerConfig : ISBConfig {
        /// <summary>
        /// Флаг включено ли логирование
        /// </summary>
        [JsonProperty("enabled_logger")] public bool Enabled { get; set; }

        public void Save()
            => File.WriteAllText(Path.Combine("Configs", "logger.json"), JsonConvert.SerializeObject(this, Formatting.Indented));
    }
}
