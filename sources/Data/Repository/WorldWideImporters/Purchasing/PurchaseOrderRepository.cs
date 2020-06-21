/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{
    public partial class PurchaseOrderRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing;
using WorldWideImportersE = TheSharpFactory.Data.Entity.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class represents the Repository for: PurchaseOrder.
    /// </summary>
    public partial class PurchaseOrderRepository:WritableRepositoryBase<PurchaseOrder, PurchaseOrderProperty, PurchaseOrderNavProperty>, IPurchaseOrderRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<PurchaseOrderNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<PurchaseOrderNavProperty, NavPropertyInfo>(7){ { PurchaseOrderNavProperty.PurchaseOrderLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrderLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.PurchaseOrderID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderLineProperty.PurchaseOrderID, },} } }, { PurchaseOrderNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { PurchaseOrderNavProperty.Person1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.ContactPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { PurchaseOrderNavProperty.DeliveryMethod, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_DeliveryMethod, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.DeliveryMethodID, OtherPropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.DeliveryMethodID, },} } }, { PurchaseOrderNavProperty.Supplier, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.SupplierID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierID, },} } }, { PurchaseOrderNavProperty.SupplierTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.PurchaseOrderID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.PurchaseOrderID, },} } }, { PurchaseOrderNavProperty.StockItemTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.PurchaseOrderID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.PurchaseOrderID, },} } },};
        #endregion
        #region Constructors
        public PurchaseOrderRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrder;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Purchasing_PurchaseOrders) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<PurchaseOrderProperty>(1){ SortFilter.New(PurchaseOrderProperty.PurchaseOrderID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database by Primary Key.
        /// </summary>
        /// <param name="purchaseorderid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        public PurchaseOrder ByPK(int purchaseorderid)
        {
            var where = new QueryFilters<PurchaseOrderProperty>(1){QueryFilter.New(PurchaseOrderProperty.PurchaseOrderID, FilterConditions.Equals, purchaseorderid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="purchaseorderid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        public PurchaseOrder ByPK(int purchaseorderid, NavProps<PurchaseOrderNavProperty> navprops)
        {
            var where = new QueryFilters<PurchaseOrderProperty>(1){QueryFilter.New(PurchaseOrderProperty.PurchaseOrderID, FilterConditions.Equals, purchaseorderid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database by Primary Key.
        /// </summary>
        /// <param name="purchaseorderid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int purchaseorderid)
        {
            var where = new QueryFilters<PurchaseOrderProperty>(1){QueryFilter.New(PurchaseOrderProperty.PurchaseOrderID, FilterConditions.Equals, purchaseorderid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<PurchaseOrderProperty> ComposeKeys(PurchaseOrder purchaseorder)
        {
            return new QueryFilters<PurchaseOrderProperty>{ QueryFilter.New(PurchaseOrderProperty.PurchaseOrderID, FilterConditions.Equals, purchaseorder.PurchaseOrderID) };
        }
        protected override QueryFilters<PurchaseOrderProperty> GetChanges(PurchaseOrder original, PurchaseOrder changed)
        {
            return PurchaseOrderUtils.GetChanges(original, changed);
        }
        protected override void Merge(PurchaseOrder source, PurchaseOrder target)
        {
            PurchaseOrderUtils.Merge(source, target);
        }
        protected override QueryFilters<PurchaseOrderProperty> ComposeInsertPredicate(PurchaseOrder purchaseorder)
        {
            return new QueryFilters<PurchaseOrderProperty>{ QueryFilter.New(PurchaseOrderProperty.PurchaseOrderID, FilterConditions.Equals, purchaseorder.PurchaseOrderID), QueryFilter.New(PurchaseOrderProperty.SupplierID, FilterConditions.Equals, purchaseorder.SupplierID), QueryFilter.New(PurchaseOrderProperty.OrderDate, FilterConditions.Equals, purchaseorder.OrderDate), QueryFilter.New(PurchaseOrderProperty.DeliveryMethodID, FilterConditions.Equals, purchaseorder.DeliveryMethodID), QueryFilter.New(PurchaseOrderProperty.ContactPersonID, FilterConditions.Equals, purchaseorder.ContactPersonID), QueryFilter.New(PurchaseOrderProperty.ExpectedDeliveryDate, FilterConditions.Equals, purchaseorder.ExpectedDeliveryDate), QueryFilter.New(PurchaseOrderProperty.SupplierReference, FilterConditions.Equals, purchaseorder.SupplierReference), QueryFilter.New(PurchaseOrderProperty.IsOrderFinalized, FilterConditions.Equals, purchaseorder.IsOrderFinalized), QueryFilter.New(PurchaseOrderProperty.Comments, FilterConditions.Equals, purchaseorder.Comments), QueryFilter.New(PurchaseOrderProperty.InternalComments, FilterConditions.Equals, purchaseorder.InternalComments), QueryFilter.New(PurchaseOrderProperty.LastEditedBy, FilterConditions.Equals, purchaseorder.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 12);
        }
        private static PurchaseOrder MaterializeSingleEntity(SqlDataReader r)
        {
            return new PurchaseOrder
            {
                PurchaseOrderID = r.GetInt32(0),
                SupplierID = r.GetInt32(1),
                OrderDate = r.GetDateTime(2),
                DeliveryMethodID = r.GetInt32(3),
                ContactPersonID = r.GetInt32(4),
                ExpectedDeliveryDate = r.GetValue(5) as DateTime?,
                SupplierReference = r.GetValue(6) as string,
                IsOrderFinalized = r.GetBoolean(7),
                Comments = r.GetValue(8) as string,
                InternalComments = r.GetValue(9) as string,
                LastEditedBy = r.GetInt32(10),
                LastEditedWhen = r.GetDateTime(11),
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
                var np = (PurchaseOrderNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case PurchaseOrderNavProperty.PurchaseOrderLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PurchaseOrderNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PurchaseOrderNavProperty.Person1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PurchaseOrderNavProperty.DeliveryMethod:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PurchaseOrderNavProperty.Supplier:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PurchaseOrderNavProperty.SupplierTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PurchaseOrderNavProperty.StockItemTransactions:
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
                var np = (PurchaseOrderNavProperty)p.Value;
                switch(np)
                {
                    case PurchaseOrderNavProperty.PurchaseOrderLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PurchaseOrderNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PurchaseOrderNavProperty.Person1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PurchaseOrderNavProperty.DeliveryMethod:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PurchaseOrderNavProperty.Supplier:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PurchaseOrderNavProperty.SupplierTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PurchaseOrderNavProperty.StockItemTransactions:
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
        protected override void BuildObjectGraph(List<PurchaseOrder> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, PurchaseOrder> ComposeDictionaryByPK(List<PurchaseOrder> entities, MultiKeyDictionary<int, PurchaseOrder> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, PurchaseOrder>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.PurchaseOrderID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<PurchaseOrder> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, PurchaseOrder>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (PurchaseOrderNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case PurchaseOrderNavProperty.PurchaseOrderLines:
                    #region PurchaseOrderLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PurchaseOrderID];
                                p.PurchaseOrderLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine>(p.PurchaseOrderLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PurchaseOrderNavProperty.Person:
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
                    case PurchaseOrderNavProperty.Person1:
                    #region Person1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>();
                            foreach(var p in list)
                                navByKey.Add(p.PersonID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.ContactPersonID))
                                    c.Person1 = navByKey[c.ContactPersonID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PurchaseOrderNavProperty.DeliveryMethod:
                    #region DeliveryMethod
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod>();
                            foreach(var p in list)
                                navByKey.Add(p.DeliveryMethodID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.DeliveryMethodID))
                                    c.DeliveryMethod = navByKey[c.DeliveryMethodID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PurchaseOrderNavProperty.Supplier:
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
                                if(navByKey.ContainsKey(c.SupplierID))
                                    c.Supplier = navByKey[c.SupplierID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PurchaseOrderNavProperty.SupplierTransactions:
                    #region SupplierTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PurchaseOrderID.Value];
                                p.SupplierTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(p.SupplierTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PurchaseOrderNavProperty.StockItemTransactions:
                    #region StockItemTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PurchaseOrderID.Value];
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
