using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    class Program
    {
        static void Main(string[] args)
        {
            //FuncInCSharp.ExecuteFunc();
            //FuncInCSharp.ExecuteDelegate();
            //FuncInCSharp.ExecuteLambda();
            //FuncInCSharp.ExecuteAnonymousMethod();


            DateTime now = DateTime.Now;
            DateTime utc = DateTime.UtcNow;
            Console.WriteLine(now);
            Console.WriteLine(utc);
        }
    }
}
