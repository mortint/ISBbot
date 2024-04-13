using System;

namespace ISP.Misc
{
    internal static class IntExtend
    {
        public static int Cut(this int i, int min, int max)
        {
            return Math.Max(Math.Min(i, max), min);
        }
    }
}
