using Core.Expression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Parsing.Expression
{
    public class SumParser : IExpressionParser
    {
        public bool Parse(string expressionString, out IExpression parsedExpression)
        {
            string[] operandStrings = expressionString.Split('+');

            if (operandStrings.Length <= 1)
            {
                parsedExpression = default;
                return false;
            }

            IEnumerable<IExpression> operands = operandStrings.Select(e => ParsingEngine.Parse(e));
            parsedExpression = new Sum(operands.ToArray());
            return true;
        }
    }
}
