namespace ISP.Misc {
    internal static class StrWrk {
        /// <summary>
        /// Возвращает подстроку из строки до или после указанной подстроки
        /// </summary>
        /// <param name="str">Исходная строка</param>
        /// <param name="substr">Подстрока для поиска</param>
        /// <param name="before">Флаг указывающий на поиск до подстроки (по умолчанию - после)</param>
        /// <returns>Подстрока до или после найденной подстроки</returns>
        public static string QSubstr(string str, string substr, bool before = false) {
            if (before) {
                return str.Substring(0, str.IndexOf(substr));
            }
            return str.Substring(str.IndexOf(substr) + substr.Length);
        }

        /// <summary>
        /// Возвращает подстроку между двумя указанными строками
        /// </summary>
        /// <param name="str">Исходная строка</param>
        /// <param name="left">Левая граница поиска</param>
        /// <param name="right">Правая граница поиска</param>
        /// <returns>Подстрока между левой и правой границей</returns>
        public static string GetBetween(string str, string left, string right) {
            return QSubstr(QSubstr(str, left), right, true);
        }

    }
}
