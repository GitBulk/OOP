using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.StackEx
{
    class StackWithMin2 : Stack<int>
    {
        Stack<int> s2;
        public StackWithMin2()
        {
            s2 = new Stack<int>();
        }

        public new void Push(int value)
        {
            if (value <= GetMinValue())
            {
                s2.Push(value);
            }
            base.Push(value);
        }

        public new int Pop()
        {
            int value = base.Pop();
            if (value == GetMinValue())
            {
                s2.Pop();
            }
            return value;
        }

        public int GetMinValue()
        {
            if (s2.IsEmpty())
            {
                return int.MaxValue;
            }
            else
            {
                return s2.Peek();
            }
        }
    }
}
