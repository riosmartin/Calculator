namespace Core.Expression
{
    public class Multiplication : IExpression
    {
        private readonly IExpression _multiplicant;
        private readonly IExpression _multiplier;

        public Multiplication(IExpression multiplicant, IExpression multiplier)
        {
            _multiplicant = multiplicant;
            _multiplier = multiplier;
        }

        public decimal Evaluate()
        {
            return _multiplicant.Evaluate() * _multiplier.Evaluate();
        }

        public string Print()
        {
            return $"{_multiplicant.Print()} * {_multiplier.Print()}";
        }
    }
}
