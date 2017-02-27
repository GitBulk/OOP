using System;

namespace DSA.StackEx
{
    class Frame
    {
        public static void Run()
        {
            //var stack = new StackWithMin();
            //stack.Push(5);
            //int min = stack.GetMinValue();
            //Console.WriteLine("Min: " + min);

            //stack.Push(6);
            //min = stack.GetMinValue();
            //Console.WriteLine("Min: " + min);

            //stack.Push(3);
            //min = stack.GetMinValue();
            //Console.WriteLine("Min: " + min);


            var stack = new StackWithMin2();
            stack.Push(5);
            int min = stack.GetMinValue();
            Console.WriteLine("Min: " + min);

            stack.Push(6);
            min = stack.GetMinValue();
            Console.WriteLine("Min: " + min);

            stack.Push(3);
            min = stack.GetMinValue();
            Console.WriteLine("Min: " + min);
        }
    }
}
