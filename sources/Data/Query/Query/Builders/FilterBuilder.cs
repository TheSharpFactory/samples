/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// Builds a filter for the predicate(where clause) of the query.
    /// </summary>
    public sealed class FilterBuilder<TPropEnum, TQuery, TQueryBuilder> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TQuery : QueryBase<TPropEnum, TQuery, TQueryBuilder>, new() where TQueryBuilder : QueryBuilderBase<TPropEnum, TQuery, TQueryBuilder>, new()
    {
        private readonly TPropEnum _property;
        private readonly PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> _predicateBuilder;
        private readonly FilterOperators _operator;
        public FilterBuilder(TPropEnum property, FilterOperators filterOperator, PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> predicateBuilder)
        {
            _property = property;
            _operator = filterOperator;
            _predicateBuilder = predicateBuilder;
        }
        #region Equality
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        new public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> Equals(object val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.Equals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotEquals(object val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.NotEquals, val);
        }
        #endregion
        #region Is Null
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is null.
        /// </summary>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> IsNull()
        {
            return ComposeFilterAndAddToQuery(FilterConditions.Equals, null);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not null.
        /// </summary>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> IsNotNull()
        {
            return ComposeFilterAndAddToQuery(FilterConditions.NotEquals, null);
        }
        #endregion
        #region Strings
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property starts with the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> StartsWith(string val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.StartsWith, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property ends with the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> EndsWith(string val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.EndsWith, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property does not start with the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> DoesNotStartWith(string val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DoesNotStartWith, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property does not end with the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> DoesNotEndWith(string val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DoesNotEndWith, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property contains the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> Like(string val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.Contains, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property does not contain the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotLike(string val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DoesNotContain, val);
        }
        #endregion
        #region In
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is IN the passed in value.
        /// This translates to an IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> In(int[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.Contains, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is IN the passed in value.
        /// This translates to an IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> In(long[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.Contains, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is IN the passed in value.
        /// This translates to an IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> In(string[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.Contains, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is IN the passed in value.
        /// This translates to an IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> In(short[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.Contains, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is IN the passed in value.
        /// This translates to an IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> In(byte[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.Contains, val);
        }
        #endregion
        #region Not In
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not IN the passed in value.
        /// This translates to a NOT IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotIn(int[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DoesNotContain, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not IN the passed in value.
        /// This translates to a NOT IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotIn(long[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DoesNotContain, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not IN the passed in value.
        /// This translates to a NOT IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotIn(string[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DoesNotContain, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not IN the passed in value.
        /// This translates to a NOT IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotIn(short[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DoesNotContain, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not IN the passed in value.
        /// This translates to a NOT IN() clause in SQL.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotIn(byte[] val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DoesNotContain, val);
        }
        #endregion
        #region Greater Than
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThan(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThan(long val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThan(short val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThan(byte val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThan(decimal val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThan(double val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThan, val);
        }
        #endregion
        #region Less Than
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThan(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThan(long val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThan(short val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThan(byte val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThan(decimal val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThan(double val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThan, val);
        }
        #endregion
        #region Greater Than Or Equals
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEquals(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEquals(long val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEquals(short val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEquals(byte val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEquals(decimal val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEquals(double val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThanOrEquals, val);
        }
        #endregion
        #region Less Than Or Equals
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEquals(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEquals(long val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEquals(short val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEquals(byte val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEquals(decimal val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEquals(double val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThanOrEquals, val);
        }
        #endregion
        #region Date Time
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is equals the passed in value.
        /// Takes into account the date plus hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> Equals(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.Equals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not equals the passed in value.
        /// Takes into account the date plus hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotEquals(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.NotEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// Takes into account the date plus hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThan(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// Takes into account the date plus hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThan(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// Takes into account the date plus hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEquals(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.GreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// Takes into account the date plus hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEquals(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.LessThanOrEquals, val);
        }
        #endregion
        #region Date Only
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is equals the passed in value.
        /// Takes into account only the date and not the hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> EqualsDate(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DateEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not equals the passed in value.
        /// Takes into account only the date and not the hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotEqualsDate(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DateNotEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// Takes into account only the date and not the hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanDate(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DateGreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// Takes into account only the date and not the hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanDate(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DateLessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// Takes into account only the date and not the hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEqualsDate(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DateGreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// Takes into account only the date and not the hours, minutes, seconds, milliseconds.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEqualsDate(DateTime val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DateLessThanOrEquals, val);
        }
        #endregion
        #region Year
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is equals the passed in value.
        /// Takes into account only the Year.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> EqualsYear(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.YearEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not equals the passed in value.
        /// Takes into account only the Year.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotEqualsYear(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.YearNotEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// Takes into account only the Year.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanYear(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.YearGreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// Takes into account only the Year.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanYear(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.YearLessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// Takes into account only the Year.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEqualsYear(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.YearGreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// Takes into account only the Year.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEqualsYear(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.YearLessThanOrEquals, val);
        }
        #endregion
        #region Month
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is equals the passed in value.
        /// Takes into account only the Month.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> EqualsMonth(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.MonthEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not equals the passed in value.
        /// Takes into account only the Month.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotEqualsMonth(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.MonthNotEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// Takes into account only the Month.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanMonth(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.MonthGreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// Takes into account only the Month.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanMonth(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.MonthLessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// Takes into account only the Month.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEqualsMonth(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.MonthGreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// Takes into account only the Month.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEqualsMonth(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.MonthLessThanOrEquals, val);
        }
        #endregion
        #region Day
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is equals the passed in value.
        /// Takes into account only the Day.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> EqualsDay(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DayEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is not equals the passed in value.
        /// Takes into account only the Day.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> NotEqualsDay(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DayNotEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than the passed in value.
        /// Takes into account only the Day.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanDay(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DayGreaterThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than the passed in value.
        /// Takes into account only the Day.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanDay(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DayLessThan, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is greater than or equals the passed in value.
        /// Takes into account only the Day.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> GreaterThanOrEqualsDay(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DayGreaterThanOrEquals, val);
        }
        /// <summary>
        /// Add a filter to the predicate(where clause).
        /// Where the Property is less than or equals the passed in value.
        /// Takes into account only the Day.
        /// </summary>
        /// <param name="val">The value to filter by</param>
        /// <returns>PredicateBuilder</returns>
        public PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> LessThanOrEqualsDay(int val)
        {
            return ComposeFilterAndAddToQuery(FilterConditions.DayLessThanOrEquals, val);
        }
        #endregion
        private PredicateBuilder<TPropEnum, TQuery, TQueryBuilder> ComposeFilterAndAddToQuery(FilterConditions condition, object val)
        {
            if(_operator == FilterOperators.And)
                _predicateBuilder.And(_property, condition, val);
            else
                _predicateBuilder.Or(_property, condition, val);
            return _predicateBuilder;
        }
    }
}
