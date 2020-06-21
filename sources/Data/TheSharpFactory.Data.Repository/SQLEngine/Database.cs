/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

#region Usings
using TheSharpFactory.Data.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;
using System.Xml.Linq;
#endregion

namespace TheSharpFactory.Data.Repository.Common
{
  public static class Database
  {
    private class StoredProcParams
    {
      public Dictionary<int, SqlParameter> OutParams { get; set; }
      public SqlParameter[] Parameters { get; set; }
    }
    private enum FinishBehavior : int
    {
      Cancel,
      CloseReader,
      DisposeCommand,
    }
    private static readonly Dictionary<int, string> _conStrings = new Dictionary<int, string>();
    public static bool LogEnabled { get; set; } = false;
    public static Action<string, string> Logger { get; set; } = null;

    internal static readonly int ReturnParamId = -1000000;
    internal static readonly string TotalRowCountParam = "TRC_Internal";
    private static readonly string _select = "SELECT ";
    private static readonly string _distinct = "DISTINCT ";
    private static readonly string _insert = "INSERT INTO ";
    private static readonly string _update = "UPDATE ";
    private static readonly string _delete = "DELETE ";
    private static readonly string _from = " FROM ";
    private static readonly string _set = " SET ";
    private static readonly string _top = " TOP";
    private static readonly string _asc = " ASC";
    private static readonly string _desc = " DESC";
    private static readonly string _offset = " OFFSET ";//info on paging https://www.mssqltips.com/sqlservertip/2362/overview-of-offset-and-fetch-feature-of-sql-server-2012/
    private static readonly string _fetch = " FETCH NEXT ";//info on paging https://technet.microsoft.com/en-us/library/gg699618(v=sql.110).aspx
    private static readonly string _fetchCountParam = "@fetchCount";
    private static readonly string _offsetCountParam = "@offsetCount";
    private static readonly string _countOver = "COUNT(*) OVER()";
    private static readonly string _rowsOnly = " ROWS ONLY";
    private static readonly string _rows = " ROWS";
    private static readonly string _where = " WHERE ";
    private static readonly string _whereExists = " WHERE EXISTS ";
    private static readonly string _like = " LIKE ";
    private static readonly string _len = "LEN";
    private static readonly string _left = "LEFT";
    private static readonly string _right = "RIGHT";
    private static readonly string _equals = " = ";
    private static readonly string _notEquals = " <> ";
    private static readonly string _greater = " > ";
    private static readonly string _less = " < ";
    private static readonly string _greaterEquals = " >= ";
    private static readonly string _lessEquals = " <= ";
    private static readonly string _and = " AND ";
    private static readonly string _or = " OR ";
    private static readonly string _in = " IN ";
    private static readonly string _notIn = " NOT IN ";
    private static readonly string _as = " AS ";
    private static readonly string _null = "NULL";
    private static readonly string _isNull = " IS NULL";
    private static readonly string _isNotNull = " IS NOT NULL";
    //private static readonly string _year = "YEAR";
    //private static readonly string _month = "MONTH";
    //private static readonly string _day = "DAY";
    //private static readonly string _datePart = "DATEPART";
    private static readonly string _orderBy = " ORDER BY ";
    //private static readonly string _join = " JOIN ";
    private static readonly string _on = " ON ";
    //private static readonly string _rowlock = " (ROWLOCK) ";//all supported HINTS: https://msdn.microsoft.com/en-us/library/ms187373.aspx
    //private static readonly string _updlock = " (UPDLOCK) ";
    //private static readonly string _nolock = " (NOLOCK) ";
    private static readonly string _output = " OUTPUT ";
    //private static readonly string _scopeIdentity = "SCOPE_IDENTITY()";
    private static readonly string _innerJoin = " INNER JOIN ";
    private static readonly string _getDateSql = "SELECT SYSDATETIME() AS Expr1";
    private static readonly string _getUtcDateSql = "SELECT SYSUTCDATETIME() AS Expr1";
    private static readonly string _getTimeZoneOffsetSql = "SELECT DATEPART(tz, SYSDATETIMEOFFSET()) AS Expr1";

    private static readonly string _nextValueFor = "NEXT VALUE FOR ";
    private static readonly object _syncRoot = new object();
    public static void RegisterModelConnectionString(int modelId, string connectionString)
    {
      if(_conStrings.ContainsKey(modelId))
        throw new ArgumentException($"A connection string for model with id {modelId} already exists");

      _conStrings.Add(modelId, connectionString);
    }
    public static void OverrideModelConnectionString(int modelId, string connectionString)
    {
      lock(_syncRoot)
      {
        if(_conStrings.ContainsKey(modelId))
        {
          _conStrings[modelId] = connectionString;
        }
        else
        {
          _conStrings.Add(modelId, connectionString);
        }
      }
    }
    internal static void Select(int modelId, int entityId, int topCount, List<IQueryFilter> queryFilters, List<ISortFilter> sortFilters, IPaginationSettings paginationSettings, List<NavPropertyInfo> navProps, Action<SqlDataReader> materializer)
    {
      Query.Select.Execute(modelId, entityId, topCount, queryFilters, sortFilters, paginationSettings, navProps, materializer);
    }
    internal static void Insert(int modelId, int entityId, List<IQueryFilter> valuesToSet, Action<SqlDataReader> materializer)
    {
      Query.Insert.Execute(modelId, entityId, valuesToSet, materializer);
    }
    internal static void Insert(int modelId, int entityId, List<IQueryFilter> valuesToSet, List<IQueryFilter> keys, Action<SqlDataReader> materializer)
    {
      Query.Insert.Execute(modelId, entityId, valuesToSet, keys, materializer);
    }
    internal static void Update(int modelId, int entityId, List<IQueryFilter> valuesToSet, List<IQueryFilter> where, Action<SqlDataReader> materializer)
    {
      Query.Update.Execute(modelId, entityId, valuesToSet, where, materializer);
    }
    internal static int Delete(int modelId, int entityId, List<IQueryFilter> keys)
    {
      return Query.Delete.Execute(modelId, entityId, keys);
    }
    internal static Dictionary<int, object> StoredProc(int modelId, int entityId, List<IQueryFilter> param, Action<SqlDataReader> materializer)
    {
      return Query.StoredProc.Execute(modelId, entityId, param, materializer);
    }

