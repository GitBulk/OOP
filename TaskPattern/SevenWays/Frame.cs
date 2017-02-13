using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPattern.SevenWays
{
    class Frame
    {
        public static void Run()
        {
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("way 1");
            });

            Task task = new Task(() =>
            {
                Console.WriteLine("way 2");
            });
            task.Start();

            Task task3 = new Task(delegate
            {
                Console.WriteLine("way 3");
            });
            task3.Start();

            Task task4 = new Task(new Action(Print4));
            task4.Start();

            Task task5 = new Task(() => Print5());
            task5.Start();
        }

        private async static Task DoTask2()
        {
            int res = await Task.FromResult<int>(Sum(4, 6));
            Console.WriteLine("way 7, rum: " + res);
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private async static Task DoWork()
        {
            await Task.Run(() => Print6());
        }

        private static void Print6()
        {
            Console.WriteLine("way 6");
        }

        private static void Print5()
        {
            Console.WriteLine("way 5");
        }

        private static void Print4()
        {
            Console.WriteLine("way 4");
        }
    }
}
