using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Expression
{
    public interface IExpression
    {
        public decimal Evaluate();
        public string Print();
    }
}