    internal static void Function(int modelId, int entityId, bool isScalar, SqlParameter[] param, Action<SqlDataReader> materializer)
    {
      Query.Function.Execute(modelId, entityId, isScalar, param, materializer);
    }
    internal static TSequenceResult Sequence<TSequenceResult>(int modelId, int entityId)
    {
      return Query.Sequence.Execute<TSequenceResult>(modelId, entityId);
    }
    internal static DateTime GetStoreDateTime(int modelId)
    {
      return Query.SqlExecute.Scalar<DateTime>(modelId, "StoreQuery", _getDateSql, null, FinishBehavior.DisposeCommand);
    }
    internal static DateTime GetStoreUtcDateTime(int modelId)
    {
      return Query.SqlExecute.Scalar<DateTime>(modelId, "StoreQuery", _getUtcDateSql, null, FinishBehavior.DisposeCommand);
    }
    internal static int GetServerTimeZoneOffsetInMinutes(int modelId)
    {
      return Query.SqlExecute.Scalar<int>(modelId, "StoreQuery", _getTimeZoneOffsetSql, null, FinishBehavior.DisposeCommand);
    }
    internal static bool GetDataBaseHeartBeat(int modelId)
    {
      var heartBeatConnString = _conStrings[modelId].Replace(";multipleactiveresultsets=True", "") + ";Connect Timeout=1";
      var sqlCon = (SqlConnection)null;

      try
      {
        sqlCon = new SqlConnection(heartBeatConnString);
        sqlCon.Open();
        return true;
      }
      catch
      {
        return false;
      }
      finally
      {
        if(sqlCon != null)
        {
          if(sqlCon.State != ConnectionState.Closed)
            sqlCon.Close();

          sqlCon.Dispose();
          sqlCon = null;
        }
      }
    }

    private static class Query
    {
      internal static class Insert
      {
        internal static void Execute(int modelId, int entityId, List<IQueryFilter> valuesToSet, Action<SqlDataReader> materializer)
        {
          var entityInfo = RepoLookup.Entities[entityId];
          var query = Compose(entityInfo, valuesToSet);
          var valToSetParam = Parameters.ComposeForInsert(entityInfo, valuesToSet);
          var paramNames = new HashSet<string>();
          var paramList = new List<SqlParameter>(valToSetParam.Length);

          for(int i = 0; i < valToSetParam.Length; i++)
          {
            if(paramNames.Contains(valToSetParam[i].ParameterName))
              continue;

            paramNames.Add(valToSetParam[i].ParameterName);
            paramList.Add(valToSetParam[i]);
          }

          SqlExecute.Reader(modelId, entityInfo.DbFQName, query, paramList.ToArray(), materializer, FinishBehavior.Cancel);
        }
        internal static void Execute(int modelId, int entityId, List<IQueryFilter> valuesToSet, List<IQueryFilter> keys, Action<SqlDataReader> materializer)
        {
          var entityInfo = RepoLookup.Entities[entityId];
          var query = Compose(entityInfo, valuesToSet, keys);
          var valToSetParam = Parameters.ComposeForInsert(entityInfo, valuesToSet);
          var keysToSelectParam = Parameters.Compose(entityInfo, keys, null, "_I");

          var paramList = new List<SqlParameter>(valToSetParam.Length);

          for(int i = 0; i < valToSetParam.Length; i++)
          {
            paramList.Add(valToSetParam[i]);
          }

          for(int i = 0; i < keysToSelectParam.Length; i++)
          {
            paramList.Add(keysToSelectParam[i]);
          }

          SqlExecute.Reader(modelId, entityInfo.DbFQName, query, paramList.ToArray(), materializer, FinishBehavior.Cancel);

        }
        private static string Compose(EntityInfo entityInfo, List<IQueryFilter> valuesToSet)
        {//query filters serve the purpose of defining which fields will be assigned a value.          
          var hasInsertProjection = !string.IsNullOrWhiteSpace(entityInfo.InsertProjection);
          if(hasInsertProjection)
          {
            var values = GenerateValuesForInsert(valuesToSet, entityInfo);
            var hasValues = !string.IsNullOrWhiteSpace(values);

            return _insert + entityInfo.DbFQName + "(" + entityInfo.InsertProjection + ")" + _output + entityInfo.InsertedProjection + (hasValues ? " VALUES(" + values + ") " : string.Empty);
          }
          else
          {
            return _insert + entityInfo.DbFQName + _output + entityInfo.InsertedProjection;
          }

        }
        private static string Compose(EntityInfo entityInfo, List<IQueryFilter> valuesToSet, List<IQueryFilter> keys)
        {
          var hasInsertProjection = !string.IsNullOrWhiteSpace(entityInfo.InsertProjection);
          var result = _insert + entityInfo.DbFQName;

          if(hasInsertProjection)
          {
            var values = GenerateValuesForInsert(valuesToSet, entityInfo);
            var hasValues = !string.IsNullOrWhiteSpace(values);

            result += "(" + entityInfo.InsertProjection + ")" + (hasValues ? " VALUES(" + values + ") " : string.Empty);
          }

          result += ("; " + Select.Compose(0, entityInfo, keys, null, null, null, "_I"));
          return result;

        }
        private static string GenerateValuesForInsert(List<IQueryFilter> valuesToSet, EntityInfo entityInfo)
        {
          if(!(valuesToSet?.Count > 0))
            return string.Empty;

          var count = valuesToSet.Count;
          var values = entityInfo.Props[valuesToSet[0].PropertyId].ParamName;//do the first one to avoid removing the trailin comma
          if(count > 1)
            for(int i = 1; i < count; i++)
              values += "," + entityInfo.Props[valuesToSet[i].PropertyId].ParamName;

          return values;
        }
      }
      internal static class Select
      {
        internal static void Execute(int modelId, int entityId, int topCount, List<IQueryFilter> queryFilters, List<ISortFilter> sortFilters, IPaginationSettings paginationSettings, List<NavPropertyInfo> navProps, Action<SqlDataReader> materializer)
        {
          var entityInfo = RepoLookup.Entities[entityId];

          var query = Compose(topCount, entityInfo, queryFilters, sortFilters, paginationSettings, navProps);

          var param = Parameters.Compose(entityInfo, queryFilters, paginationSettings);

          SqlExecute.Reader(modelId, entityInfo.DbFQName, query, param, materializer, FinishBehavior.Cancel);
        }
        internal static string Compose(int topCount, EntityInfo entityInfo, List<IQueryFilter> queryFilters, List<ISortFilter> sortFilters, IPaginationSettings paginationSettings, List<NavPropertyInfo> navProps, string paramSuffix = "")
        {
          var top = string.Empty;

          if(topCount > 0)
            top = $"{_top}({topCount}) ";

          var projection = entityInfo.Projection;

          var from = $"{_from}{entityInfo.AsAlias}";

          var where = GenerateWhereClause(queryFilters, entityInfo, false, paramSuffix);

          var orderBy = GenerateOrderByClause(sortFilters, entityInfo);

          var getTotalCount = GeneraGetTotalCount(orderBy, paginationSettings);

          var pagination = GeneratePaginationClause(orderBy, paginationSettings);

          var select = _select + top + projection + getTotalCount + from;

          var selectForNavProp = _select + top + projection + from;

          var predicateSuffix = orderBy + pagination;

          var predicateSuffixForParentNavProperty = !string.IsNullOrWhiteSpace(pagination) ? predicateSuffix : string.Empty;

          var query = select;
          if(where.Length > 0)
            query += _where + where + predicateSuffix;
          else
            query += predicateSuffix;

          var topOrPagingEnabled = !string.IsNullOrWhiteSpace(top) || !string.IsNullOrWhiteSpace(pagination);

          query += ComposeNavProps(entityInfo, paginationSettings, navProps, selectForNavProp, where, predicateSuffix, predicateSuffixForParentNavProperty, topOrPagingEnabled);

          return query;
        }

