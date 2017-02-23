namespace InterpreterPattern.Sample1
{
    class MinusExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;
        public MinusExpression(IExpression leftExpression,
        IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int Interpret()
        {
            return leftExpression.Interpret() - rightExpression.Interpret();
        }
    }
}
