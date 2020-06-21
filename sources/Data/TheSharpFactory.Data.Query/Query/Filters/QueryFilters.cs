/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class is a collection of Query Filters.
    /// </summary>
    public sealed class QueryFilters<TPropEnum>:List<QueryFilter<TPropEnum>> where TPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        public QueryFilters() : base()
        {
        }
        public QueryFilters(int capacity) : base(capacity)
        {
        }
        public QueryFilters(IEnumerable<QueryFilter<TPropEnum>> collection) : base(collection)
        {
        }
        public void Add(TPropEnum prop, object val)
        {
            Add(QueryFilter.New(prop, FilterConditions.Equals, val));
        }
        public void Add(TPropEnum prop, FilterConditions condition, object val)
        {
            Add(QueryFilter.New(prop, condition, val));
        }
        public void Add(TPropEnum prop, FilterOperators op, object val)
        {
            Add(QueryFilter.New(prop, FilterConditions.Equals, op, val));
        }
        public void Add(TPropEnum prop, FilterConditions condition, FilterOperators op, object val)
        {
            Add(QueryFilter.New(prop, condition, op, val));
        }
        public List<IQueryFilter> IFilters
        {
            get { return this.ConvertAll(f => (IQueryFilter)f); }
        }
    }
}
