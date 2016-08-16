using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Sample1
{
    class Program
    {
        public static void Excute()
        {
            new PizzaMachine().Excute();
            Console.ReadKey();
        }
    }
}
