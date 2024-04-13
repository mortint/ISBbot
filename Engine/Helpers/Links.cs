namespace ISP.Engine.Helpers {
    public class Links {
        /// <summary>
        /// Адрес сервера
        /// </summary>
        private static string Domains = "";
        /// <summary>
        /// Конфигурация бота
        /// </summary>
        public static string Configs = $"{Domains}/helpers/settings.php";
        /// <summary>
        /// Проверка пользователя на наличие учетной записи
        /// </summary>
        public static string Index = $"{Domains}/index.php";
        /// <summary>
        /// Проверка обновлений
        /// </summary>
        public static string Updates = $"{Domains}/update/index.php";
        /// <summary>
        /// Ссылка на скачивание
        /// </summary>
        public static string Download = $"{Domains}/isb.rar";
        /// <summary>
        /// Баны по IP
        /// </summary>
        public static string BannedIP = $"{Domains}/helpers/banip.php";
        /// <summary>
        /// User-agent 
        /// </summary>
        public static string UserAgent = "isb/v1";
        /// <summary>
        /// Referer сайта
        /// </summary>
        public static string Referer = "free-simcard.site";
    }
}
