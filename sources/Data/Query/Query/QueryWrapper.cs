/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class wraps the query to be usable by the Repository. Only used by the Repository.
    /// </summary>
    public abstract class QueryWrapperBase<TPropEnum, TQuery, TQueryBuilder> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TQuery : QueryBase<TPropEnum, TQuery, TQueryBuilder>, new() where TQueryBuilder : QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder>, new()
    {
        private QueryBase<TPropEnum, TQuery, TQueryBuilder> _query;
        public QueryFilters<TPropEnum> PredicateFilters { get{ return _query.PredicateBuilder?.PredicateFilters; }  }

        public QueryFilters<TPropEnum> SetValues { get{ return _query.UpdateValuesBuilder?.SetValues; }  }

        public PaginationSettings Pagination { get{ return _query.PaginationBuilder?.Pagination; }  }

        public SortFilters<TPropEnum> Sorting { get{ return _query.SortBuilder?.Sorting; }  }

        public int OpenExpressions { get; private set; }

        public int ClosedExpressions { get; private set; }

        public bool IsValid { get{ return OpenExpressions == ClosedExpressions; }  }

        public QueryWrapperBase(QueryBase<TPropEnum, TQuery, TQueryBuilder> query)
        {
            _query = query;
            CalculateOpenExpressions();
            CalculateClosedExpressions();
        }
        public void CalculateOpenExpressions() 
        {
            if((!(_query.PredicateBuilder?.PredicateFilters?.Count > 0)))
                return;
            var count = 0;
            foreach (var f in _query.PredicateBuilder.PredicateFilters)
                count += f.StartExpressions;
            OpenExpressions = count;
        }
        public void CalculateClosedExpressions() 
        {
            if((!(_query.PredicateBuilder?.PredicateFilters?.Count > 0)))
                return;
            var count = 0;
            foreach (var f in _query.PredicateBuilder.PredicateFilters)
                count += f.EndExpressions;
            ClosedExpressions = count;
        }
    }

    /// <summary>
    /// This class wraps the query to be usable by the Repository. Only used by the Repository.
    /// </summary>
    public sealed class QueryWrapper<TPropEnum> : QueryWrapperBase<TPropEnum, Query<TPropEnum>, QueryBuilder<TPropEnum>> where TPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        public QueryWrapper(Query<TPropEnum> query) : base(query)
        {
        }
    }

    /// <summary>
    /// This class wraps the query to be usable by the Repository. Only used by the Repository.
    /// </summary>
    public sealed class QueryWrapper<TPropEnum, TNavPropEnum> : QueryWrapperBase<TPropEnum, Query<TPropEnum, TNavPropEnum>, QueryBuilder<TPropEnum, TNavPropEnum>> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TNavPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        private Query<TPropEnum, TNavPropEnum> _query;
        public NavProps NavigationProperties { get{ return _query.NavPropsBuilder?.NavigationProperties; }  }

        public QueryWrapper(Query<TPropEnum, TNavPropEnum> query) : base(query)
        {
            _query = query;
        }
    }
}