        private static string ComposeNavProps(EntityInfo entityInfo, IPaginationSettings paginationSettings, List<NavPropertyInfo> navProps, string selectForNavProp, string where, string predicateSuffix, string predicateSuffixForParentNavProperty, bool topOrPagingEnabled)
        {
          if(!(navProps?.Count > 0))
            return "";

          var query = "";

          foreach(var navProp in navProps)
          {
            var navPropSelect = "";
            if(navProp.IsParent)
            {
              navPropSelect += ComposeSelectForParentNavProp(entityInfo, navProp, paginationSettings, selectForNavProp, where, predicateSuffixForParentNavProperty);
              //TODO: Test with circular reference FK's.
            }
            else
            {
              navPropSelect += ComposeSelectForChildNavProp(entityInfo, navProp, selectForNavProp, where, predicateSuffix, topOrPagingEnabled);
              //TODO: Test with circular reference FK's.
            }
            query += $";{Environment.NewLine}" + navPropSelect;
            var subEntity = RepoLookup.Entities[navProp.EntityId];
            query += ComposeNavProps(subEntity, paginationSettings, navProp.NavProps, navPropSelect, where, predicateSuffix, predicateSuffixForParentNavProperty, topOrPagingEnabled);
          }

          return query;
        }
        private static string ComposeSelectForParentNavProp(EntityInfo entityInfo, NavPropertyInfo navProp, IPaginationSettings pagination, string select, string where, string predicateSuffix)
        {
          if(pagination == null)
          {
            var otherEntityInfo = RepoLookup.Entities[navProp.EntityId];
            var predicateCount = navProp.Predicate.Count;

            var navPropPredicate = $"{entityInfo.Props[navProp.Predicate[0].PropId].Alias}{_equals}{otherEntityInfo.Props[navProp.Predicate[0].OtherPropId].Alias}";
            if(predicateCount > 1)
              for(int i = 1; i < predicateCount; i++)
                navPropPredicate += $"{_and}{entityInfo.Props[navProp.Predicate[i].PropId].Alias}{_equals}{otherEntityInfo.Props[navProp.Predicate[i].OtherPropId].Alias}";

            var whereFromMainSelect = !string.IsNullOrWhiteSpace(where) ? $"{_and}({where})" : string.Empty;
            return $"{_select}{otherEntityInfo.Projection}{_from}{otherEntityInfo.AsAlias}{_whereExists}({select}{_where}({navPropPredicate}){whereFromMainSelect}{predicateSuffix})";
          }
          else
          {
            var otherEntityInfo = RepoLookup.Entities[navProp.EntityId];
            var predicateCount = navProp.Predicate.Count;

            var navPropPredicate = $"{entityInfo.Props[navProp.Predicate[0].PropId].Alias}{_equals}{otherEntityInfo.Props[navProp.Predicate[0].OtherPropId].Alias}";
            if(predicateCount > 1)
              for(int i = 1; i < predicateCount; i++)
                navPropPredicate += $"{_and}{entityInfo.Props[navProp.Predicate[i].PropId].Alias}{_equals}{otherEntityInfo.Props[navProp.Predicate[i].OtherPropId].Alias}";

            var whereFromMainSelect = !string.IsNullOrWhiteSpace(where) ? $"({where})" : string.Empty;
            //this is a way to get nav props correct when using pagination
            //    INNER JOIN(
            //    SELECT DISTINCT [x].*
            //    FROM(
            //      //the main select goes here
            //    ) AS[x]
            //) AS[D3] ON nav prop predicate goes here
            return $"{_select}{otherEntityInfo.Projection}{_from}{otherEntityInfo.AsAlias}{_innerJoin}({_select}{_distinct}[x].*{_from}({select}{_where}{whereFromMainSelect}{predicateSuffix}) AS [x]) AS {entityInfo.Alias} ON {navPropPredicate}";
          }

        }
        private static string ComposeSelectForChildNavProp(EntityInfo entityInfo, NavPropertyInfo navProp, string select, string where, string predicateSuffix, bool topOrPagingEnabled)
        {
          var otherEntityInfo = RepoLookup.Entities[navProp.EntityId];
          var predicateCount = navProp.Predicate.Count;

          var predicate = $"{entityInfo.Props[navProp.Predicate[0].PropId].Alias}{_equals}{otherEntityInfo.Props[navProp.Predicate[0].OtherPropId].Alias}";
          if(predicateCount > 1)
            for(int i = 1; i < predicateCount; i++)
              predicate += $"{_and}{entityInfo.Props[navProp.Predicate[i].PropId].Alias}{_equals}{otherEntityInfo.Props[navProp.Predicate[i].OtherPropId].Alias}";

          var subQuery = ComposeSelectSubquery(select, where, predicateSuffix, topOrPagingEnabled);

          return $"{_select}{otherEntityInfo.Projection}{_from}{otherEntityInfo.AsAlias}{_innerJoin}({subQuery}){_as}{entityInfo.Alias}{_on}{predicate}";
        }
        private static string ComposeSelectSubquery(string select, string where, string predicateSuffix, bool topOrPagingEnabled)
        {
          if(where.Length > 0)
            return select + _where + where + (topOrPagingEnabled ? predicateSuffix : string.Empty);
          else
            return select + (topOrPagingEnabled ? predicateSuffix : string.Empty);
        }
        private static string GenerateOrderByClause(List<ISortFilter> sortFilters, EntityInfo entityInfo)
        {
          if(!(sortFilters?.Count > 0))
            return string.Empty;

          var orderBy = $"{_orderBy}{entityInfo.Props[sortFilters[0].PropertyId].Alias}{GenerateSortDirection(sortFilters[0].SortDirection)}";
          var count = sortFilters.Count;
          if(count == 1)
            return orderBy;//return early. there is only one filter

          for(int i = 1; i < count; i++)
          {
            var filter = sortFilters[i];
            var prop = entityInfo.Props[filter.PropertyId];
            orderBy += $", {prop.Alias}{GenerateSortDirection(filter.SortDirection)}";
          }

          return orderBy;
        }
        private static object GeneraGetTotalCount(string orderBy, IPaginationSettings paginationSettings)
        {
          if(paginationSettings == null)//return string empty when there is no paging criteria
            return string.Empty;

          //TODO: Get the TOTAL ROWS when using paging using something other than count over. 
          //This link contains good way of doing it.Look for James Moberg's answer:http://stackoverflow.com/questions/12352471/getting-total-row-count-from-offset-fetch-next            

          if(!string.IsNullOrWhiteSpace(orderBy))
            return $",{TotalRowCountParam} = {_countOver}";

