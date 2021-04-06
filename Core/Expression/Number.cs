namespace Core.Expression
{
    public class Number : IExpression
    {
        private readonly decimal _value;

        public Number (decimal value)
        {
            _value = value;
        }

        public decimal Evaluate()
        {
            return _value;
        }

        public string Print()
        {
            return _value.ToString();
        }
    }
}
