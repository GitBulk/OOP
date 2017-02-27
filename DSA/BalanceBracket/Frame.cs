using System;
using System.Collections.Generic;

namespace DSA.BalanceBracket
{
    class Frame
    {
        public static void Run()
        {
            string input = "(())";
            Console.WriteLine(input + ": " + Check(input));

            input = "(([}))";
            Console.WriteLine(input + ": " + Check(input));

            input = "{(([]))}";
            Console.WriteLine(input + ": " + Check(input));
            input = "((a+1)*2)";
            Console.WriteLine(input + ": " + Check(input));
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
}
