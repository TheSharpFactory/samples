/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Query
{
    public partial class PaginationSettings
    {
    }
}

************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Represents the Pagination Settings to apply to a query when calling the Repository.
    /// </summary>
    public partial class PaginationSettings : IPaginationSettings
    {
        private int _pageSize = 0;//_pageSize zero means pagination DISABLED. Cannot be se to less than zero as per logic in the property setter.
        private int _pageNumber = 1;//by the default the first page. Cannot be set to less than one as per logic in the property setter.
        private int _pageNumberForRep = 0;//this is because the Repository uses zero based page numbering. So it is one less as per logic in the setter of PageNumber.
        private bool _getTotalCount = false;//used to decide if to get the total count of a paged query. can have performance impact to do so.
        private double _totalCount = 0D;//used to store the total count of a paged query.
        /// <summary>
        /// Gets or sets the number of items to return.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                if(value > -1)
                {
                    _pageSize = value;
                }
                else
                {
                    _pageSize = 0;
                }
            }
        }
        /// <summary>
        /// Gets or sets the desired page number to return.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int PageNumber
        {
            get
            {
                return _pageNumber;
            }
            set
            {
                if(value > 0)
                {
                    _pageNumber = value;
                }
                else
                {
                    _pageNumber = 1;
                }
                _pageNumberForRep = _pageNumber - 1;
            }
        }
        /// <summary>
        /// Gets the value of the PageNumber used for the repository which is zero based.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int PageNumberForRep
        {
            get
            {
                return _pageNumberForRep;
            }
        }
        /// <summary>
        /// If true gets the total count for a paged query.
        /// This can have a performance impact. Set true with caution.
        /// </summary>
        /// <value>
        /// bool
        /// </value>
        public bool GetTotalCount
        {
            get
            {
                return _getTotalCount;
            }
            set
            {
                _getTotalCount = value;
            }
        }
        /// <summary>
        /// Gets or sets the total count of paged query. 
        /// This is the count that would be returned without pagination.
        /// </summary>
        /// <value>
        /// double
        /// </value>
        public double TotalCount
        {
            get
            {
                return _totalCount;
            }
            set
            {
                _totalCount = value;
            }
        }
        /// <summary>
        /// Gets or the total number of pages.
        /// Only works when GetTotalCount is set to true.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int PageCount
        {
            get
            {
                if(_pageSize < 1)
                    return 1;
                return (int)Math.Ceiling(_totalCount / (double)_pageSize);
            }
        }
        public PaginationSettings()
        {//this uses the default values. which means pagination DISABLED.
        
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationSettings"/> class.
        /// </summary>
        /// <param name="pagesize">The page size for the query.</param>
        /// <param name="pagenumber">The page number to get.</param>
        /// <param name="gettotalcount">If true get the total count of the query. Use with caution; performance hit is possible.</param>
        public PaginationSettings(int pagesize, int pagenumber, bool gettotalcount)
        {
            PageSize = pagesize;//use property setter. there is custom logic
            PageNumber = pagenumber;//use property setter. there is custom logic
            _getTotalCount = gettotalcount;
        }
    }
}
