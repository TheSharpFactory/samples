/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class represents all aspects of a query sent to the Repository.
    /// </summary>
    public abstract class QueryBase<TPropEnum, TQuery, TQueryBuilder> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TQuery : QueryBase<TPropEnum, TQuery, TQueryBuilder>, new() where TQueryBuilder : QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder>, new()
    {
        internal PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> PredicateBuilder { get; private set; }

        internal UpdateValuesBuilder<TPropEnum, TQuery, TQueryBuilder> UpdateValuesBuilder { get; private set; }

        internal PaginationBuilder<TPropEnum, TQuery, TQueryBuilder> PaginationBuilder { get; private set; }

        internal SortBuilder<TPropEnum, TQuery, TQueryBuilder> SortBuilder { get; private set; }

        internal TQueryBuilder QueryBuilder { get; private set; }

        /// <summary>
        /// Only works when ReturnTotalCount is true. Gets the total number of records found for this query. This is the count that would be returned without pagination.
        /// </summary>
        /// <value>
        /// double
        /// </value>
        public double RecordCount { get{ return PaginationBuilder?.Pagination != null ? PaginationBuilder.Pagination.TotalCount : 0D; }  }

        /// <summary>
        /// Only works when ReturnTotalCount is true. Gets the total number of pages found for this query.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int PageCount { get{ return PaginationBuilder?.Pagination != null ? PaginationBuilder.Pagination.PageCount : 0; }  }

        /// <summary>
        /// Begin composing the predicate(where clause).
        /// </summary>
        /// <returns>
        /// PredicateBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> BeginPredicate() 
        {
            if(PredicateBuilder == null)
                PredicateBuilder = new PredicateBuilder<TPropEnum, TQuery, TQueryBuilder>((TQuery)this);
            return PredicateBuilder;
        }
        /// <summary>
        /// Begin setting the fields and values to update.
        /// </summary>
        /// <returns>
        /// UpdateValuesBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public UpdateValuesBuilder<TPropEnum, TQuery, TQueryBuilder> BeginUpdateValues() 
        {
            if(UpdateValuesBuilder == null)
                UpdateValuesBuilder = new UpdateValuesBuilder<TPropEnum, TQuery, TQueryBuilder>((TQuery)this);
            return UpdateValuesBuilder;
        }
        /// <summary>
        /// Begin configuring pagination settings.
        /// </summary>
        /// <returns>
        /// PaginationBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public PaginationBuilder<TPropEnum, TQuery, TQueryBuilder> BeginPagination() 
        {
            if(PaginationBuilder == null)
                PaginationBuilder = new PaginationBuilder<TPropEnum, TQuery, TQueryBuilder>((TQuery)this);
            return PaginationBuilder;
        }
        /// <summary>
        /// Begin adding the fields to sort the query by.
        /// </summary>
        /// <returns>
        /// SortBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public SortBuilder<TPropEnum, TQuery, TQueryBuilder> BeginSorting() 
        {
            if(SortBuilder == null)
                SortBuilder = new SortBuilder<TPropEnum, TQuery, TQueryBuilder>((TQuery)this);
            return SortBuilder;
        }
        /// <summary>
        /// Use the query builder to craft your query.
        /// </summary>
        /// <returns>
        /// TQuery
        /// </returns>
        public TQuery Builder(Action<TQueryBuilder> builder) 
        {
            if(QueryBuilder == null)
            {
                QueryBuilder = new TQueryBuilder();
                QueryBuilder.Query = (TQuery)this;
            }
            builder(QueryBuilder);
            return (TQuery)this;
        }
    }

    /// <summary>
    /// This class represents all aspects of a query sent to the Repository.
    /// </summary>
    public sealed class Query<TPropEnum> : QueryBase<TPropEnum, Query<TPropEnum>, QueryBuilder<TPropEnum>> where TPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        private QueryWrapper<TPropEnum> _wrapper;
        public Query()
        {
            _wrapper = new QueryWrapper<TPropEnum>(this);
        }
        /// <summary>
        /// This method is for internal use only and is not intended to be used directly in your code.
        /// </summary>
        /// <returns>
        /// QueryWrapper of TPropEnum
        /// </returns>
        public QueryWrapper<TPropEnum> Prepare() 
        {
            return _wrapper;
        }
    }

    /// <summary>
    /// This class represents all aspects of a query sent to the Repository.
    /// </summary>
    public sealed class Query<TPropEnum, TNavPropEnum> : QueryBase<TPropEnum, Query<TPropEnum, TNavPropEnum>, QueryBuilder<TPropEnum, TNavPropEnum>> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TNavPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        private QueryWrapper<TPropEnum, TNavPropEnum> _wrapper;
        internal NavPropsBuilder<TPropEnum, Query<TPropEnum, TNavPropEnum>, QueryBuilder<TPropEnum, TNavPropEnum>, TNavPropEnum> NavPropsBuilder { get; private set; }

        public Query()
        {
            _wrapper = new QueryWrapper<TPropEnum, TNavPropEnum>(this);
        }
        /// <summary>
        /// Begin composing the navigation property tree.
        /// </summary>
        /// <returns>
        /// NavPropsBuilder of TPropEnum, Query of TPropEnum, TNavPropEnum, QueryBuilder of TPropEnum, TNavPropEnum, TNavPropEnum
        /// </returns>
        public NavPropsBuilder<TPropEnum, Query<TPropEnum, TNavPropEnum>, QueryBuilder<TPropEnum, TNavPropEnum>, TNavPropEnum> BeginNavProps() 
        {
            if(NavPropsBuilder == null)
                NavPropsBuilder = new NavPropsBuilder<TPropEnum, Query<TPropEnum, TNavPropEnum>, QueryBuilder<TPropEnum, TNavPropEnum>, TNavPropEnum>(this);
            return NavPropsBuilder;
        }
        /// <summary>
        /// This method is for internal use only and is not intended to be used directly in your code.
        /// </summary>
        /// <returns>
        /// QueryWrapper of TPropEnum, TNavPropEnum
        /// </returns>
        public QueryWrapper<TPropEnum, TNavPropEnum> Prepare() 
        {
            return _wrapper;
        }
    }
}
