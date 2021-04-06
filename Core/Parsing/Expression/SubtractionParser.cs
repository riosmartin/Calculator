using Core.Expression;
using Core.StringManipulation.StringSplit;
using Core.StringManipulation;

namespace Core.Parsing.Expression
{
    public class SubtractionParser : IExpressionParser
    {

        private static readonly StringSplitOptions _stringSplitOptions = new StringSplitOptions
        {
            Count = 2,
            Reverse = true
        };

        public bool Parse(string expressionString, out IExpression parsedExpression)
        {
            string[] operandStrings = expressionString.SplitWord('-', _stringSplitOptions);

            if (operandStrings.Length <= 1)
            {
                parsedExpression = default;
                return false;
            }
            
            parsedExpression = new Subtraction(ParsingEngine.Parse(operandStrings[1]), ParsingEngine.Parse(operandStrings[0]));
            return true;
        }
    }
}
