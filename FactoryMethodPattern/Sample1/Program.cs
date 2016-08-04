using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Sample1
{
    public static class Program
    {
        public static void Excute()
        {
            Student vietnameStudent = new VietnamStudent();
            Student usaStudent = new USAStudent();
            Console.WriteLine("Vietnam Student");
            vietnameStudent.Learn();
            Console.WriteLine("==============");
            Console.WriteLine("USA Student");
            usaStudent.Learn();
            Console.ReadLine();
        }
    }
}
