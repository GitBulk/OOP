using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursive
{
    class Frame
    {
        // https://www.codeproject.com/Articles/142292/Recursive-methods-in-Csharp
        // http://www.maths.surrey.ac.uk/hosted-sites/R.Knott/Fibonacci/fibtable.html
        // http://introcs.cs.princeton.edu/java/23recursion/
        public static void Run()
        {
            int factorial = Factorial(5);
            Console.WriteLine("Factorial: " + factorial);
            long fibo = Fibo(6);
            Console.WriteLine("Fibo 6: " + fibo);
            Console.WriteLine("Sumfibo 6:" + SumFibo(6));
        }

        private static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        private static long SumFibo(int n)
        {
            return (n < 0 ? 0 : (Fibo(n) + SumFibo(n - 1)));
        }

        private static long Fibo(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return Fibo(n - 2) + Fibo(n - 1);
        }
    }
}
