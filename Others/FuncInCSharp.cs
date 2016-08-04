using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    public static class FuncInCSharp
    {
        const string Name = "toan";
        delegate string ConvertMethod(string inString);

        private static string UppercaseString(string input)
        {
            return input.ToUpper();
        }

        public static void ExecuteDelegate()
        {
            ConvertMethod convertMethod = UppercaseString;

            Console.WriteLine(convertMethod(Name));
        }

        public static void ExecuteFunc()
        {
            Func<string, string> convertMethod = UppercaseString;
            Console.WriteLine(convertMethod(Name));
        }

        public static void ExecuteLambda()
        {
            Func<string, string> convertMethod = s => s.ToUpper();
            Console.WriteLine(convertMethod(Name));
        }

        public static void ExecuteAnonymousMethod()
        {
            Func<string, string> convert = delegate (string s)
            {
                return s.ToUpper();
            };
            Console.WriteLine(convert(Name));
        }
    }
}
