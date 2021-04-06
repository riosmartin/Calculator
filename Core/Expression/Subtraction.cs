namespace Core.Expression
{
    public class Subtraction : IExpression
    {
        private readonly IExpression _minuend;
        private readonly IExpression _subtraend;

        public Subtraction(IExpression minuend, IExpression subtraend)
        {
            _minuend = minuend;
            _subtraend = subtraend;
        }

        public decimal Evaluate()
        {
            return _minuend.Evaluate() - _subtraend.Evaluate();
        }

        public string Print()
        {
            return $"{_minuend.Print()} - {_subtraend.Print()}";
        }
    }
}
