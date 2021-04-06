using Core.Expression;
using Core.Parsing.Expression;


namespace Core.Parsing
{
    public static class ParsingEngine
    {

        private static readonly IExpressionParser[] _parsers = new IExpressionParser[]
        {
            new NumberParser(),
            new SumParser(),
            new SubtractionParser(),
            new MultiplicationParser(),
            new DivisionParser(),            
        };

        public static IExpression Parse(string expressionString)
        {
            IExpression parsedExpression = null;

            foreach (IExpressionParser parser in _parsers)
            {
                if (parsedExpression == null)
                    parser.Parse(expressionString, out parsedExpression);
            }

            if (parsedExpression == null)
                throw new UnrecognizedExpressionException(expressionString);

            return parsedExpression;
        }

    }
}
