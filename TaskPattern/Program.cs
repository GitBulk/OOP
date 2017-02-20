using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPattern.ConcurrentThings;

namespace TaskPattern
{
    class Program
    {
        private static string result;


        static void Main(string[] args)
        {
            //SevenWays.Frame.Run();
            //ConcurrentThings.Frame.RunStack();
            //ConcurrentThings.Frame.RunQueue();
            //ShareData.Frame.Run();

            //Circle circle = new Circle();
            //double value = circle.Calculate(p => p * 2);
            //Console.WriteLine(value);

            SaySomething();
            Console.WriteLine(result);
        }

        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "Hello world!";
            return "Something";
        }
    }
}
