namespace ISP.Tasks.Settings {
    public abstract class ISBTaskSettings {
        /// <summary>
        /// Флаг активна ли функция
        /// </summary>
        public bool Enabled = false;
        /// <summary>
        /// Минимальная задержка
        /// </summary>
        public int Delay = 333;
        /// <summary>
        /// Максимальная задержка
        /// </summary>
        public int DelayMax = 333;
        /// <summary>
        /// Тип задержки
        /// </summary>
        public string SelectionDelay;
        public abstract void Validate();
    }
}
