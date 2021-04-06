using Core.Expression;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Parsing.Expression
{
    public class NumberParser : IExpressionParser
    {
        public bool Parse(string expressionString, out IExpression parsedExpression)
        { 
            bool parseResult = decimal.TryParse(expressionString, out decimal parsedDecimal);

            parsedExpression = parseResult ? new Number(parsedDecimal) : default;

            return parseResult;
        }
    }
}
