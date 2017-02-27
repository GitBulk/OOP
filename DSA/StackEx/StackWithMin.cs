using System;
using System.Collections.Generic;

namespace DSA.StackEx
{
    class StackWithMin: Stack<NodeWithMin>
    {
        public void Push(int value)
        {
            int newMin = Math.Min(value, GetMinValue());
            base.Push(new NodeWithMin(value, newMin));
        }

        public int GetMinValue()
        {
            if (this.Count == 0) // empty
            {
                return int.MaxValue;
            }
            else
            {
                return Peek().min;
            }
        }
    }

    class NodeWithMin
    {
        public int value;
        public int min;

        public NodeWithMin(int value, int min)
        {
            this.value = value;
            this.min = min;
        }
    }
    
}
