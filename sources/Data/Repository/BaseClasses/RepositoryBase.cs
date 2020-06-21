/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Common
{
    public abstract partial class RepositoryBase
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Linq;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Repository.Common
{

    /// <summary>
    /// This class is the base class for all Repository classes.
    /// </summary>
    public abstract partial class RepositoryBase
    {
        #region Protected Properties
        protected int ModelId { get; set; }
        protected int EntityId { get; set; }
        #endregion
        #region Abstract Methods
        protected abstract object MaterializeEntity(SqlDataReader r);
        #endregion
        #region Materialization
        protected static void MaterializeResult(SqlDataReader r, Func<SqlDataReader, object>[] materializers, object[] resultSets, PaginationSettings pagination = null)
        {
            var resultIndex = 0;
            var keepReading = true;
            while(keepReading)
            {
                MaterializeResult(r, materializers[resultIndex], resultSets, resultIndex, pagination);
                keepReading = r.NextResult();
                resultIndex++;
            }
        }
        protected static void MaterializeResult(SqlDataReader r, Func<SqlDataReader, object> materializer, object[] resultSets, PaginationSettings pagination = null)
        {
            MaterializeResult(r, materializer, resultSets, 0, pagination);
        }
        private static void MaterializeResult(SqlDataReader r, Func<SqlDataReader, object> materializer, object[] resultSets, int resultIndex, PaginationSettings pagination)
        {
            if(pagination == null || !pagination.GetTotalCount)
            {
                resultSets[resultIndex] = materializer(r);
                return;
            }
            var materialized = materializer(r);
            if(materialized is object[] array)
            {
                pagination.TotalCount = (int)array[0];
                resultSets[resultIndex] = array[1];
            }
            else
            {
                resultSets[resultIndex] = materialized;
            }
        }
        protected static object MaterializeEntityResult<TEntity>(SqlDataReader r, Func<SqlDataReader, TEntity> materializer, int fieldCount)
        {
            var result = new List<TEntity>(10000);//warmup the list to try to get a head start by avoiding auto grow happenning too soon.
            var totalRowCount = 0;//this is used for pagination represents the total number of rows returned if no pagination was being used
            var firstRow = true;
            while(r.Read())
            {
                result.Add(materializer(r));
                if(firstRow)
                {
                    firstRow = false;
                    if(r.FieldCount > fieldCount)//if the field count is greater than the column count get the total number of rows from the last column
                    {
                        totalRowCount = r.GetInt32(fieldCount);
                    }
                }
            }
            if(result.Count < 1)
                result = null;
            if(totalRowCount > 0)
            {
                return new object[] { totalRowCount, result };//return both the row count for pagination and the results
            }
            return result;
        }
        protected static List<TEntity> UnboxEntityList<TEntity>(object result)
        {
            if(result == null)
                return null;
            if(!(result is List<TEntity> list))
                throw new ArgumentException($"Unable to convert type {result.GetType().Name} to List<{typeof(TEntity).FullName}>.");
            return list;
        }
        protected static List<TEntity> AddEntityToList<TEntity>(List<TEntity> list, TEntity entity)
        {
            if(list == null)
                list = new List<TEntity>();
            list.Add(entity);
            return list;
        }
        protected static XDocument MaterializeXmlProperty(SqlDataReader r, int index)
        {
            var sqlXml = r.GetSqlXml(index);
            if(sqlXml.IsNull)
                return null;
            var result = (XDocument)null;
            using(var xReader = sqlXml.CreateReader())
            {
                result = XDocument.Load(xReader);
                xReader.Close();
            }
            return result;
        }
        #endregion
    }

    /// <summary>
    /// This class is the base class for all Repository classes with read capability. No Navigation Property support.
    /// </summary>
    public abstract partial class ReadableRepositoryBase<TEntity, TPropEnum>: RepositoryBase where TPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        #region Protected Properties
        protected SortFilters<TPropEnum> DefaultSort { get; set; }
        protected bool HasTriggers { get; set; }
        #endregion
        #region Abstract Methods
        protected abstract QueryFilters<TPropEnum> ComposeKeys(TEntity entity);
        protected abstract QueryFilters<TPropEnum> ComposeInsertPredicate(TEntity entity);
        protected abstract QueryFilters<TPropEnum> GetChanges(TEntity original, TEntity changed);
        protected abstract void Merge(TEntity source, TEntity target);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TEntity from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TEntity</returns>
        public List<TEntity> Top(int topcount, Query<TPropEnum> query)
        {
            return SelectMany(query.Prepare().PredicateFilters, query.Prepare().Sorting ?? DefaultSort, null, topcount);
        }
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TEntity from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TEntity</returns>
        public TEntity FirstOrDefault(Query<TPropEnum> query)
        {
            var result = Top(1, query);
            if(result?.Count > 0)
                return result[0];
            return default(TEntity);
        }
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TEntity from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TEntity</returns>
        public TEntity First(Query<TPropEnum> query)
        {
            var result = FirstOrDefault(query);
            if(result == null)
                throw new InvalidOperationException("No entity was found for this query.");
            return result;
        }
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TEntity from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TEntity</returns>
        public TEntity SingleOrDefault(Query<TPropEnum> query)
        {
            var result = Top(2, query);
            if(result?.Count == 1)
                return result[0];
            if(result?.Count > 1)
                throw new InvalidOperationException("More than one entity was found for this query.");
            return default(TEntity);
        }
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TEntity from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TEntity</returns>
        public TEntity Single(Query<TPropEnum> query)
        {
            var result = SingleOrDefault(query);
            if(result == null)
                throw new InvalidOperationException("No entity was found for this query.");
            return result;
        }
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TEntity from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TEntity</returns>
        public List<TEntity> ToList(Query<TPropEnum> query)
        {
            return SelectMany(query.Prepare().PredicateFilters, query.Prepare().Sorting ?? DefaultSort, query.Prepare().Pagination, 0);
        }
        /// <summary>
        /// Gets List of TEntity from the database. No filtering.
        /// </summary>
        /// <returns>List of TEntity</returns>
        public List<TEntity> ToList()
        {
            return SelectMany(null, DefaultSort, null, 0);
        }
        #endregion
        #region Materialization
        protected static List<TEntity> BuildEntityTree(object[] resultSets)
        {
            if(!(resultSets?.Length > 0) || resultSets[0] == null)
                return null;
            return resultSets[0] as List<TEntity>;
        }
        #endregion
        #region Store Queries
        protected TEntity SelectSingle(QueryFilters<TPropEnum> where, SortFilters<TPropEnum> orderby)
        {
            var result = SelectMany(where, orderby, null, 0);
            if(!(result?.Count > 0))
                return default(TEntity);
            if(result.Count > 1)
                throw new InvalidOperationException($"More than one record was found at the store for entity: {typeof(TEntity).FullName}");
            return result[0];
        }
        protected List<TEntity> SelectMany(QueryFilters<TPropEnum> filters, SortFilters<TPropEnum> sortFilters, PaginationSettings pagination, int topCount)
        {
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets, pagination); }
            Database.Select(ModelId, EntityId, topCount, filters?.IFilters, sortFilters?.IFilters, pagination, null, materialize);
            var result = BuildEntityTree(resultSets);//build the tree AFTER the reader is done and disposed.
            if(result?.Count > 0)
                return result;
            return null;
        }
        #endregion
    }

    /// <summary>
    /// This class is the base class for all Repository classes with read capability. With Nav Property support.
    /// </summary>
    public abstract partial class ReadableRepositoryBase<TEntity, TPropEnum, TNavPropEnum>: ReadableRepositoryBase<TEntity, TPropEnum> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TNavPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        #region Abstract Methods
        protected abstract List<NavPropertyInfo> BuildNavPropInfoTree(NavProps navprop);
        protected abstract List<Func<SqlDataReader, object>> GetNavPropMaterializers(NavProps navprops);
        protected abstract void BuildObjectGraph(List<TEntity> entities, object[] results, NavProps navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TEntity from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TEntity</returns>
        public List<TEntity> Top(int topcount, Query<TPropEnum, TNavPropEnum> query)
        {
            return SelectMany(query.Prepare().PredicateFilters, query.Prepare().Sorting ?? DefaultSort, query.Prepare().NavigationProperties, null, topcount);
        }
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TEntity from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TEntity</returns>
        public TEntity FirstOrDefault(Query<TPropEnum, TNavPropEnum> query)
        {
            var result = Top(1, query);
            if(result?.Count > 0)
                return result[0];
            return default(TEntity);
        }
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TEntity from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TEntity</returns>
        public TEntity First(Query<TPropEnum, TNavPropEnum> query)
        {
            var result = FirstOrDefault(query);
            if(result == null)
                throw new InvalidOperationException("No entity was found for this query.");
            return result;
        }
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TEntity from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TEntity</returns>
        public TEntity SingleOrDefault(Query<TPropEnum, TNavPropEnum> query)
        {
            var result = Top(2, query);
            if(result?.Count == 1)
                return result[0];
            if(result?.Count > 1)
                throw new InvalidOperationException("More than one entity was found for this query.");
            return default(TEntity);
        }
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TEntity from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TEntity</returns>
        public TEntity Single(Query<TPropEnum, TNavPropEnum> query)
        {
            var result = SingleOrDefault(query);
            if(result == null)
                throw new InvalidOperationException("No entity was found for this query.");
            return result;
        }
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TEntity from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TEntity</returns>
        public List<TEntity> ToList(Query<TPropEnum, TNavPropEnum> query)
        {
            return SelectMany(query.Prepare().PredicateFilters, query.Prepare().Sorting ?? DefaultSort, query.Prepare().NavigationProperties, query.Prepare().Pagination, 0);
        }
        #endregion
        #region Materialization
        protected List<TEntity> BuildEntityTree(object[] resultSets, NavProps navprops)
        {
            if(!(resultSets?.Length > 0) || resultSets[0] == null)
                return null;
            var entityList = resultSets[0] as List<TEntity>;
            if(resultSets.Length == 1)
                return entityList;
            if(navprops.Count > 0)
                BuildObjectGraph(entityList, resultSets, navprops);
            return entityList;
        }
        #endregion
        #region Store Queries
        protected TEntity SelectSingle(QueryFilters<TPropEnum> where, SortFilters<TPropEnum> orderby, NavProps navprops)
        {
            var result = SelectMany(where, orderby, navprops, null, 0);
            if(!(result?.Count > 0))
                return default(TEntity);
            if(result.Count > 1)
                throw new InvalidOperationException($"More than one record was found at the store for entity: {typeof(TEntity).FullName}");
            return result[0];
        }
        protected List<TEntity> SelectMany(QueryFilters<TPropEnum> filters, SortFilters<TPropEnum> sortFilters, NavProps navprops, PaginationSettings pagination, int topCount)
        {
            var navPropCount = navprops != null ? navprops.TotalCount : 0;
            var resultCount = 1 + navPropCount;
            var resultSets = new object[resultCount];
            var materializers = new Func<SqlDataReader, object>[resultCount];
            materializers[0] = MaterializeEntity;
            if(navPropCount > 0)
            {
                var npMaterializers = GetNavPropMaterializers(navprops);
                npMaterializers.CopyTo(materializers, 1);
            }
            void materialize (SqlDataReader r) { MaterializeResult(r, materializers, resultSets, pagination); }
            Database.Select(ModelId, EntityId, topCount, filters?.IFilters, sortFilters?.IFilters, pagination, BuildNavPropInfoTree(navprops), materialize);
            var result = BuildEntityTree(resultSets, navprops);//build the tree AFTER the reader is done and disposed.
            if(result?.Count > 0)
                return result;
            return null;
        }
        #endregion
    }

    /// <summary>
    /// This class is the base class for all Repository classes with read and write capabilities. No Navigation Property support.
    /// </summary>
    public abstract partial class WritableRepositoryBase<TEntity, TPropEnum>: ReadableRepositoryBase<TEntity, TPropEnum> where TPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        #region Create
        /// <summary>
        /// Creates the specified TEntity in the database.
        /// </summary>
        /// <param name="entity">The TEntity to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        public bool Create(TEntity entity)
        {
            return InsertEntity(entity);
        }
        #endregion
        #region Create List
        /// <summary>
        /// Creates each TEntity from the list in the database.
        /// </summary>
        /// <param name="entities">List of TEntity to create.</param>
        /// <returns>void</returns>
        public void Create(List<TEntity> entities)
        {
            if(entities == null)
                throw new ArgumentNullException("The entities parameter cannot be null. Failed to create list.");
            foreach(var entity in entities)
            {
                if(!Create(entity))
                    throw new Exception("Failed to create one or more entities.");
            }
        }
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TEntity in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="entity">The TEntity to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        public bool Update(TEntity entity)
        {
            return UpdateEntity(entity);
        }
        #endregion
        #region Update Optimistic
        /// <summary>
        /// <para>Updates the specified TEntity in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        public bool Update(TEntity original, TEntity changed)
        {
            return UpdateOptimisticEntity(original, changed);
        }
        #endregion
        #region Update Any
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        public List<TEntity> Update(Query<TPropEnum> query)
        {
            return UpdateAny(query.Prepare().SetValues, query.Prepare().PredicateFilters);
        }
        #endregion
        #region Update List
        /// <summary>
        /// <para>Updates each TEntity from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="entities">List of TEntity to update.</param>
        /// <returns>void</returns>
        public void Update(List<TEntity> entities)
        {
            if(entities == null)
                throw new ArgumentNullException("The entities parameter cannot be null. Failed to update list.");
            foreach(var entity in entities)
            {
                Update(entity);
            }
        }
        #endregion
        #region Update Or Create
        /// <summary>
        /// <para>Updates the specified TEntity in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="entity">The TEntity to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        public bool UpdateOrCreate(TEntity entity)
        {
            return UpdateOrCreateEntity(entity);
        }
        #endregion
        #region Update Or Create List
        /// <summary>
        /// <para>Updates each TEntity from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="entities">List of TEntity to update or create.</param>
        /// <returns>void</returns>
        public void UpdateOrCreate(List<TEntity> entities)
        {
            foreach(var entity in entities)
            {
                UpdateOrCreate(entity);
            }
        }
        #endregion
        #region DeleteEntity
        /// <summary>
        /// Deletes the specified TEntity from the database.
        /// </summary>
        /// <param name="entity">The TEntity to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool Delete(TEntity entity)
        {
            var where = ComposeKeys(entity);
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteAny
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        public int Delete(Query<TPropEnum> query)
        {
            return DeleteAny(query.Prepare().PredicateFilters);
        }
        #endregion
        #region DeleteList
        /// <summary>
        /// Deletes each TEntity in the list from the database.
        /// </summary>
        /// <param name="entities">List of TEntity to delete.</param>
        /// <returns>void</returns>
        public void Delete(List<TEntity> entities)
        {
            foreach(var entity in entities)
                Delete(entity);
        }
        #endregion
        #region Store Queries
        protected int DeleteAny(QueryFilters<TPropEnum> where)
        {
            return Database.Delete(ModelId, EntityId, where?.IFilters);
        }
        protected bool UpdateEntity(TEntity entity)
        {
            if(entity == null)
                throw new ArgumentNullException($"The {typeof(TEntity).FullName} parameter cannot be null. Failed to update.");
            var where = ComposeKeys(entity);
            var dbEntity = SelectSingle(where, DefaultSort);
            if(dbEntity == null)
                throw new ArgumentException($"The {typeof(TEntity).FullName} was not found in the data store. Failed to update.");
            var changes = GetChanges(dbEntity, entity);
            if(changes == null)
                return false;
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            Database.Update(ModelId, EntityId, changes?.IFilters, where?.IFilters, materialize);
            var result = BuildEntityTree(resultSets);//build the tree AFTER the reader is done and disposed.
            if(!(result?.Count > 0) || result[0] == null)
                return false;
            Merge(result[0], entity);
            return true;
        }
        protected List<TEntity> UpdateAny(QueryFilters<TPropEnum> valuesToSet, QueryFilters<TPropEnum> where)
        {
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            Database.Update(ModelId, EntityId, valuesToSet?.IFilters, where?.IFilters, materialize);
            var result = BuildEntityTree(resultSets);//Build the tree AFTER the reader is done and disposed.
            if(result?.Count > 0)
                return result;
            return null;
        }
        protected bool UpdateOptimisticEntity(TEntity original, TEntity changed)
        {
            if(original == null)
                throw new ArgumentNullException("The original parameter cannot be null. Failed to update.");
            if(changed == null)
                throw new ArgumentNullException("The changed parameter cannot be null. Failed to update.");
            var where = ComposeKeys(original);
            var changes = GetChanges(original, changed);
            if(changes == null)
                return false;
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            Database.Update(ModelId, EntityId, changes?.IFilters, where?.IFilters, materialize);
            var result = BuildEntityTree(resultSets);//build the tree AFTER the reader is done and disposed.
            if(!(result?.Count > 0) || result[0] == null)
                return false;
            Merge(result[0], original);
            Merge(result[0], changed);
            return true;
        }
        protected bool UpdateOrCreateEntity(TEntity entity)
        {
            if(entity == null)
                throw new ArgumentNullException($"The {typeof(TEntity).FullName} parameter cannot be null. Failed to update or create.");
            var where = ComposeKeys(entity);
            var dbEntity = SelectSingle(where, DefaultSort);
            if(dbEntity == null)
                return InsertEntity(entity);
            var changes = GetChanges(dbEntity, entity);
            if(changes == null)
                return false;
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            Database.Update(ModelId, EntityId, changes?.IFilters, where?.IFilters, materialize);
            var result = BuildEntityTree(resultSets);//build the tree AFTER the reader is done and disposed.
            if(!(result?.Count > 0) || result[0] == null)
                return false;
            Merge(result[0], entity);
            return true;
        }
        protected bool InsertEntity(TEntity entity)
        {
            if(entity == null)
                throw new ArgumentNullException($"The {typeof(TEntity).FullName} parameter cannot be null. Failed to create.");
            var insertValues = ComposeInsertPredicate(entity);
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            if (HasTriggers)
            {
                var where = ComposeKeys(entity);
                Database.Insert(ModelId, EntityId, insertValues?.IFilters, where?.IFilters, materialize);
            }
            else
            {
                Database.Insert(ModelId, EntityId, insertValues?.IFilters, materialize);
            }
            var result = BuildEntityTree(resultSets);//Build the tree AFTER the reader is done and disposed.
            if(!(result?.Count > 0) || result[0] == null)
                return false;
            Merge(result[0], entity);
            return true;
        }
        #endregion
    }

    /// <summary>
    /// This class is the base class for all Repository classes with read and write capabilities. With Nav Property support.
    /// </summary>
    public abstract partial class WritableRepositoryBase<TEntity, TPropEnum, TNavPropEnum>: ReadableRepositoryBase<TEntity, TPropEnum, TNavPropEnum> where TPropEnum : struct, IComparable, IFormattable, IConvertible where TNavPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        #region Create
        /// <summary>
        /// Creates the specified TEntity in the database.
        /// </summary>
        /// <param name="entity">The TEntity to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        public bool Create(TEntity entity)
        {
            return InsertEntity(entity);
        }
        #endregion
        #region Create List
        /// <summary>
        /// Creates each TEntity from the list in the database.
        /// </summary>
        /// <param name="entities">List of TEntity to create.</param>
        /// <returns>void</returns>
        public void Create(List<TEntity> entities)
        {
            if(entities == null)
                throw new ArgumentNullException("The entities parameter cannot be null. Failed to create list.");
            foreach(var entity in entities)
            {
                if(!Create(entity))
                    throw new Exception("Failed to create one or more entities.");
            }
        }
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TEntity in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="entity">The TEntity to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        public bool Update(TEntity entity)
        {
            return UpdateEntity(entity);
        }
        #endregion
        #region Update Optimistic
        /// <summary>
        /// <para>Updates the specified TEntity in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        public bool Update(TEntity original, TEntity changed)
        {
            return UpdateOptimisticEntity(original, changed);
        }
        #endregion
        #region Update Any
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        public List<TEntity> Update(Query<TPropEnum> query)
        {
            return UpdateAny(query.Prepare().SetValues, query.Prepare().PredicateFilters);
        }
        #endregion
        #region Update List
        /// <summary>
        /// <para>Updates each TEntity from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="entities">List of TEntity to update.</param>
        /// <returns>void</returns>
        public void Update(List<TEntity> entities)
        {
            if(entities == null)
                throw new ArgumentNullException("The entities parameter cannot be null. Failed to update list.");
            foreach(var entity in entities)
            {
                Update(entity);
            }
        }
        #endregion
        #region Update Or Create
        /// <summary>
        /// <para>Updates the specified TEntity in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="entity">The TEntity to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        public bool UpdateOrCreate(TEntity entity)
        {
            return UpdateOrCreateEntity(entity);
        }
        #endregion
        #region Update Or Create List
        /// <summary>
        /// <para>Updates each TEntity from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="entities">List of TEntity to update or create.</param>
        /// <returns>void</returns>
        public void UpdateOrCreate(List<TEntity> entities)
        {
            foreach(var entity in entities)
            {
                UpdateOrCreate(entity);
            }
        }
        #endregion
        #region DeleteEntity
        /// <summary>
        /// Deletes the specified TEntity from the database.
        /// </summary>
        /// <param name="entity">The TEntity to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool Delete(TEntity entity)
        {
            var where = ComposeKeys(entity);
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteAny
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        public int Delete(Query<TPropEnum> query)
        {
            return DeleteAny(query.Prepare().PredicateFilters);
        }
        #endregion
        #region DeleteList
        /// <summary>
        /// Deletes each TEntity in the list from the database.
        /// </summary>
        /// <param name="entities">List of TEntity to delete.</param>
        /// <returns>void</returns>
        public void Delete(List<TEntity> entities)
        {
            foreach(var entity in entities)
                Delete(entity);
        }
        #endregion
        #region Store Queries
        protected int DeleteAny(QueryFilters<TPropEnum> where)
        {
            return Database.Delete(ModelId, EntityId, where?.IFilters);
        }
        protected bool UpdateEntity(TEntity entity)
        {
            if(entity == null)
                throw new ArgumentNullException($"The {typeof(TEntity).FullName} parameter cannot be null. Failed to update.");
            var where = ComposeKeys(entity);
            var dbEntity = SelectSingle(where, DefaultSort);
            if(dbEntity == null)
                throw new ArgumentException($"The {typeof(TEntity).FullName} was not found in the data store. Failed to update.");
            var changes = GetChanges(dbEntity, entity);
            if(changes == null)
                return false;
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            Database.Update(ModelId, EntityId, changes?.IFilters, where?.IFilters, materialize);
            var result = BuildEntityTree(resultSets);//build the tree AFTER the reader is done and disposed.
            if(!(result?.Count > 0) || result[0] == null)
                return false;
            Merge(result[0], entity);
            return true;
        }
        protected List<TEntity> UpdateAny(QueryFilters<TPropEnum> valuesToSet, QueryFilters<TPropEnum> where)
        {
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            Database.Update(ModelId, EntityId, valuesToSet?.IFilters, where?.IFilters, materialize);
            var result = BuildEntityTree(resultSets);//Build the tree AFTER the reader is done and disposed.
            if(result?.Count > 0)
                return result;
            return null;
        }
        protected bool UpdateOptimisticEntity(TEntity original, TEntity changed)
        {
            if(original == null)
                throw new ArgumentNullException("The original parameter cannot be null. Failed to update.");
            if(changed == null)
                throw new ArgumentNullException("The changed parameter cannot be null. Failed to update.");
            var where = ComposeKeys(original);
            var changes = GetChanges(original, changed);
            if(changes == null)
                return false;
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            Database.Update(ModelId, EntityId, changes?.IFilters, where?.IFilters, materialize);
            var result = BuildEntityTree(resultSets);//build the tree AFTER the reader is done and disposed.
            if(!(result?.Count > 0) || result[0] == null)
                return false;
            Merge(result[0], original);
            Merge(result[0], changed);
            return true;
        }
        protected bool UpdateOrCreateEntity(TEntity entity)
        {
            if(entity == null)
                throw new ArgumentNullException($"The {typeof(TEntity).FullName} parameter cannot be null. Failed to update or create.");
            var where = ComposeKeys(entity);
            var dbEntity = SelectSingle(where, DefaultSort);
            if(dbEntity == null)
                return InsertEntity(entity);
            var changes = GetChanges(dbEntity, entity);
            if(changes == null)
                return false;
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            Database.Update(ModelId, EntityId, changes?.IFilters, where?.IFilters, materialize);
            var result = BuildEntityTree(resultSets);//build the tree AFTER the reader is done and disposed.
            if(!(result?.Count > 0) || result[0] == null)
                return false;
            Merge(result[0], entity);
            return true;
        }
        protected bool InsertEntity(TEntity entity)
        {
            if(entity == null)
                throw new ArgumentNullException($"The {typeof(TEntity).FullName} parameter cannot be null. Failed to create.");
            var insertValues = ComposeInsertPredicate(entity);
            var resultSets = new object[1];
            void materialize (SqlDataReader r) { MaterializeResult(r, MaterializeEntity, resultSets); }
            if (HasTriggers)
            {
                var where = ComposeKeys(entity);
                Database.Insert(ModelId, EntityId, insertValues?.IFilters, where?.IFilters, materialize);
            }
            else
            {
                Database.Insert(ModelId, EntityId, insertValues?.IFilters, materialize);
            }
            var result = BuildEntityTree(resultSets);//Build the tree AFTER the reader is done and disposed.
            if(!(result?.Count > 0) || result[0] == null)
                return false;
            Merge(result[0], entity);
            return true;
        }
        #endregion
    }

    /// <summary>
    /// This class is the base class for all Stored Procedure Repository classes.
    /// </summary>
    public abstract partial class StoredProcedureRepositoryBase
    {
        #region Protected Properties
        protected int ModelId { get; set; }
        protected static int ReturnParamId { get { return Database.ReturnParamId; } }
        #endregion
        #region Protected Methods
        protected Dictionary<int, object> StoredProcedure(int procId, List<IQueryFilter> filters, Action<SqlDataReader> materialize) 
        {
            return Database.StoredProc(ModelId, procId, filters, materialize);
        }
        #endregion
    }

    /// <summary>
    /// This class is the base class for all Function Repository classes.
    /// </summary>
    public abstract partial class FunctionRepositoryBase
    {
        #region Protected Properties
        protected int ModelId { get; set; }
        #endregion
        #region Protected Methods
        protected void Function(int funcId, bool isScalar, SqlParameter[] param, Action<SqlDataReader> materialize) 
        {
            Database.Function(ModelId, funcId, isScalar, param, materialize);
        }
        #endregion
    }

    /// <summary>
    /// This class is the base class for all Sequence Repository classes.
    /// </summary>
    public abstract partial class SequenceRepositoryBase
    {
        #region Protected Properties
        protected int ModelId { get; set; }
        #endregion
        #region Protected Methods
        protected TResult Sequence<TResult>(int seqId) 
        {
            return Database.Sequence<TResult>(ModelId, seqId);
        }
        #endregion
    }
}
