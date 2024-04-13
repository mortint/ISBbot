using Newtonsoft.Json;

namespace ISP.Misc {
    /// <summary>
    /// Класс-утилита для клонирования объектов
    /// </summary>
    internal static class Cloner {
        /// <summary>
        /// Создает глубокую копию объекта, используя сериализацию и десериализацию JSON
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="source">Исходный объект, который нужно клонировать</param>
        /// <returns>Клонированный объект</returns>
        public static T Clone<T>(T source) {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }

}