          //at this point orderby is not present and paging criteria is not null
          throw new InvalidOperationException("Pagination is not allowed when no sorting criteria is present.");
        }
        private static string GeneratePaginationClause(string orderBy, IPaginationSettings paginationSettings)
        {
          if(paginationSettings == null)//return string empty when there is no paging criteria
            return string.Empty;

          if(!string.IsNullOrWhiteSpace(orderBy))//TODO: Get the TOTAL ROWS when using paging. This link contains good way of doing it.Look for James Moberg's answer:http://stackoverflow.com/questions/12352471/getting-total-row-count-from-offset-fetch-next            
            return $"{_offset}{_offsetCountParam}{_rows}{_fetch}{_fetchCountParam}{_rowsOnly}";

          //at this point orderby is not present and paging criteria is not null
          throw new InvalidOperationException("Pagination is not allowed when no sorting criteria is present.");
        }
        internal static string GenerateWhereClause(List<IQueryFilter> queryFilters, EntityInfo entityInfo, bool useColumnName = false, string paramSuffix = "")
        {
          if(!(queryFilters?.Count > 0))
            return string.Empty;
          var firstFilter = queryFilters[0];
          var where = $"{GenerateCondition(firstFilter, entityInfo.Props[firstFilter.PropertyId], 0, useColumnName, paramSuffix)}";
          var count = queryFilters.Count;

          if(count == 1)
            return where;

          for(int i = 1; i < count; i++)
          {
            var filter = queryFilters[i];
            where += $"{GenerateOperator(filter.Operator)}{GenerateCondition(filter, entityInfo.Props[filter.PropertyId], i, useColumnName, paramSuffix)}";
          }

          return where;
        }
        private static string GenerateSortDirection(SortDirection dir)
        {
          switch(dir)
          {
            case SortDirection.Ascending:
              return _asc;
            case SortDirection.Descending:
              return _desc;
            default:
              throw new NotSupportedException($"SortDirection {dir} is not supported.");
          }
        }
        private static string GenerateOperator(FilterOperators op)
        {
          switch(op)
          {
            case FilterOperators.And:
              return _and;
            case FilterOperators.Or:
              return _or;
            default:
              throw new NotSupportedException($"Operator {op} is not supported");
          }
        }
        private static string GenerateCondition(IQueryFilter filter, PropertyInfo prop, int paramOrdinal, bool useColumnName, string paramSuffix)
        {//Comparisson operators: https://msdn.microsoft.com/en-us/library/ms188074.aspx    
          var colAlias = useColumnName ? prop.Column : prop.Alias;

          if(filter.HasValue)
          {
            if(!filter.IsArray || prop.SqlType == SqlDbType.Timestamp)
            {
              return $"{GenerateExpressionOpeners(filter)}{GenerateConditionNormal(colAlias, filter, paramOrdinal, prop, paramSuffix)}{GenerateExpressionClosers(filter)}";
            }
            else
            {
              return $"{GenerateExpressionOpeners(filter)}{GenerateConditionWhenIsArray(colAlias, filter)}{GenerateExpressionClosers(filter)}";
            }
          }
          else
          {
            return $"{GenerateExpressionOpeners(filter)}{GenerateConditionWhenNull(colAlias, filter)}{GenerateExpressionClosers(filter)}";
          }
        }
        private static string GenerateConditionNormal(string colAlias, IQueryFilter filter, int paramOrdinal, PropertyInfo prop, string paramSuffix = "")
        {
          var param = Parameters.GenerateParamName(prop, paramOrdinal, paramSuffix);

          var nPrefix = "";
          if(prop.SqlType == SqlDbType.NVarChar || prop.SqlType == SqlDbType.NText || prop.SqlType == SqlDbType.NChar)
            nPrefix = "N";

          switch(filter.Condition)
          {
            case FilterConditions.Equals:
              return $"({colAlias}{_equals}{param})";

            case FilterConditions.NotEquals:
              return $"({colAlias}{_notEquals}{param})";

            case FilterConditions.Contains://TODO: create logic to do IN clause when passing an array. Probably cannot be pameterized has to be baked into the sql string                                                                           
              return $"({colAlias}{_like}{nPrefix}'%'+{param}+{nPrefix}'%')";//TODO: Escape characters in LIKE clause??. http://stackoverflow.com/questions/20496098/sql-generated-by-entityframework-startswith-contains-plan-altering-escape

            case FilterConditions.DoesNotContain:
              return $"(NOT({colAlias}{_like}{nPrefix}'%'+{param}+{nPrefix}'%'))";

            case FilterConditions.StartsWith:
              return $"(({colAlias}{_like}{param}+{nPrefix}'%'{_and}({_left}({colAlias}, {_len}({param})){_equals}{param})){_or}({param}{_equals}{nPrefix}''))";

            case FilterConditions.DoesNotStartWith:
              return $"(NOT(({colAlias}{_like}{param}+{nPrefix}'%'{_and}({_left}({colAlias}, {_len}({param})){_equals}{param})){_or}({param}{_equals}{nPrefix}'')))";

            case FilterConditions.EndsWith:
              return $"(({colAlias}{_like}{nPrefix}'%'+{param}{_and}({_right}({colAlias}, {_len}({param})){_equals}{param})){_or}({param}{_equals}{nPrefix}''))";

            case FilterConditions.DoesNotEndWith:
              return $"(NOT(({colAlias}{_like}{nPrefix}'%'+{param}{_and}({_right}({colAlias}, {_len}({param})){_equals}{param})){_or}({param}{_equals}{nPrefix}''))) ";

            case FilterConditions.GreaterThan:
              return $"({colAlias}{_greater}{param})";

            case FilterConditions.LessThan:
              return $"({colAlias}{_less}{param})";

            case FilterConditions.GreaterThanOrEquals:
              return $"({colAlias}{_greaterEquals}{param})";

            case FilterConditions.LessThanOrEquals:
              return $"({colAlias}{_lessEquals}{param})";

            case FilterConditions.DateEquals://this is the comparisson for DATE part only. it is a  little convoluted but it respects indexes. EF DOES NOT SUPPORT THIS! NOT EVEN COMPARING DATE part!:http://stackoverflow.com/questions/1843395/compare-two-datetime-only-by-date-not-time-in-sql-server-2008
              return $"(({colAlias}{_greaterEquals}CAST({param} AS DATE)){_and}({colAlias}{_less}DATEADD(dd, 1, CAST({param} AS DATE))))";

            case FilterConditions.DateNotEquals:
              return $"(NOT(({colAlias}{_greaterEquals}CAST({param} AS DATE)){_and}({colAlias}{_less}DATEADD(dd, 1, CAST({param} AS DATE)))))";

            case FilterConditions.DateGreaterThan:
              return $"(({colAlias}{_greaterEquals}CAST({param} AS DATE)){_and}({colAlias}{_greater}DATEADD(dd, 1, CAST({param} AS DATE))))";

            case FilterConditions.DateLessThan:
              return $"({colAlias}{_less}CAST({param} AS DATE))";

            case FilterConditions.DateGreaterThanOrEquals:
              return $"({colAlias}{_greaterEquals}CAST({param} AS DATE))";

            case FilterConditions.DateLessThanOrEquals:
              return $"({colAlias}{_less}DATEADD(dd, 1, CAST({param} AS DATE)))";

            case FilterConditions.DateContains://TODO: Implement DateContains and DateDoesNotContain or remove them from the filters.                  
            case FilterConditions.DateDoesNotContain:
              throw new NotSupportedException("This is pending implementation");

            case FilterConditions.YearEquals:
              return $"(YEAR({colAlias}){_equals}{param})";//Performace issue with this. SqlServer 2016 still has not fixed the indexes for this. WORKAROUND: http://www.littlekendra.com/2016/03/01/sql-servers-year-function-and-index-performance/

            case FilterConditions.YearNotEquals:
              return $"(YEAR({colAlias}){_notEquals}{param})";

            case FilterConditions.YearGreaterThan:
              return $"(YEAR({colAlias}){_greater}{param})";

            case FilterConditions.YearLessThan:
              return $"(YEAR({colAlias}){_less}{param})";

            case FilterConditions.YearGreaterThanOrEquals:
              return $"(YEAR({colAlias}){_greaterEquals}{param})";

            case FilterConditions.YearLessThanOrEquals:
              return $"(YEAR({colAlias}){_lessEquals}{param})";

            case FilterConditions.YearContains://TODO: Year contains. This probably cannot be parameterized         
            case FilterConditions.YearDoesNotContain://TODO: Year does not contain. This probably cannot be parameterized
              throw new NotSupportedException("This is pending implementation");
            case FilterConditions.MonthEquals:
              return $"(MONTH({colAlias}){_equals}{param})";

            case FilterConditions.MonthNotEquals:
              return $"(MONTH({colAlias}){_notEquals}{param})";

            case FilterConditions.MonthGreaterThan:
              return $"(MONTH({colAlias}){_greater}{param})";

            case FilterConditions.MonthLessThan:
              return $"(MONTH({colAlias}){_less}{param})";

            case FilterConditions.MonthGreaterThanOrEquals:
              return $"(MONTH({colAlias}){_greaterEquals}{param})";

            case FilterConditions.MonthLessThanOrEquals:
              return $"(MONTH({colAlias}){_lessEquals}{param})";

            case FilterConditions.MonthContains://TODO: Month contains. This probably cannot be parameterized         
            case FilterConditions.MonthDoesNotContain://TODO: MONTH does not contain. This probably cannot be parameterized
              throw new NotSupportedException("This is pending implementation");
            case FilterConditions.DayEquals:
              return $"(DAY({colAlias}){_equals}{param})";

            case FilterConditions.DayNotEquals:
              return $"(DAY({colAlias}){_notEquals}{param})";

            case FilterConditions.DayGreaterThan:
              return $"(DAY({colAlias}){_greater}{param})";

            case FilterConditions.DayLessThan:
              return $"(DAY({colAlias}){_less}{param})";

            case FilterConditions.DayGreaterThanOrEquals:
              return $"(DAY({colAlias}){_greaterEquals}{param})";

            case FilterConditions.DayLessThanOrEquals:
              return $"(DAY({colAlias}){_lessEquals}{param})";

            case FilterConditions.DayContains://TODO: Day contains. This probably cannot be parameterized         
            case FilterConditions.DayDoesNotContain://TODO: Day does not contain. This probably cannot be parameterized       
            default:
              throw new NotSupportedException($"FilterCondition {filter.Condition} is not supported.");
          }
        }
        private static string GenerateConditionWhenNull(string colAlias, IQueryFilter filter)
        {
          switch(filter.Condition)
          {
            case FilterConditions.Equals:
              return $"({colAlias}{_isNull})";

            case FilterConditions.NotEquals:
              return $"({colAlias}{_isNotNull})";

            default:
              throw new NotSupportedException($"When the value is null the only supported conditions are Equals and NotEquals.");
          }
        }
        private static string GenerateConditionWhenIsArray(string colAlias, IQueryFilter filter)
        {
          var typeCode = Type.GetTypeCode(filter.Type);

          switch(filter.Condition)
          {
            case FilterConditions.Contains:
              return $"({colAlias}{_in}({Utils.FastStringJoin(typeCode, filter.Value)}))";

            case FilterConditions.DoesNotContain:
              return $"({colAlias}{_notIn}({Utils.FastStringJoin(typeCode, filter.Value)}))";

            default:
              throw new NotSupportedException($"When the value is an array the only supported conditions are Contains and DoesNotContain.");
          }
        }
        private static string GenerateExpressionOpeners(IQueryFilter filter)
        {
          if(filter.StartExpressions < 1)
            return string.Empty;

          return new string('(', filter.StartExpressions);
        }
        private static string GenerateExpressionClosers(IQueryFilter filter)
        {
          if(filter.EndExpressions < 1)
            return string.Empty;

          return new string(')', filter.EndExpressions);
        }

      }
      internal static class Update
      {
        internal static void Execute(int modelId, int entityId, List<IQueryFilter> valuesToSet, List<IQueryFilter> where, Action<SqlDataReader> materializer)
        {
          var entityInfo = RepoLookup.Entities[entityId];
          var valToSetSuffix = "_v";
          var query = Compose(entityInfo, valuesToSet, where, valToSetSuffix);

          var paramsToSet = Parameters.Compose(entityInfo, valuesToSet, null, valToSetSuffix);
          var paramsForWhere = Parameters.Compose(entityInfo, where, null);
          var finalParams = new List<SqlParameter>(paramsForWhere.Length + paramsToSet.Length);

          for(int i = 0; i < paramsToSet.Length; i++)
            finalParams.Add(paramsToSet[i]);
          for(int i = 0; i < paramsForWhere.Length; i++)
            finalParams.Add(paramsForWhere[i]);

          SqlExecute.Reader(modelId, entityInfo.DbFQName, query, finalParams.ToArray(), materializer, FinishBehavior.Cancel);

        }
        private static string Compose(EntityInfo entityInfo, List<IQueryFilter> valuesToSet, List<IQueryFilter> where, string valToSetSuffix)
        { //valuesToSet serve the purpose of defining which fields will be assigned a value. 
          //this updates any rows found according to the keys. 

          if(!(valuesToSet?.Count > 0))
            throw new InvalidOperationException("No values to set have been found. Update requires at least one value to set.");

          if(!(where?.Count > 0))
            throw new InvalidOperationException("Update operation require at least one where clause.");

          var result = _update + entityInfo.DbFQName + _set + GenerateSetClauses(valuesToSet, entityInfo, valToSetSuffix) + _where + Select.GenerateWhereClause(where, entityInfo, true);

          result += ("; " + Select.Compose(0, entityInfo, where, null, null, null, null));
          return result;
        }
        private static string GenerateSetClauses(List<IQueryFilter> valuesToSet, EntityInfo entityInfo, string paramSuffix = "")
        {
          if(!(valuesToSet?.Count > 0))
            return string.Empty;

          var set = GenerateSetClause(valuesToSet, entityInfo, 0, paramSuffix);
          var count = valuesToSet.Count;

          if(count > 1)
            for(int i = 1; i < count; i++)
              set += "," + GenerateSetClause(valuesToSet, entityInfo, i, paramSuffix);

          return set;
        }
        private static string GenerateSetClause(List<IQueryFilter> valuesToSet, EntityInfo entityInfo, int paramOrdinal, string paramSuffix = "")
        {
          var valueToSet = valuesToSet[paramOrdinal];
          var p = entityInfo.Props[valueToSet.PropertyId];

          if(valueToSet.HasValue)
            return $"{p.Column}{_equals}{Parameters.GenerateParamName(p, paramOrdinal, paramSuffix)}";
          else
            return $"{p.Column}{_equals}{_null}";
        }
      }
      internal static class Delete
      {
        internal static int Execute(int modelId, int entityId, List<IQueryFilter> where)
        {
          var entityInfo = RepoLookup.Entities[entityId];

          var query = Compose(entityInfo, where);

          var paramsForWhere = Parameters.Compose(entityInfo, where, null);

          return SqlExecute.NonQuery(modelId, entityInfo.DbFQName, query, paramsForWhere, FinishBehavior.DisposeCommand);
        }
        private static string Compose(EntityInfo entityInfo, List<IQueryFilter> where)
        {//delete always returns the number of aftected rows.    
          if(!(where?.Count > 0))
            throw new InvalidOperationException("Delete operation requires at least one where clause.");

          return _delete + entityInfo.DbFQName + _where + Select.GenerateWhereClause(where, entityInfo, true);
        }
      }
      internal static class StoredProc
      {
        internal static Dictionary<int, object> Execute(int modelId, int procId, List<IQueryFilter> param, Action<SqlDataReader> materializer)
        {
          var entityInfo = RepoLookup.StoredProcs[procId];
          var paramResult = Parameters.ComposeForStoredProc(entityInfo, param);
          if(materializer == null)
            SqlExecute.NonQuery(modelId, entityInfo.DbFQName, entityInfo.DbFQName, paramResult.Parameters, FinishBehavior.CloseReader, CommandType.StoredProcedure);
          else
            SqlExecute.Reader(modelId, entityInfo.DbFQName, entityInfo.DbFQName, paramResult.Parameters, materializer, FinishBehavior.CloseReader, CommandType.StoredProcedure);

          //populate out param result
          var result = new Dictionary<int, object>(paramResult.OutParams.Count);
          if(param?.Count > 0 && paramResult.OutParams.Count > 0)
          {
            foreach(var p in param)
            {
              if(paramResult.OutParams.ContainsKey(p.PropertyId))
                result.Add(p.PropertyId, paramResult.OutParams[p.PropertyId].Value);
            }
          }
          result.Add(ReturnParamId, paramResult.Parameters[paramResult.Parameters.Length - 1].Value);
          return result;
        }
        internal static int Execute(int modelId, int procId, SqlParameter[] param, Action<SqlDataReader> materializer)
        {
          var entityInfo = RepoLookup.StoredProcs[procId];
          if(materializer == null)
            SqlExecute.NonQuery(modelId, entityInfo.DbFQName, entityInfo.DbFQName, param, FinishBehavior.CloseReader, CommandType.StoredProcedure);
          else
            SqlExecute.Reader(modelId, entityInfo.DbFQName, entityInfo.DbFQName, param, materializer, FinishBehavior.CloseReader, CommandType.StoredProcedure);

          if(param?.Length > 0)
            return (int)param[param.Length - 1].Value;//return the last parameter which is the return value.

          return 0;
        }
      }
      internal static class Sequence
      {
        internal static TScalarResult Execute<TScalarResult>(int modelId, int seqId)
        {
          var entityInfo = RepoLookup.Sequences[seqId];

          var result = SqlExecute.Scalar<TScalarResult>(modelId, entityInfo.DbFQName, $"{_select}{_nextValueFor}{entityInfo.DbFQName}", null, FinishBehavior.DisposeCommand, CommandType.Text);

          return result;
        }
      }
      internal static class Function
      {
        internal static void Execute(int modelId, int funcId, bool isScalar, SqlParameter[] param, Action<SqlDataReader> materializer)
        {
          var entityInfo = RepoLookup.Functions[funcId];
          var query = _select;

          if(isScalar)
            query += $"{entityInfo.DbFQName}({GenerateParams(param)}) AS ResultValue";
          else
            query += $"*{_from}{entityInfo.DbFQName}({GenerateParams(param)})";

          SqlExecute.Reader(modelId, entityInfo.DbFQName, query, param, materializer, FinishBehavior.Cancel);
        }
        private static string GenerateParams(SqlParameter[] param)
        {
          if(!(param?.Length > 0))
            return string.Empty;

          var count = param.Length;
          var values = param[0].ParameterName;//do the first one to avoid removing the trailing comma
          if(count > 1)
            for(int i = 1; i < count; i++)
              values += "," + param[i].ParameterName;

          return values;
        }

      }

