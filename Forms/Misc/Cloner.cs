using Newtonsoft.Json;

namespace ISP.Misc
{
    internal static class Cloner
    {
        public static T Clone<T>(T source)
        {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
