/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Represents the Pagination Settings to apply to a query when calling the Repository.
    /// </summary>
    public interface IPaginationSettings
    {
        /// <summary>
        /// If true gets the total count for a paged query.  This can have a performance impact. Set true with caution.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        bool GetTotalCount { get; set; }

        /// <summary>
        /// Gets or the total number of pages.  Only works when GetTotalCount is set to true.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        int PageCount { get;  }

        /// <summary>
        /// Gets or sets the desired page number to return.  Defaults to 1, meaning the first page.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        int PageNumber { get; set; }

        /// <summary>
        /// Gets the value of the PageNumber used for the repository which is zero based.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        int PageNumberForRep { get;  }

        /// <summary>
        /// Gets or sets the number of items to return.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the total count of paged query.  This is the count that would be returned without pagination.
        /// </summary>
        /// <value>
        /// double
        /// </value>
        double TotalCount { get; set; }

    }
}
