using System.Collections.Generic;

namespace DSA
{

    public static class StackExtension
    {
        public static bool IsEmpty<T>(this Stack<T> stack)
        {
            return stack.Count == 0;
        }
    }
}
