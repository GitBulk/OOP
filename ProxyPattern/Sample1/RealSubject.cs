using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Sample1
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Request from RealSubject");
        }
    }
}
