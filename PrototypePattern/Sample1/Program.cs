using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Sample1
{
    class Program
    {
        public static void Excute()
        {
            var developer = new Developer();
            developer.Name = "Toan Tran";
            developer.PreferredLanguage = "C#";
            developer.Role = "Dev";
            Developer devCopy = (Developer)developer.Clone();
            devCopy.Name = "Messi";
            devCopy.PreferredLanguage = "Java";
            Console.WriteLine(developer.GetDetails());
            Console.WriteLine(devCopy.GetDetails());
            Console.ReadLine();
        }
    }
}
