/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Build your query using builder syntax.
    /// </summary>
    public abstract class QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TQuery : QueryBase<TPropEnum, TQuery, TQueryBuilder>, new() where TQueryBuilder : QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder>, new()
    {
        internal TQuery Query { get; set; }

        /// <summary>
        /// Compose the predicate(where clause).
        /// </summary>
        /// <returns>
        /// TQueryBuilder
        /// </returns>
        public TQueryBuilder Predicate(Action<PredicateBuilder<TPropEnum, TQuery, TQueryBuilder>> builder) 
        {
            builder(Query.BeginPredicate());
            return (TQueryBuilder)this;
        }
        /// <summary>
        /// Compose the sorting criteria.
        /// </summary>
        /// <returns>
        /// TQueryBuilder
        /// </returns>
        public TQueryBuilder Sorting(Action<SortBuilder<TPropEnum, TQuery, TQueryBuilder>> builder) 
        {
            builder(Query.BeginSorting());
            return (TQueryBuilder)this;
        }
        /// <summary>
        /// Configure the pagination settings.
        /// </summary>
        /// <returns>
        /// TQueryBuilder
        /// </returns>
        public TQueryBuilder Pagination(Action<PaginationBuilder<TPropEnum, TQuery, TQueryBuilder>> builder) 
        {
            builder(Query.BeginPagination());
            return (TQueryBuilder)this;
        }
        /// <summary>
        /// Set the fields and values to update.
        /// </summary>
        /// <returns>
        /// TQueryBuilder
        /// </returns>
        public TQueryBuilder UpdateValues(Action<UpdateValuesBuilder<TPropEnum, TQuery, TQueryBuilder>> builder) 
        {
            builder(Query.BeginUpdateValues());
            return (TQueryBuilder)this;
        }
    }

    /// <summary>
    /// This class represents a query builder.  Used to correctly craft a query.
    /// </summary>
    public sealed class QueryBuilder<TPropEnum> : QueryBuilderBase<TPropEnum, Query<TPropEnum>, QueryBuilder<TPropEnum>> where TPropEnum : struct, IComparable, IFormattable, IConvertible
    {
    }

    /// <summary>
    /// This class represents a query builder.  Used to correctly craft a query.
    /// </summary>
    public sealed class QueryBuilder<TPropEnum, TNavPropEnum> : QueryBuilderBase<TPropEnum, Query<TPropEnum, TNavPropEnum>, QueryBuilder<TPropEnum, TNavPropEnum>> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TNavPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        /// <summary>
        /// Compose the navigation properties.
        /// </summary>
        /// <returns>
        /// QueryBuilder of TPropEnum, TNavPropEnum
        /// </returns>
        public QueryBuilder<TPropEnum, TNavPropEnum> NavProps(Action<NavPropsBuilder<TPropEnum, Query<TPropEnum, TNavPropEnum>, QueryBuilder<TPropEnum, TNavPropEnum>, TNavPropEnum>> builder) 
        {
            builder(Query.BeginNavProps());
            return this;
        }
    }
}
