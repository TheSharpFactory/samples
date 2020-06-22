/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{
    public partial class PurchaseOrderLineRepository
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
    /// This class represents the Repository for: PurchaseOrderLine.
    /// </summary>
    public partial class PurchaseOrderLineRepository:WritableRepositoryBase<PurchaseOrderLine, PurchaseOrderLineProperty, PurchaseOrderLineNavProperty>, IPurchaseOrderLineRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<PurchaseOrderLineNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<PurchaseOrderLineNavProperty, NavPropertyInfo>(4){ { PurchaseOrderLineNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderLineProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { PurchaseOrderLineNavProperty.PackageType, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_PackageType, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderLineProperty.PackageTypeID, OtherPropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, },} } }, { PurchaseOrderLineNavProperty.PurchaseOrder, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrder, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderLineProperty.PurchaseOrderID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.PurchaseOrderID, },} } }, { PurchaseOrderLineNavProperty.StockItem, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderLineProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, },} } },};
        #endregion
        #region Constructors
        public PurchaseOrderLineRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrderLine;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Purchasing_PurchaseOrderLines) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<PurchaseOrderLineProperty>(1){ SortFilter.New(PurchaseOrderLineProperty.PurchaseOrderLineID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database by Primary Key.
        /// </summary>
        /// <param name="purchaseorderlineid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        public PurchaseOrderLine ByPK(int purchaseorderlineid)
        {
            var where = new QueryFilters<PurchaseOrderLineProperty>(1){QueryFilter.New(PurchaseOrderLineProperty.PurchaseOrderLineID, FilterConditions.Equals, purchaseorderlineid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="purchaseorderlineid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        public PurchaseOrderLine ByPK(int purchaseorderlineid, NavProps<PurchaseOrderLineNavProperty> navprops)
        {
            var where = new QueryFilters<PurchaseOrderLineProperty>(1){QueryFilter.New(PurchaseOrderLineProperty.PurchaseOrderLineID, FilterConditions.Equals, purchaseorderlineid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database by Primary Key.
        /// </summary>
        /// <param name="purchaseorderlineid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int purchaseorderlineid)
        {
            var where = new QueryFilters<PurchaseOrderLineProperty>(1){QueryFilter.New(PurchaseOrderLineProperty.PurchaseOrderLineID, FilterConditions.Equals, purchaseorderlineid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<PurchaseOrderLineProperty> ComposeKeys(PurchaseOrderLine purchaseorderline)
        {
            return new QueryFilters<PurchaseOrderLineProperty>{ QueryFilter.New(PurchaseOrderLineProperty.PurchaseOrderLineID, FilterConditions.Equals, purchaseorderline.PurchaseOrderLineID) };
        }
        protected override QueryFilters<PurchaseOrderLineProperty> GetChanges(PurchaseOrderLine original, PurchaseOrderLine changed)
        {
            return PurchaseOrderLineUtils.GetChanges(original, changed);
        }
        protected override void Merge(PurchaseOrderLine source, PurchaseOrderLine target)
        {
            PurchaseOrderLineUtils.Merge(source, target);
        }
        protected override QueryFilters<PurchaseOrderLineProperty> ComposeInsertPredicate(PurchaseOrderLine purchaseorderline)
        {
            return new QueryFilters<PurchaseOrderLineProperty>{ QueryFilter.New(PurchaseOrderLineProperty.PurchaseOrderLineID, FilterConditions.Equals, purchaseorderline.PurchaseOrderLineID), QueryFilter.New(PurchaseOrderLineProperty.PurchaseOrderID, FilterConditions.Equals, purchaseorderline.PurchaseOrderID), QueryFilter.New(PurchaseOrderLineProperty.StockItemID, FilterConditions.Equals, purchaseorderline.StockItemID), QueryFilter.New(PurchaseOrderLineProperty.OrderedOuters, FilterConditions.Equals, purchaseorderline.OrderedOuters), QueryFilter.New(PurchaseOrderLineProperty.Description, FilterConditions.Equals, purchaseorderline.Description), QueryFilter.New(PurchaseOrderLineProperty.ReceivedOuters, FilterConditions.Equals, purchaseorderline.ReceivedOuters), QueryFilter.New(PurchaseOrderLineProperty.PackageTypeID, FilterConditions.Equals, purchaseorderline.PackageTypeID), QueryFilter.New(PurchaseOrderLineProperty.ExpectedUnitPricePerOuter, FilterConditions.Equals, purchaseorderline.ExpectedUnitPricePerOuter), QueryFilter.New(PurchaseOrderLineProperty.LastReceiptDate, FilterConditions.Equals, purchaseorderline.LastReceiptDate), QueryFilter.New(PurchaseOrderLineProperty.IsOrderLineFinalized, FilterConditions.Equals, purchaseorderline.IsOrderLineFinalized), QueryFilter.New(PurchaseOrderLineProperty.LastEditedBy, FilterConditions.Equals, purchaseorderline.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 12);
        }
        private static PurchaseOrderLine MaterializeSingleEntity(SqlDataReader r)
        {
            return new PurchaseOrderLine
            {
                PurchaseOrderLineID = r.GetInt32(0),
                PurchaseOrderID = r.GetInt32(1),
                StockItemID = r.GetInt32(2),
                OrderedOuters = r.GetInt32(3),
                Description = r.GetString(4),
                ReceivedOuters = r.GetInt32(5),
                PackageTypeID = r.GetInt32(6),
                ExpectedUnitPricePerOuter = r.GetValue(7) as decimal?,
                LastReceiptDate = r.GetValue(8) as DateTime?,
                IsOrderLineFinalized = r.GetBoolean(9),
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
                var np = (PurchaseOrderLineNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case PurchaseOrderLineNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PurchaseOrderLineNavProperty.PackageType:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PurchaseOrderLineNavProperty.PurchaseOrder:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PurchaseOrderLineNavProperty.StockItem:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (PurchaseOrderLineNavProperty)p.Value;
                switch(np)
                {
                    case PurchaseOrderLineNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PurchaseOrderLineNavProperty.PackageType:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PurchaseOrderLineNavProperty.PurchaseOrder:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PurchaseOrderLineNavProperty.StockItem:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<PurchaseOrderLine> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<PurchaseOrderLine> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (PurchaseOrderLineNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case PurchaseOrderLineNavProperty.Person:
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
                    case PurchaseOrderLineNavProperty.PackageType:
                    #region PackageType
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType>();
                            foreach(var p in list)
                                navByKey.Add(p.PackageTypeID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.PackageTypeID))
                                    c.PackageType = navByKey[c.PackageTypeID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PurchaseOrderLineNavProperty.PurchaseOrder:
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
                                if(navByKey.ContainsKey(c.PurchaseOrderID))
                                    c.PurchaseOrder = navByKey[c.PurchaseOrderID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PurchaseOrderLineNavProperty.StockItem:
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
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return resultsetindex;
        }
        #endregion
    }
}
