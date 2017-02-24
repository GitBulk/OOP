namespace InterpreterPattern.Sample1
{
    class PlusExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;
        public PlusExpression(IExpression leftExpression,
        IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int Interpret()
        {
            return leftExpression.Interpret() + rightExpression.Interpret();
        }
    }
}