      private static class Parameters
      {
        internal static SqlParameter[] Compose(EntityInfo entityInfo, List<IQueryFilter> queryFilters, IPaginationSettings paginationSettings, string paramSuffix = "")
        {
          var filterParamCount = 0;
          var pagingParamCount = 0;

          if(queryFilters?.Count > 0)
            filterParamCount = queryFilters.Count;

          if(paginationSettings != null)
            pagingParamCount = 2;

          var totalParamCount = filterParamCount + pagingParamCount;
          if(totalParamCount < 1)
            return null;

          var result = new List<SqlParameter>(totalParamCount);//use a list because not all parameters are required to be params. for example Contains on number columns create CSV baked instead.
          var noSuffix = paramSuffix.Length < 1;

          for(int i = 0; i < filterParamCount; i++)
          {
            var filter = queryFilters[i];
            if(!filter.HasValue)
              continue;

            var prop = entityInfo.Props[filter.PropertyId];

            if(filter.IsArray)
            {
              var sqlType = prop.SqlType;
              if(sqlType != SqlDbType.Binary && sqlType != SqlDbType.VarBinary && sqlType != SqlDbType.Image && sqlType != SqlDbType.Timestamp)
                continue;
            }

            var size = GetParamSize(prop, filter);

            var paramName = prop.ParamName;
            if(noSuffix)
              paramName += i.ToString();
            else
              paramName += paramSuffix + i.ToString();

            var param = size.HasValue ? new SqlParameter(paramName, GetSqlDbTypeForParam(filter.Condition, prop), size.Value) : new SqlParameter(paramName, GetSqlDbTypeForParam(filter.Condition, prop));

            if(prop.SqlType == SqlDbType.Udt)
              param.UdtTypeName = prop.UdtTypeName;

            param.IsNullable = filter.IsNullable;

            //at this point this filter has a value
            if(prop.SqlType == SqlDbType.Xml)
            {
              using(var xReader = ((XDocument)filter.Value).Root.CreateReader())
              {
                param.Value = new SqlXml(xReader);
                xReader.Close();
              }
            }
            else
            {
              param.Value = filter.Value;
            }

            result.Add(param);
          }

          if(pagingParamCount > 0)
          {
            var offsetParam = new SqlParameter(_offsetCountParam, SqlDbType.Int, 4);
            var fetchParam = new SqlParameter(_fetchCountParam, SqlDbType.Int, 4);
            offsetParam.IsNullable = false;
            fetchParam.IsNullable = false;
            offsetParam.Value = paginationSettings.PageNumberForRep * paginationSettings.PageSize;
            fetchParam.Value = paginationSettings.PageSize;
            result.Add(offsetParam);
            result.Add(fetchParam);
          }
          return result.ToArray();
        }

