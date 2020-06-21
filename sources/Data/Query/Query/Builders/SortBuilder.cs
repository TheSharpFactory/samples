/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Builds the sorting criteria for the query.
    /// </summary>
    public sealed class SortBuilder<TPropEnum, TQuery, TQueryBuilder> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TQuery : QueryBase<TPropEnum, TQuery, TQueryBuilder>, new() where TQueryBuilder : QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder>, new()
    {
        private readonly TQuery _query;
        internal SortFilters<TPropEnum> Sorting { get; private set; }

        public SortBuilder(TQuery query)
        {
            _query = query;
        }
        /// <summary>
        /// Add order ascending by the specified property.
        /// </summary>
        /// <returns>
        /// SortBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public SortBuilder<TPropEnum, TQuery, TQueryBuilder> OrderBy(TPropEnum prop) 
        {
            if(Sorting == null)
                Sorting = new SortFilters<TPropEnum>();
            Sorting.Add(SortFilter.New(prop));
            return this;
        }
        /// <summary>
        /// Add order descending by the specified property.
        /// </summary>
        /// <returns>
        /// SortBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public SortBuilder<TPropEnum, TQuery, TQueryBuilder> OrderByDescending(TPropEnum prop) 
        {
            if(Sorting == null)
                Sorting = new SortFilters<TPropEnum>();
            Sorting.Add(SortFilter.New(prop, SortDirection.Descending));
            return this;
        }
        /// <summary>
        /// Ends setting the sorting for the query.
        /// </summary>
        /// <returns>
        /// TQuery
        /// </returns>
        public TQuery EndSorting() 
        {
            return _query;
        }
    }
}
