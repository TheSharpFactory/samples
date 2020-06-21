/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Builds a list of fields and corresponding values to update.  Used in UPDATE operations otherwise ignored.
    /// </summary>
    public sealed class UpdateValuesBuilder<TPropEnum, TQuery, TQueryBuilder> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TQuery : QueryBase<TPropEnum, TQuery, TQueryBuilder>, new() where TQueryBuilder : QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder>, new()
    {
        private readonly TQuery _query;
        internal QueryFilters<TPropEnum> SetValues { get; private set; }

        public UpdateValuesBuilder(TQuery query)
        {
            _query = query;
        }
        /// <summary>
        /// Adds a Set clause to the query.  Used only for UPDATE operations.
        /// </summary>
        /// <returns>
        /// UpdateValuesBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public UpdateValuesBuilder<TPropEnum, TQuery, TQueryBuilder> Set(TPropEnum prop, object val) 
        {
            if(SetValues == null)
                SetValues = new QueryFilters<TPropEnum>();
            SetValues.Add(QueryFilter.New(prop, FilterConditions.Equals, val));
            return this;
        }
        /// <summary>
        /// Ends setting update values.
        /// </summary>
        /// <returns>
        /// TQuery
        /// </returns>
        public TQuery EndUpdateValues() 
        {
            return _query;
        }
    }
}
