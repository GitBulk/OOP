using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Sample1
{
    static class Program
    {
        public static void Excute()
        {
            Proxy proxy = new Proxy();
            proxy.Request();
            Console.ReadLine();
        }
    }
}
