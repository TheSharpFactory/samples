/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Builds the predicate(where clause) of a query.
    /// </summary>
    public sealed class PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TQuery : QueryBase<TPropEnum, TQuery, TQueryBuilder>, new() where TQueryBuilder : QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder>, new()
    {
        private readonly TQuery _query;
        /// <summary>
        /// Gets or sets the current ExpressionBuilder being composed in the query.
        /// </summary>
        /// <value>
        /// ExpressionBuilder
        /// </value>
        internal ExpressionBuilder CurrentExpression { get; set; }

        /// <summary>
        /// Gets the filters of the query.
        /// </summary>
        /// <value>
        /// QueryFilters of TPropEnum
        /// </value>
        internal QueryFilters<TPropEnum> PredicateFilters { get; private set; }

        public PredicateBuilder(TQuery query)
        {
            _query = query;
        }
        #region Expression Builder
        /// <summary>
        /// Uses AND operator. Adds a group of conditions to be evaluated together as a single expression.
        /// </summary>
        /// <returns>
        /// PredicateBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> Where(Action<PredicateBuilder<TPropEnum, TQuery, TQueryBuilder>> builder) 
        {
            builder(BeginExpression());
            EndExpression();
            return this;
        }
        /// <summary>
        /// Uses OR operator. Adds a group of conditions to be evaluated together as a single expression.
        /// </summary>
        /// <returns>
        /// PredicateBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> Or(Action<PredicateBuilder<TPropEnum, TQuery, TQueryBuilder>> builder) 
        {
            builder(OrBeginExpression());
            EndExpression();
            return this;
        }
        /// <summary>
        /// Initiates a new expression(group of filters) using the AND operator.
        /// </summary>
        /// <returns>
        /// PredicateBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        private PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> BeginExpression() 
        {
            if(CurrentExpression == null)
                CurrentExpression = new ExpressionBuilder(FilterOperators.And);
            CurrentExpression.OpenExpressions++;
            return this;
        }
        /// <summary>
        /// Initiates a new expression(group of filters) using the OR operator.
        /// </summary>
        /// <returns>
        /// PredicateBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        private PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> OrBeginExpression() 
        {
            if(CurrentExpression == null)
                CurrentExpression = new ExpressionBuilder(FilterOperators.Or);
            CurrentExpression.OpenExpressions++;
            return this;
        }
        /// <summary>
        /// Ends an expression. This method must be called once per every Begin Expression call.
        /// </summary>
        /// <returns>
        /// PredicateBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        private PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> EndExpression() 
        {
            if(PredicateFilters?.Count > 0)
                PredicateFilters[PredicateFilters.Count - 1].EndExpressions++;
            return this;
        }
        #endregion
        #region Parameter Syntax
        /// <summary>
        /// Adds condition: where property meets specified condition against the value. Uses AND operator.
        /// </summary>
        /// <returns>
        /// PredicateBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        internal PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> And(TPropEnum prop, FilterConditions condition, object val) 
        {
            AddCondition(FilterOperators.And, prop, condition, val);
            return this;
        }
        /// <summary>
        /// Adds condition: where property meets specified condition against the value. Uses OR operator.
        /// </summary>
        /// <returns>
        /// PredicateBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        internal PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> Or(TPropEnum prop, FilterConditions condition, object val) 
        {
            AddCondition(FilterOperators.Or, prop, condition, val);
            return this;
        }
        #endregion
        #region Fluid Syntax
        /// <summary>
        /// Begins condition: Uses AND operator.
        /// </summary>
        /// <returns>
        /// FilterBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public FilterBuilder<TPropEnum, TQuery, TQueryBuilder> Where(TPropEnum prop) 
        {
            return new FilterBuilder<TPropEnum, TQuery, TQueryBuilder>(prop, FilterOperators.And, this);
        }
        /// <summary>
        /// Begins condition: Uses OR operator.
        /// </summary>
        /// <returns>
        /// FilterBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public FilterBuilder<TPropEnum, TQuery, TQueryBuilder> Or(TPropEnum prop) 
        {
            return new FilterBuilder<TPropEnum, TQuery, TQueryBuilder>(prop, FilterOperators.Or, this);
        }
        #endregion
        /// <summary>
        /// Ends predicate(where clause).
        /// </summary>
        /// <returns>
        /// TQuery
        /// </returns>
        public TQuery EndPredicate() 
        {
            return _query;
        }
        private void AddCondition(FilterOperators filterOperator, TPropEnum prop, FilterConditions condition, object val) 
        {
            if(PredicateFilters == null)
                PredicateFilters = new QueryFilters<TPropEnum>();
            if(CurrentExpression == null)
            {
                PredicateFilters.Add(QueryFilter.New(prop, condition, filterOperator, val));
                return;
            }
            var filter = QueryFilter.New(prop, condition, CurrentExpression.Operator, val);
            filter.StartExpressions = CurrentExpression.OpenExpressions;
            PredicateFilters.Add(filter);
            CurrentExpression = null;
        }
    }
}
