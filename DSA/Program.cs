using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "(())";
            //Console.WriteLine(input + ": " + Check(input));

            //input = "(([}))";
            //Console.WriteLine(input + ": " + Check(input));

            //input = "{(([]))}";
            //Console.WriteLine(input + ": " + Check(input));
            //input = "((a+1)*2)";
            //Console.WriteLine(input + ": " + Check(input));

            Recursive.Frame.Run();
        }

        private static bool Check(string input)
        {
            //var stack = new Stack<char>();
            var bracketPairs = new Dictionary<char, char>();
            bracketPairs.Add('}', '{');
            bracketPairs.Add(']', '[');
            bracketPairs.Add(')', '(');

            //char currentChar = 'a';
            char currentChar = '\n';
            var stack = new Stack<char>();
            string open = "{([";
            for (int i = 0; i < input.Length; i++)
            {
                currentChar = input[i];
                if (open.IndexOf(currentChar) > -1)
                {
                    stack.Push(currentChar);
                }
                //else if(currentChar == ')')
                //{
                //    if (stack.IsEmpty())
                //        return false;
                //    if (stack.Pop() != '(')
                //        return false;
                //}
                //else if (currentChar == '}')
                //{
                //    if (stack.IsEmpty())
                //        return false;
                //    if (stack.Pop() != '{')
                //        return false;
                //}
                //else if (currentChar == ']')
                //{
                //    if (stack.IsEmpty())
                //        return false;
                //    if (stack.Pop() != '[')
                //        return false;
                //}
                else if (bracketPairs.ContainsKey(currentChar))
                {
                    if (stack.IsEmpty())
                    {
                        return false;
                    }
                    if (stack.Pop() != bracketPairs[currentChar])
                    {
                        return false;
                    }
                }
            }

            return stack.IsEmpty();
        }
    }

    public static class StackExtension
    {
        public static bool IsEmpty<T>(this Stack<T> stack)
        {
            return stack.Count == 0;
        }
    }
}