        internal static SqlParameter[] ComposeForInsert(EntityInfo entityInfo, List<IQueryFilter> queryFilters)
        {
          var filterParamCount = 0;

          if(queryFilters?.Count > 0)
            filterParamCount = queryFilters.Count;

          if(filterParamCount < 1)
            return null;

          var result = new List<SqlParameter>(filterParamCount);

          for(int i = 0; i < filterParamCount; i++)
          {
            var filter = queryFilters[i];
            if(!filter.HasValue && !filter.IsNullable)
              throw new ArgumentNullException($"Property {filter.PropertyName} is not nullable.");

            var prop = entityInfo.Props[filter.PropertyId];

            if(filter.IsArray)
            {
              var sqlType = prop.SqlType;
              if(sqlType != SqlDbType.Binary && sqlType != SqlDbType.VarBinary && sqlType != SqlDbType.Image && sqlType != SqlDbType.Timestamp)
                continue;
            }

            var size = GetParamSize(prop, filter);

            var param = size.HasValue ? new SqlParameter(prop.ParamName, prop.SqlType, size.Value) : new SqlParameter(prop.ParamName, prop.SqlType);

            if(prop.SqlType == SqlDbType.Udt)
              param.UdtTypeName = prop.UdtTypeName;

            param.IsNullable = filter.IsNullable;

            if(filter.Value == null)
            {
              param.Value = DBNull.Value;
            }
            else
            {
              if(prop.SqlType == SqlDbType.Xml)
              {
                using(var xReader = ((XDocument)filter.Value).Root.CreateReader())
                {
                  param.Value = new SqlXml(xReader);
                  xReader.Close();
                }
              }
              else
              {
                param.Value = filter.Value;
              }
            }



            result.Add(param);
          }
          return result.ToArray();
        }

