using System;

namespace ISP.Misc {
    internal static class IntExtend {
        /// <summary>
        /// Ограничивает число в заданных пределах
        /// </summary>
        /// <param name="i">Число, которое нужно ограничить</param>
        /// <param name="min">Минимальное значение предела</param>
        /// <param name="max">Максимальное значение предела</param>
        /// <returns>Число, ограниченное в заданных пределах</returns>
        public static int Cut(this int i, int min, int max) {
            return Math.Max(Math.Min(i, max), min);
        }
    }
}
