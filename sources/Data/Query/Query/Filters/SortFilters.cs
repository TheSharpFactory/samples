/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class is a collection of Sort Filters.
    /// </summary>
    public sealed class SortFilters<TPropEnum>:List<SortFilter<TPropEnum>> where TPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        public SortFilters() : base()
        {
        }
        public SortFilters(int capacity) : base(capacity)
        {
        }
        public SortFilters(IEnumerable<SortFilter<TPropEnum>> collection) : base(collection)
        {
        }
        public void Add(TPropEnum prop)
        {
            Add(SortFilter.New(prop));
        }
        public void Add(TPropEnum prop, SortDirection sortdirection)
        {
            Add(SortFilter.New(prop, sortdirection));
        }
        public List<ISortFilter> IFilters
        {
            get { return this.ConvertAll(f => (ISortFilter)f); }
        }
    }
}
