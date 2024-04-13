using ISP.Misc;

namespace ISP.Tasks.Settings {
    internal sealed class VoiceTaskSettings : ISBTaskSettings {
        /// <summary>
        /// Голос
        /// </summary>
        public string Voice = "zahar";
        /// <summary>
        /// Эмоция
        /// </summary>
        public string Emotion = "neutral";
        /// <summary>
        /// Скорость 
        /// </summary>
        public int Speed = 10;
        /// <summary>
        /// Yandex API Key
        /// </summary>
        public string Yandexapi;
        /// <summary>
        /// Сообщение
        /// </summary>
        public string Message;
        /// <summary>
        /// Ссылка на цель
        /// </summary>
        public string Target;
        /// <summary>
        /// Путь к MP3 файлу 
        /// </summary>
        public string AudioMp3Name;
        /// <summary>
        /// Отправить свое аудио как голосовое сообщение
        /// </summary>
        public bool SendCustomAudio;

        public override void Validate() {
            Speed = Speed.Cut(1, 30);
        }
    }
}