        internal static StoredProcParams ComposeForStoredProc(EntityInfo entityInfo, List<IQueryFilter> queryFilters)
        {
          var filterParamCount = 0;

          if(queryFilters?.Count > 0)
            filterParamCount = queryFilters.Count;

          var resultParams = new StoredProcParams { OutParams = new Dictionary<int, SqlParameter>(filterParamCount) };
          var result = new List<SqlParameter>(filterParamCount);

          if(filterParamCount > 0)
          {
            for(int i = 0; i < filterParamCount; i++)
            {
              var filter = queryFilters[i];
              if(!filter.HasValue && !filter.IsNullable)
                throw new ArgumentNullException($"Property {filter.PropertyName} is not nullable.");

              var prop = entityInfo.Props[filter.PropertyId];

              if(filter.IsArray)
              {
                var sqlType = prop.SqlType;
                if(sqlType != SqlDbType.Binary && sqlType != SqlDbType.VarBinary && sqlType != SqlDbType.Image && sqlType != SqlDbType.Timestamp)
                  continue;
              }

              var size = GetParamSize(prop, filter);

              var param = size.HasValue ? new SqlParameter(prop.ParamName, prop.SqlType, size.Value) : new SqlParameter(prop.ParamName, prop.SqlType);

              if(prop.SqlType == SqlDbType.Udt)
                param.UdtTypeName = prop.UdtTypeName;

              param.Direction = prop.Direction;
              param.IsNullable = filter.IsNullable;

              if(filter.Value == null)
              {
                param.Value = DBNull.Value;
              }
              else
              {
                if(prop.SqlType == SqlDbType.Xml)
                {
                  using(var xReader = ((XDocument)filter.Value).Root.CreateReader())
                  {
                    param.Value = new SqlXml(xReader);
                    xReader.Close();
                  }
                }
                else
                {
                  param.Value = filter.Value;
                }
              }

              result.Add(param);

              if(param.Direction == ParameterDirection.InputOutput || param.Direction == ParameterDirection.Output)
                resultParams.OutParams.Add(filter.PropertyId, param);
            }
          }
          //add the return param                  
          result.Add(new SqlParameter("Return_Value", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue });
          resultParams.Parameters = result.ToArray();

          return resultParams;
        }

