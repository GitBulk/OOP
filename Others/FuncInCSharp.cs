using System;

namespace Others
{
    public static class FuncInCSharp
    {
        const string Name = "toan";

        delegate string SampleDelegate(string input);

        private static string UppercaseString(string input)
        {
            return input.ToUpper();
        }

        public static void ExecuteDelegate()
        {
            SampleDelegate instance = UppercaseString;
            Console.WriteLine(instance("oojnl"));
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
