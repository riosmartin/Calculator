namespace Core.Expression
{
    public class Division : IExpression
    {
        private readonly IExpression _dividend;
        private readonly IExpression _divisor;

        public Division(IExpression dividend, IExpression divisor)
        {
            _dividend = dividend;
            _divisor = divisor;
        }

        public decimal Evaluate()
        {
            return _dividend.Evaluate() / _divisor.Evaluate();
        }

        public string Print()
        {
            return $"{_dividend.Print()} / {_divisor.Print()}";
        }
    }
}
