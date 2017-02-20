using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace TaskPattern.ConcurrentThings
{
    class Frame
    {
        public static void RunStack()
        {

            ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();
            for (int i = 0; i < 50000; i++)
            {
                concurrentStack.Push(i);
            }

            int counter = 0;
            Task[] tasks = new Task[10];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Factory.StartNew(() =>
                {
                    while (concurrentStack.Count > 0)
                    {
                        int currentElement;
                        bool success = concurrentStack.TryPop(out currentElement);
                        if (success)
                        {
                            Interlocked.Increment(ref counter);
                        }
                    }
                });
            }

            Task.WaitAll(tasks);
            Console.WriteLine("Counter: " + counter);
        }

        public static void RunQueue()
        {
            var concurrentQueue = new ConcurrentQueue<int>();
            for (int i = 0; i < 5000; i++)
            {
                concurrentQueue.Enqueue(i);
            }

            int counter = 0;
            Task[] workers = new Task[20];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = Task.Factory.StartNew(() =>
                {
                    while (concurrentQueue.Count > 0)
                    {
                        int currentElement;
                        bool success = concurrentQueue.TryDequeue(out currentElement);
                        if (success)
                        {
                            Interlocked.Increment(ref counter);
                        }
                    }   
                });
            }

            Task.WaitAll(workers);
            Console.WriteLine("counter: {0}", counter);
        }

        class Serie
        {
            public int CurrentValue { get; set; }
        }
    }

    class Circle
    {
        private double radius;
        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
}
