using System;
namespace ExtensionMethods
{
    public static class Extensions
    {
        public static bool isGreater(this int i, int value)
        {
            return i > value;
        }

        public static bool isLonger(this string text, string value)
        {
            return text.Length > value.Length;
        }
    }
}
