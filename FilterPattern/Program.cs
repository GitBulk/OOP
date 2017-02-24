using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FilterPattern
{
    class Program
    {
        static Random rand = new Random();

        /// <summary>
        /// Create a random string
        /// </summary>
        /// <param name="length">Length of random string (length must be > 1)</param>
        /// <returns>A random string</returns>
        public static string CreateRandomString(int length = 5)
        {
            if (length < 2)
            {
                throw new Exception("Length must be > 1");
            }
            string temp = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890qwertyuiopasdfghjklzxcvbnm";
            var builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int randomValue = rand.Next(temp.Length);
                builder.Append(temp[randomValue]);
            }
            return builder.ToString();
        }

        public static string OneWhiteSpace(string input)
        {
            // \s is white space character
            // + one or more matches
            return Regex.Replace(input.Trim(), @"\s+", " ");
        }

        public static string UniqueFilename(string userIdentity, string fileName)
        {
            // yyyyMMddHHmmss: 20170927141009 ( format 24h, 5PM will be 17)
            string datePart = DateTime.Now.ToString("yyyyMMddHHmmss");
            string randomString = CreateRandomString(9);
            fileName = OneWhiteSpace(fileName).Replace(" ", "-");
            string returnValue = string.Format("{0}-{1}-{2}-{3}", userIdentity, datePart, randomString, fileName).ToLower();

            return returnValue;
        }

        static void Main(string[] args)
        {
            //Sample1.Program.Excute();
            Parallel.For(0, 100, i =>
            {
                Console.WriteLine(UniqueFilename(i.ToString(), "KaKa.jpg"));
            });
        }
    }
}
