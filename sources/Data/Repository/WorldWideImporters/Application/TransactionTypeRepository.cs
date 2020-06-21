/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class TransactionTypeRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application;
using WorldWideImportersE = TheSharpFactory.Data.Entity.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{

    /// <summary>
    /// This class represents the Repository for: TransactionType.
    /// </summary>
    public partial class TransactionTypeRepository:WritableRepositoryBase<TransactionType, TransactionTypeProperty, TransactionTypeNavProperty>, ITransactionTypeRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<TransactionTypeNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<TransactionTypeNavProperty, NavPropertyInfo>(4){ { TransactionTypeNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.TransactionTypeProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { TransactionTypeNavProperty.SupplierTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.TransactionTypeProperty.TransactionTypeID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.TransactionTypeID, },} } }, { TransactionTypeNavProperty.CustomerTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.TransactionTypeProperty.TransactionTypeID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.TransactionTypeID, },} } }, { TransactionTypeNavProperty.StockItemTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.TransactionTypeProperty.TransactionTypeID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.TransactionTypeID, },} } },};
        #endregion
        #region Constructors
        public TransactionTypeRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_TransactionType;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Application_TransactionTypes) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<TransactionTypeProperty>(1){ SortFilter.New(TransactionTypeProperty.TransactionTypeID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Application_TransactionTypes_TransactionTypeName) sorting.
        private static readonly SortFilters<TransactionTypeProperty> _sortBy_UQ_Application_TransactionTypes_TransactionTypeName = new SortFilters<TransactionTypeProperty>(1){ SortFilter.New(TransactionTypeProperty.TransactionTypeName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Primary Key.
        /// </summary>
        /// <param name="transactiontypeid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        public TransactionType ByPK(int transactiontypeid)
        {
            var where = new QueryFilters<TransactionTypeProperty>(1){QueryFilter.New(TransactionTypeProperty.TransactionTypeID, FilterConditions.Equals, transactiontypeid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="transactiontypeid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        public TransactionType ByPK(int transactiontypeid, NavProps<TransactionTypeNavProperty> navprops)
        {
            var where = new QueryFilters<TransactionTypeProperty>(1){QueryFilter.New(TransactionTypeProperty.TransactionTypeID, FilterConditions.Equals, transactiontypeid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Unique Key named UQ_Application_TransactionTypes_TransactionTypeName.
        /// </summary>
        /// <param name="transactiontypename">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        public TransactionType ByUK(string transactiontypename)
        {
            //this method uses the UniqueKey UQ_Application_TransactionTypes_TransactionTypeName
            var where = new QueryFilters<TransactionTypeProperty>(1){QueryFilter.New(TransactionTypeProperty.TransactionTypeName, FilterConditions.Equals, transactiontypename ), };
            return SelectSingle(where, _sortBy_UQ_Application_TransactionTypes_TransactionTypeName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Unique Key named UQ_Application_TransactionTypes_TransactionTypeName. Supports navigation properties.
        /// </summary>
        /// <param name="transactiontypename">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        public TransactionType ByUK(string transactiontypename, NavProps<TransactionTypeNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Application_TransactionTypes_TransactionTypeName
            var where = new QueryFilters<TransactionTypeProperty>(1){QueryFilter.New(TransactionTypeProperty.TransactionTypeName, FilterConditions.Equals, transactiontypename ), };
            return SelectSingle(where, _sortBy_UQ_Application_TransactionTypes_TransactionTypeName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Primary Key.
        /// </summary>
        /// <param name="transactiontypeid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int transactiontypeid)
        {
            var where = new QueryFilters<TransactionTypeProperty>(1){QueryFilter.New(TransactionTypeProperty.TransactionTypeID, FilterConditions.Equals, transactiontypeid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Unique Key named UQ_Application_TransactionTypes_TransactionTypeName
        /// </summary>
        /// <param name="transactiontypename">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string transactiontypename)
        {
            //this method uses the UniqueKey UQ_Application_TransactionTypes_TransactionTypeName
            var where = new QueryFilters<TransactionTypeProperty>(1){QueryFilter.New(TransactionTypeProperty.TransactionTypeName, FilterConditions.Equals, transactiontypename), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<TransactionTypeProperty> ComposeKeys(TransactionType transactiontype)
        {
            return new QueryFilters<TransactionTypeProperty>{ QueryFilter.New(TransactionTypeProperty.TransactionTypeID, FilterConditions.Equals, transactiontype.TransactionTypeID) };
        }
        protected override QueryFilters<TransactionTypeProperty> GetChanges(TransactionType original, TransactionType changed)
        {
            return TransactionTypeUtils.GetChanges(original, changed);
        }
        protected override void Merge(TransactionType source, TransactionType target)
        {
            TransactionTypeUtils.Merge(source, target);
        }
        protected override QueryFilters<TransactionTypeProperty> ComposeInsertPredicate(TransactionType transactiontype)
        {
            return new QueryFilters<TransactionTypeProperty>{ QueryFilter.New(TransactionTypeProperty.TransactionTypeID, FilterConditions.Equals, transactiontype.TransactionTypeID), QueryFilter.New(TransactionTypeProperty.TransactionTypeName, FilterConditions.Equals, transactiontype.TransactionTypeName), QueryFilter.New(TransactionTypeProperty.LastEditedBy, FilterConditions.Equals, transactiontype.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static TransactionType MaterializeSingleEntity(SqlDataReader r)
        {
            return new TransactionType
            {
                TransactionTypeID = r.GetInt32(0),
                TransactionTypeName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class.
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        protected override List<NavPropertyInfo> BuildNavPropInfoTree(NavProps navprops) 
        {
            return BuildNavPropInfos(navprops);
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        internal static List<NavPropertyInfo> BuildNavPropInfos(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                    return null;
            var result = new List<NavPropertyInfo>(navprops.Count);
            foreach(var p in navprops)
            {
                var np = (TransactionTypeNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case TransactionTypeNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case TransactionTypeNavProperty.SupplierTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case TransactionTypeNavProperty.CustomerTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case TransactionTypeNavProperty.StockItemTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Composes the Navigation Property tree materializers.
        /// </summary>
        /// <returns>
        /// List of Func of SqlDataReader, object
        /// </returns>
        protected override List<Func<SqlDataReader, object>> GetNavPropMaterializers(NavProps navprops) 
        {
            return ComposeNavPropMaterializers(navprops);
        }
        internal static List<Func<SqlDataReader, object>> ComposeNavPropMaterializers(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                return new List<Func<SqlDataReader, object>>(0);
            var result = new List<Func<SqlDataReader, object>>(navprops.TotalCount);
            foreach(var p in navprops)
            {
                var np = (TransactionTypeNavProperty)p.Value;
                switch(np)
                {
                    case TransactionTypeNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case TransactionTypeNavProperty.SupplierTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case TransactionTypeNavProperty.CustomerTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case TransactionTypeNavProperty.StockItemTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Populates the object graph with the materialized results.
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        protected override void BuildObjectGraph(List<TransactionType> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, TransactionType> ComposeDictionaryByPK(List<TransactionType> entities, MultiKeyDictionary<int, TransactionType> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, TransactionType>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.TransactionTypeID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<TransactionType> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, TransactionType>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (TransactionTypeNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case TransactionTypeNavProperty.Person:
                    #region Person
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>();
                            foreach(var p in list)
                                navByKey.Add(p.PersonID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.LastEditedBy))
                                    c.Person = navByKey[c.LastEditedBy];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case TransactionTypeNavProperty.SupplierTransactions:
                    #region SupplierTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.TransactionTypeID];
                                p.SupplierTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(p.SupplierTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case TransactionTypeNavProperty.CustomerTransactions:
                    #region CustomerTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.TransactionTypeID];
                                p.CustomerTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(p.CustomerTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case TransactionTypeNavProperty.StockItemTransactions:
                    #region StockItemTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.TransactionTypeID];
                                p.StockItemTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(p.StockItemTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return resultsetindex;
        }
        #endregion
    }
}
