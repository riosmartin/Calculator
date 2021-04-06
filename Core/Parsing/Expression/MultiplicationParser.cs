using Core.Expression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Parsing.Expression
{
    public class MultiplicationParser : IExpressionParser
    {
        public bool Parse(string expressionString, out IExpression parsedExpression)
        {
            string[] operandStrings = expressionString.Split('*', 2);

            if (operandStrings.Length <= 1)
            {
                parsedExpression = default;
                return false;
            }
            
            parsedExpression = new Multiplication(ParsingEngine.Parse(operandStrings[0]), ParsingEngine.Parse(operandStrings[1]));
            return true;
        }
    }
}
