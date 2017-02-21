using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    sealed class Singleton
    {
        private static readonly object LockThis = new object();
        private static volatile Singleton Instance;

        private Singleton()
        {

        }

        public static Singleton Current()
        {
            if (Instance == null)
            {
                lock (LockThis)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
            }
            return Instance;
        }
    }
}
