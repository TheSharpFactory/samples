/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Builds a group of conditions(an expression) within the predicate(where clause) of a query.
    /// </summary>
    public sealed class ExpressionBuilder
    {
        internal int OpenExpressions { get; set; }

        internal FilterOperators Operator { get;  }

        public ExpressionBuilder(FilterOperators filterOperator)
        {
            Operator = filterOperator;
        }
    }
}
