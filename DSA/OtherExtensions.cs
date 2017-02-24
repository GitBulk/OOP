using System;
using System.Linq;

namespace DSA
{
    public static class OtherExtensions
    {
        public static bool IsInRange<T>(this T source, T minimum, T maximum) where T:IComparable<T>
        {
            return source.CompareTo(minimum) >= 0 && source.CompareTo(maximum) <= 0;
        }

        public static bool IsInt<T>(this T source, params T[] values)
        {
            return values.Contains(source);
        }
    }
}
