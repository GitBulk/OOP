using System;
using System.Collections.Generic;

namespace InterpreterPattern.Sample1
{
    class Frame
    {   
        public static void Run()
        {
            string tokenString = "4 3 2 - 1 + *";
            var stack = new Stack<IExpression>();
            var tokenList = tokenString.Split(' ');
            foreach (var item in tokenList)
            {
                if (IsOperator(item))
                {
                    IExpression rightExpression = stack.Pop();
                    IExpression leftExpression = stack.Pop();
                    IExpression @operator = GetOperatorInstance(item, leftExpression, rightExpression);
                    int result = @operator.Interpret();
                    stack.Push(new NumberExpression(result));
                }
                else
                {
                    IExpression numberExpression = new NumberExpression(item);
                    stack.Push(numberExpression);
                }
            }
            Console.WriteLine($"Result { stack.Pop().Interpret()}");
        }

        private static bool IsOperator(string item)
        {
            return (item == "+" || item == "-" || item == "*");
        }

        private static IExpression GetOperatorInstance(string input, IExpression left, IExpression right)
        {
            switch (input)
            {
                case "+":
                    return new PlusExpression(left, right);
                case "-":
                    return new MinusExpression(left, right);
                case "*":
                    return new MultiplyExpression(left, right);
            }
            return null;
        }
    }
}
