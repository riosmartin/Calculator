using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Parsing.Expression
{
    public class UnrecognizedExpressionException : Exception
    {
        public string ExpressionString { get; private set; }
        public UnrecognizedExpressionException (string expressionString) : base ($"Invalid expression : '{expressionString}' could not be parsed.")
        {
            ExpressionString = expressionString;
        }
    }
}
