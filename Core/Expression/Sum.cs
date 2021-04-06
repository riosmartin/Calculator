using System.Linq;

namespace Core.Expression
{
    public class Sum : IExpression
    {
        private readonly IExpression [] _operands;

        public Sum (params IExpression[] operands)
        {
            _operands = operands;
        }

        public decimal Evaluate()
        {
            return _operands.Sum(x => x.Evaluate());
        }

        public string Print()
        {
            return string.Join(" + ", _operands.Select(e => e.Print()));
        }
    }
}
