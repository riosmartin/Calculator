using Core.Expression;

namespace Core.Parsing.Expression
{
    public interface IExpressionParser
    {
        public bool Parse(string expressionString, out IExpression parsedExpression);
    }
}
