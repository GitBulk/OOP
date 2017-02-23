namespace InterpreterPattern.Sample1
{
    class MultiplyExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public MultiplyExpression(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return leftExpression.Interpret() * rightExpression.Interpret();
        }
    }
}
