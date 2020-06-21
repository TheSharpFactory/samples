/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class StockItemTransactionRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse;
using WorldWideImportersE = TheSharpFactory.Data.Entity.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class represents the Repository for: StockItemTransaction.
    /// </summary>
    public partial class StockItemTransactionRepository:WritableRepositoryBase<StockItemTransaction, StockItemTransactionProperty, StockItemTransactionNavProperty>, IStockItemTransactionRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<StockItemTransactionNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<StockItemTransactionNavProperty, NavPropertyInfo>(7){ { StockItemTransactionNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { StockItemTransactionNavProperty.Customer, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, },} } }, { StockItemTransactionNavProperty.Invoice, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.InvoiceID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.InvoiceID, },} } }, { StockItemTransactionNavProperty.PurchaseOrder, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrder, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.PurchaseOrderID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.PurchaseOrderID, },} } }, { StockItemTransactionNavProperty.StockItem, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, },} } }, { StockItemTransactionNavProperty.Supplier, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.SupplierID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierID, },} } }, { StockItemTransactionNavProperty.TransactionType, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_TransactionType, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.TransactionTypeID, OtherPropId = (int)WorldWideImportersE.Application.TransactionTypeProperty.TransactionTypeID, },} } },};
        #endregion
        #region Constructors
        public StockItemTransactionRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemTransaction;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Warehouse_StockItemTransactions) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<StockItemTransactionProperty>(1){ SortFilter.New(StockItemTransactionProperty.StockItemTransactionID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemtransactionid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        public StockItemTransaction ByPK(int stockitemtransactionid)
        {
            var where = new QueryFilters<StockItemTransactionProperty>(1){QueryFilter.New(StockItemTransactionProperty.StockItemTransactionID, FilterConditions.Equals, stockitemtransactionid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemtransactionid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        public StockItemTransaction ByPK(int stockitemtransactionid, NavProps<StockItemTransactionNavProperty> navprops)
        {
            var where = new QueryFilters<StockItemTransactionProperty>(1){QueryFilter.New(StockItemTransactionProperty.StockItemTransactionID, FilterConditions.Equals, stockitemtransactionid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemtransactionid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int stockitemtransactionid)
        {
            var where = new QueryFilters<StockItemTransactionProperty>(1){QueryFilter.New(StockItemTransactionProperty.StockItemTransactionID, FilterConditions.Equals, stockitemtransactionid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<StockItemTransactionProperty> ComposeKeys(StockItemTransaction stockitemtransaction)
        {
            return new QueryFilters<StockItemTransactionProperty>{ QueryFilter.New(StockItemTransactionProperty.StockItemTransactionID, FilterConditions.Equals, stockitemtransaction.StockItemTransactionID) };
        }
        protected override QueryFilters<StockItemTransactionProperty> GetChanges(StockItemTransaction original, StockItemTransaction changed)
        {
            return StockItemTransactionUtils.GetChanges(original, changed);
        }
        protected override void Merge(StockItemTransaction source, StockItemTransaction target)
        {
            StockItemTransactionUtils.Merge(source, target);
        }
        protected override QueryFilters<StockItemTransactionProperty> ComposeInsertPredicate(StockItemTransaction stockitemtransaction)
        {
            return new QueryFilters<StockItemTransactionProperty>{ QueryFilter.New(StockItemTransactionProperty.StockItemTransactionID, FilterConditions.Equals, stockitemtransaction.StockItemTransactionID), QueryFilter.New(StockItemTransactionProperty.StockItemID, FilterConditions.Equals, stockitemtransaction.StockItemID), QueryFilter.New(StockItemTransactionProperty.TransactionTypeID, FilterConditions.Equals, stockitemtransaction.TransactionTypeID), QueryFilter.New(StockItemTransactionProperty.CustomerID, FilterConditions.Equals, stockitemtransaction.CustomerID), QueryFilter.New(StockItemTransactionProperty.InvoiceID, FilterConditions.Equals, stockitemtransaction.InvoiceID), QueryFilter.New(StockItemTransactionProperty.SupplierID, FilterConditions.Equals, stockitemtransaction.SupplierID), QueryFilter.New(StockItemTransactionProperty.PurchaseOrderID, FilterConditions.Equals, stockitemtransaction.PurchaseOrderID), QueryFilter.New(StockItemTransactionProperty.TransactionOccurredWhen, FilterConditions.Equals, stockitemtransaction.TransactionOccurredWhen), QueryFilter.New(StockItemTransactionProperty.Quantity, FilterConditions.Equals, stockitemtransaction.Quantity), QueryFilter.New(StockItemTransactionProperty.LastEditedBy, FilterConditions.Equals, stockitemtransaction.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 11);
        }
        private static StockItemTransaction MaterializeSingleEntity(SqlDataReader r)
        {
            return new StockItemTransaction
            {
                StockItemTransactionID = r.GetInt32(0),
                StockItemID = r.GetInt32(1),
                TransactionTypeID = r.GetInt32(2),
                CustomerID = r.GetValue(3) as int?,
                InvoiceID = r.GetValue(4) as int?,
                SupplierID = r.GetValue(5) as int?,
                PurchaseOrderID = r.GetValue(6) as int?,
                TransactionOccurredWhen = r.GetDateTime(7),
                Quantity = r.GetDecimal(8),
                LastEditedBy = r.GetInt32(9),
                LastEditedWhen = r.GetDateTime(10),
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
                var np = (StockItemTransactionNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case StockItemTransactionNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemTransactionNavProperty.Customer:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemTransactionNavProperty.Invoice:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemTransactionNavProperty.PurchaseOrder:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemTransactionNavProperty.StockItem:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemTransactionNavProperty.Supplier:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemTransactionNavProperty.TransactionType:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (StockItemTransactionNavProperty)p.Value;
                switch(np)
                {
                    case StockItemTransactionNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemTransactionNavProperty.Customer:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemTransactionNavProperty.Invoice:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemTransactionNavProperty.PurchaseOrder:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemTransactionNavProperty.StockItem:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemTransactionNavProperty.Supplier:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemTransactionNavProperty.TransactionType:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<StockItemTransaction> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<StockItemTransaction> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (StockItemTransactionNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case StockItemTransactionNavProperty.Person:
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
                    case StockItemTransactionNavProperty.Customer:
                    #region Customer
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>();
                            foreach(var p in list)
                                navByKey.Add(p.CustomerID, p);
                            foreach(var c in entities)
                            {
                                if(!c.CustomerID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.CustomerID.Value))
                                    c.Customer = navByKey[c.CustomerID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemTransactionNavProperty.Invoice:
                    #region Invoice
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>();
                            foreach(var p in list)
                                navByKey.Add(p.InvoiceID, p);
                            foreach(var c in entities)
                            {
                                if(!c.InvoiceID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.InvoiceID.Value))
                                    c.Invoice = navByKey[c.InvoiceID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemTransactionNavProperty.PurchaseOrder:
                    #region PurchaseOrder
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>();
                            foreach(var p in list)
                                navByKey.Add(p.PurchaseOrderID, p);
                            foreach(var c in entities)
                            {
                                if(!c.PurchaseOrderID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.PurchaseOrderID.Value))
                                    c.PurchaseOrder = navByKey[c.PurchaseOrderID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemTransactionNavProperty.StockItem:
                    #region StockItem
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>();
                            foreach(var p in list)
                                navByKey.Add(p.StockItemID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.StockItemID))
                                    c.StockItem = navByKey[c.StockItemID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemTransactionNavProperty.Supplier:
                    #region Supplier
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>();
                            foreach(var p in list)
                                navByKey.Add(p.SupplierID, p);
                            foreach(var c in entities)
                            {
                                if(!c.SupplierID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.SupplierID.Value))
                                    c.Supplier = navByKey[c.SupplierID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemTransactionNavProperty.TransactionType:
                    #region TransactionType
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType>();
                            foreach(var p in list)
                                navByKey.Add(p.TransactionTypeID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.TransactionTypeID))
                                    c.TransactionType = navByKey[c.TransactionTypeID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
