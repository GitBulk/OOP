using System;

namespace InterpreterPattern.Sample1
{
    class NumberExpression : IExpression
    {
        private readonly int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public NumberExpression(string number)
        {
            this.number = Convert.ToInt32(number);
        }

        public int Interpret()
        {
            return this.number;
        }
    }
}
