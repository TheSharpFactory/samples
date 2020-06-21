/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Query
{
    public partial interface ISortFilter
    {
    }
}

************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This interface represents a sorting filter used when calling the Repository.
    /// </summary>
    public partial interface ISortFilter
    {
        /// <summary>
        /// Gets the id of the property to sort by.
        /// </summary>
        /// <value>
        /// int.
        /// </value>
        int PropertyId { get; }

        /// <summary>
        /// Gets the name of the property to sort by.
        /// </summary>
        /// <value>
        /// string.
        /// </value>
        string PropertyName { get; }

        /// <summary>
        /// Gets the sort direction to apply to the sort.
        /// </summary>
        /// <value>
        /// TheSharpFactory.Data.Query.SortDirection enum.
        /// </value>
        SortDirection SortDirection { get; }

    }
}