        private static int? GetParamSize(PropertyInfo prop, IQueryFilter filter)
        {//info about the Size property of the Parameter object : https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlparameter.size(v=vs.110).aspx
          var size = -1;//TODO: Test sending empty strings to the db and also null. Also test sending different length strings for fixed size chars, nchar and binary
          switch(prop.SqlType)
          {
            case SqlDbType.VarChar:
            case SqlDbType.NVarChar:
              if(prop.Size.HasValue)
              {
                if(prop.Size.Value > -1)
                  return prop.Size;
              }
              size = prop.SqlType == SqlDbType.VarChar ? 8000 : 4000;

              if(filter.Value != null && filter.Value.ToString().Length > size)
                return -1;
              return size;
            case SqlDbType.NText:
            case SqlDbType.Text:
              if(filter.Value != null)
                return filter.Value.ToString().Length;
              return size;
            case SqlDbType.Binary:
            case SqlDbType.VarBinary:
              if(prop.Size.HasValue)
              {
                if(prop.Size.Value > -1)
                  return prop.Size;
              }
              size = 8000;

              if(filter.Value is byte[] val2 && val2.Length > size)
                return -1;
              return size;
            default:
              return null;
          }
        }
        private static SqlDbType GetSqlDbTypeForParam(FilterConditions condition, PropertyInfo prop)
        {//in some cases the SqlDbType is different than the columns
          switch(condition)
          {
            case FilterConditions.Equals:
            case FilterConditions.NotEquals:
            case FilterConditions.Contains:
            case FilterConditions.DoesNotContain:
            case FilterConditions.StartsWith:
            case FilterConditions.DoesNotStartWith:
            case FilterConditions.EndsWith:
            case FilterConditions.DoesNotEndWith:
            case FilterConditions.GreaterThan:
            case FilterConditions.LessThan:
            case FilterConditions.GreaterThanOrEquals:
            case FilterConditions.LessThanOrEquals:
            case FilterConditions.DateEquals:
            case FilterConditions.DateNotEquals:
            case FilterConditions.DateGreaterThan:
            case FilterConditions.DateLessThan:
            case FilterConditions.DateGreaterThanOrEquals:
            case FilterConditions.DateLessThanOrEquals:
            case FilterConditions.DateContains:
            case FilterConditions.DateDoesNotContain:
              return prop.SqlType;

            case FilterConditions.YearEquals:
            case FilterConditions.YearNotEquals:
            case FilterConditions.YearGreaterThan:
            case FilterConditions.YearLessThan:
            case FilterConditions.YearGreaterThanOrEquals:
            case FilterConditions.YearLessThanOrEquals:
            case FilterConditions.MonthEquals:
            case FilterConditions.MonthNotEquals:
            case FilterConditions.MonthGreaterThan:
            case FilterConditions.MonthLessThan:
            case FilterConditions.MonthGreaterThanOrEquals:
            case FilterConditions.MonthLessThanOrEquals:
            case FilterConditions.DayEquals:
            case FilterConditions.DayNotEquals:
            case FilterConditions.DayGreaterThan:
            case FilterConditions.DayLessThan:
            case FilterConditions.DayGreaterThanOrEquals:
            case FilterConditions.DayLessThanOrEquals:
              return SqlDbType.Int;


            case FilterConditions.YearContains:
            case FilterConditions.YearDoesNotContain:
            case FilterConditions.MonthContains:
            case FilterConditions.MonthDoesNotContain:
            case FilterConditions.DayContains:
            case FilterConditions.DayDoesNotContain:
            default:
              throw new NotSupportedException("Condition is not implemented.");
          }

        }
        internal static string GenerateParamName(PropertyInfo prop, int paramOrdinal, string paramSuffix = "")
        {
          return prop.ParamName + paramSuffix + paramOrdinal.ToString();
        }
      }
      private static class Utils
      {
        internal static string FastStringJoin(TypeCode typeCode, object val)
        {
          switch(typeCode)
          {
            case TypeCode.Int32:
              return FastStringJoin(val as int[], 10);
            case TypeCode.Int64:
              if(val is long[])
                return FastStringJoin(val as long[], 12);
              else
                return FastStringJoin(val as int[], 10);
            case TypeCode.Int16:
              return FastStringJoin(val as short[], 6);
            case TypeCode.Byte:
              return FastStringJoin(val as byte[], 4);
            case TypeCode.String:
              return FastStringJoin(val as string[], 25);

            case TypeCode.Single:
            case TypeCode.Double:
            case TypeCode.Decimal:
            case TypeCode.DateTime:
            default:
              throw new NotSupportedException($"Type {typeCode} is not supported as an array.");
          }
        }
        internal static string FastStringJoin<T>(T[] array, int multiplier)
        {
          if(array.Length < 1)
            throw new ArgumentException("Empty arrays are not valid. Please pass a valid array.");

          var b = new StringBuilder(array.Length * multiplier);
          var count = array.Length - 1;
          var i = 0;
          for(; i < count; i++)
            b.Append(array[i].ToString()).Append(",");
          b.Append(array[i].ToString());
          return b.ToString();
        }
        internal static string FastStringJoin(string[] array, int multiplier)
        {
          if(array.Length < 1)
            throw new ArgumentException("Empty arrays are not valid. Please pass a valid array.");

          var b = new StringBuilder(array.Length * multiplier);
          var count = array.Length - 1;
          var i = 0;
          for(; i < count; i++)
            b.Append('\'').Append(array[i].Replace("'", "''")).Append('\'').Append(",");

          b.Append('\'').Append(array[i].Replace("'", "''")).Append('\'');
          return b.ToString();
        }
        internal static int[] PreCalcReaderIndexes(int startIndex, int count)
        {
          var result = new int[count];

          for(int i = 0; i < count; i++)
            result[i] = startIndex++;

          return result;
        }
      }
      internal static class SqlExecute
      {
        internal static void Reader(int modelId, string dbFQName, string query, SqlParameter[] param, Action<SqlDataReader> materializer, FinishBehavior queryType, CommandType cmdType = CommandType.Text)
        {
          SqlDataReader reader = null;
          SqlConnection con = null;
          SqlCommand cmd = null;
          try
          {
            if(LogEnabled)
              Logger(dbFQName, query);

            con = new SqlConnection(_conStrings[modelId]);
            cmd = new SqlCommand(query, con) { CommandType = cmdType };
            if(param != null)
              cmd.Parameters.AddRange(param);
            con.Open();
            reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
            materializer.Invoke(reader);
          }
          finally
          {
            DisposeSqlObjects(con, cmd, reader, queryType);
          }
        }
        internal static int NonQuery(int modelId, string table, string query, SqlParameter[] param, FinishBehavior queryType, CommandType cmdType = CommandType.Text)
        {
          SqlConnection con = null;
          SqlCommand cmd = null;
          try
          {
            if(LogEnabled)
              Logger(table, query);

            con = new SqlConnection(_conStrings[modelId]);
            cmd = new SqlCommand(query, con) { CommandType = cmdType };
            if(param != null)
              cmd.Parameters.AddRange(param);
            con.Open();
            return cmd.ExecuteNonQuery();
          }
          finally
          {
            DisposeSqlObjects(con, cmd, null, queryType);
          }
        }
        internal static TScalarResult Scalar<TScalarResult>(int modelId, string table, string query, SqlParameter[] param, FinishBehavior queryType, CommandType cmdType = CommandType.Text)
        {
          SqlConnection con = null;
          SqlCommand cmd = null;
          try
          {
            if(LogEnabled)
              Logger(table, query);

            con = new SqlConnection(_conStrings[modelId]);
            cmd = new SqlCommand(query, con) { CommandType = cmdType };

            if(param != null)
              cmd.Parameters.AddRange(param);
            con.Open();

            var result = cmd.ExecuteScalar();

            if(result == null)
              return default;

            return (TScalarResult)result;
          }
          finally
          {
            DisposeSqlObjects(con, cmd, null, queryType);
          }
        }
        private static void DisposeSqlObjects(SqlConnection con, SqlCommand cmd, SqlDataReader reader, FinishBehavior queryType)
        {
          if(cmd != null)
          {
            cmd.Cancel();
            cmd.Dispose();
          }
          if(con != null)
          {
            if(con.State != ConnectionState.Closed)
              con.Close();
            con.Dispose();
          }
          switch(queryType)
          {
            case FinishBehavior.Cancel:
              if(cmd != null)
              {
                cmd.Cancel();
                cmd.Dispose();
              }
              if(reader != null)
              {
                if(!reader.IsClosed)
                  reader.Close();
                reader.Dispose();
              }
              break;
            case FinishBehavior.CloseReader:
              if(reader != null)
              {
                if(!reader.IsClosed)
                  reader.Close();
                reader.Dispose();
              }
              if(cmd != null)
                cmd.Dispose();
              break;
            case FinishBehavior.DisposeCommand:
              if(cmd != null)
              {
                cmd.Dispose();
              }
              break;
            default:
              throw new ArgumentException($"QueryType {queryType} is not supported.");
          }
          if(con != null)
          {
            if(con.State != ConnectionState.Closed)
              con.Close();
            con.Dispose();
          }
        }
      }
    }
  }
}
