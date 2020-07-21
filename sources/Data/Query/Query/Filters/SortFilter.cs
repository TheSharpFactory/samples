/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Query
{
    public partial class SortFilter<TPropEnum>
    {
    }
}

************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class represents the sorting criteria applied when caling the Repository.
    /// </summary>
    public partial class SortFilter<TPropEnum>:ISortFilter where TPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        /// <summary>
        /// Gets or sets the property to sort by as an enum.
        /// </summary>
        /// <value>
        /// One of the PropertyEnums enum.
        /// </value>
        public TPropEnum Property { get; }
        /// <summary>
        /// Gets the id of the property to sort by.
        /// </summary>
        /// <value>
        /// int.
        /// </value>
        public int PropertyId { get; }
        /// <summary>
        /// Gets the name of the property as a string.
        /// </summary>
        /// <value>
        /// string
        /// </value>
        public string PropertyName { get; }
        /// <summary>
        /// Gets the sort direction to apply to the sort.
        /// </summary>
        /// <value>
        /// TheSharpFactory.Data.Query.SortDirection enum.
        /// </value>
        public SortDirection SortDirection { get; }

        private SortFilter()
        {
        
        }
        /// <summary>
        /// Initializes a new instance of the SortFilter"/> class.
        /// </summary>
        /// <param name="fieldname">The field name.</param>
        /// <param name="sortdirection">The sort direction.</param>
        internal SortFilter(TPropEnum prop, SortDirection sortdirection)
        {
            PropertyId = prop.ToInt32(null);
            Property = prop;
            PropertyName = Property.ToString();
            SortDirection = sortdirection;
        }
    }

    /// <summary>
    /// This class is a factory for creating SortFilter instances.
    /// </summary>
    public static class SortFilter
    {
        /// <summary>
        /// Returns a new SortFilter.
        /// </summary>
        /// <param name="fieldname">The field name.</param>
        /// <param name="sortdirection">The sort direction.</param>
        public static SortFilter<TPropEnum> New<TPropEnum>(TPropEnum prop, SortDirection sortdirection) where TPropEnum : struct, IComparable, IFormattable, IConvertible
        {
            return new SortFilter<TPropEnum>(prop, sortdirection);
        }
        /// <summary>
        /// Returns a new SortFilter. Using the SortDirection.Ascending
        /// </summary>
        /// <param name="fieldname">The field name.</param>
        /// <param name="sortdirection">The sort direction.</param>
        public static SortFilter<TPropEnum> New<TPropEnum>(TPropEnum prop) where TPropEnum : struct, IComparable, IFormattable, IConvertible
        {
            return new SortFilter<TPropEnum>(prop, SortDirection.Ascending);
        }
    }
}
