/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Builds the pagination settings for the query.
    /// </summary>
    public sealed class PaginationBuilder<TPropEnum, TQuery, TQueryBuilder> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TQuery : QueryBase<TPropEnum, TQuery, TQueryBuilder>, new() where TQueryBuilder : QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder>, new()
    {
        private readonly TQuery _query;
        internal PaginationSettings Pagination { get; private set; }

        public PaginationBuilder(TQuery query)
        {
            _query = query;
        }
        /// <summary>
        /// Set the page size for the query.
        /// </summary>
        /// <returns>
        /// PaginationBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public PaginationBuilder<TPropEnum, TQuery, TQueryBuilder> PageSize(int size) 
        {
            if(Pagination == null)
                Pagination = new PaginationSettings();
            Pagination.PageSize = size;
            return this;
        }
        /// <summary>
        /// Set the page number for the query.
        /// </summary>
        /// <returns>
        /// PaginationBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public PaginationBuilder<TPropEnum, TQuery, TQueryBuilder> PageNumber(int number) 
        {
            if(Pagination == null)
                Pagination = new PaginationSettings();
            Pagination.PageNumber = number;
            return this;
        }
        /// <summary>
        /// If true returns the total record count. Used for pagination.
        /// </summary>
        /// <returns>
        /// PaginationBuilder of TPropEnum, TQuery, TQueryBuilder
        /// </returns>
        public PaginationBuilder<TPropEnum, TQuery, TQueryBuilder> ReturnTotalCount(bool getCount) 
        {
            if(Pagination == null)
                Pagination = new PaginationSettings();
            Pagination.GetTotalCount = getCount;
            return this;
        }
        /// <summary>
        /// Ends the pagination configuration.
        /// </summary>
        /// <returns>
        /// TQuery
        /// </returns>
        public TQuery EndPagination() 
        {
            return _query;
        }
    }
}
