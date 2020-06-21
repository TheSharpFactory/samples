/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class OrderLineRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales;
using WorldWideImportersE = TheSharpFactory.Data.Entity.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{

    /// <summary>
    /// This class represents the Repository for: OrderLine.
    /// </summary>
    public partial class OrderLineRepository:WritableRepositoryBase<OrderLine, OrderLineProperty, OrderLineNavProperty>, IOrderLineRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<OrderLineNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<OrderLineNavProperty, NavPropertyInfo>(4){ { OrderLineNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderLineProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { OrderLineNavProperty.Order, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Order, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderLineProperty.OrderID, OtherPropId = (int)WorldWideImportersE.Sales.OrderProperty.OrderID, },} } }, { OrderLineNavProperty.PackageType, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_PackageType, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderLineProperty.PackageTypeID, OtherPropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, },} } }, { OrderLineNavProperty.StockItem, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderLineProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, },} } },};
        #endregion
        #region Constructors
        public OrderLineRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_OrderLine;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Sales_OrderLines) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<OrderLineProperty>(1){ SortFilter.New(OrderLineProperty.OrderLineID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine from the database by Primary Key.
        /// </summary>
        /// <param name="orderlineid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine</returns>
        public OrderLine ByPK(int orderlineid)
        {
            var where = new QueryFilters<OrderLineProperty>(1){QueryFilter.New(OrderLineProperty.OrderLineID, FilterConditions.Equals, orderlineid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="orderlineid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine</returns>
        public OrderLine ByPK(int orderlineid, NavProps<OrderLineNavProperty> navprops)
        {
            var where = new QueryFilters<OrderLineProperty>(1){QueryFilter.New(OrderLineProperty.OrderLineID, FilterConditions.Equals, orderlineid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine from the database by Primary Key.
        /// </summary>
        /// <param name="orderlineid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int orderlineid)
        {
            var where = new QueryFilters<OrderLineProperty>(1){QueryFilter.New(OrderLineProperty.OrderLineID, FilterConditions.Equals, orderlineid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<OrderLineProperty> ComposeKeys(OrderLine orderline)
        {
            return new QueryFilters<OrderLineProperty>{ QueryFilter.New(OrderLineProperty.OrderLineID, FilterConditions.Equals, orderline.OrderLineID) };
        }
        protected override QueryFilters<OrderLineProperty> GetChanges(OrderLine original, OrderLine changed)
        {
            return OrderLineUtils.GetChanges(original, changed);
        }
        protected override void Merge(OrderLine source, OrderLine target)
        {
            OrderLineUtils.Merge(source, target);
        }
        protected override QueryFilters<OrderLineProperty> ComposeInsertPredicate(OrderLine orderline)
        {
            return new QueryFilters<OrderLineProperty>{ QueryFilter.New(OrderLineProperty.OrderLineID, FilterConditions.Equals, orderline.OrderLineID), QueryFilter.New(OrderLineProperty.OrderID, FilterConditions.Equals, orderline.OrderID), QueryFilter.New(OrderLineProperty.StockItemID, FilterConditions.Equals, orderline.StockItemID), QueryFilter.New(OrderLineProperty.Description, FilterConditions.Equals, orderline.Description), QueryFilter.New(OrderLineProperty.PackageTypeID, FilterConditions.Equals, orderline.PackageTypeID), QueryFilter.New(OrderLineProperty.Quantity, FilterConditions.Equals, orderline.Quantity), QueryFilter.New(OrderLineProperty.UnitPrice, FilterConditions.Equals, orderline.UnitPrice), QueryFilter.New(OrderLineProperty.TaxRate, FilterConditions.Equals, orderline.TaxRate), QueryFilter.New(OrderLineProperty.PickedQuantity, FilterConditions.Equals, orderline.PickedQuantity), QueryFilter.New(OrderLineProperty.PickingCompletedWhen, FilterConditions.Equals, orderline.PickingCompletedWhen), QueryFilter.New(OrderLineProperty.LastEditedBy, FilterConditions.Equals, orderline.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 12);
        }
        private static OrderLine MaterializeSingleEntity(SqlDataReader r)
        {
            return new OrderLine
            {
                OrderLineID = r.GetInt32(0),
                OrderID = r.GetInt32(1),
                StockItemID = r.GetInt32(2),
                Description = r.GetString(3),
                PackageTypeID = r.GetInt32(4),
                Quantity = r.GetInt32(5),
                UnitPrice = r.GetValue(6) as decimal?,
                TaxRate = r.GetDecimal(7),
                PickedQuantity = r.GetInt32(8),
                PickingCompletedWhen = r.GetValue(9) as DateTime?,
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
                var np = (OrderLineNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case OrderLineNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderLineNavProperty.Order:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderLineNavProperty.PackageType:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderLineNavProperty.StockItem:
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
                var np = (OrderLineNavProperty)p.Value;
                switch(np)
                {
                    case OrderLineNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderLineNavProperty.Order:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderLineNavProperty.PackageType:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderLineNavProperty.StockItem:
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
        protected override void BuildObjectGraph(List<OrderLine> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<OrderLine> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (OrderLineNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case OrderLineNavProperty.Person:
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
                    case OrderLineNavProperty.Order:
                    #region Order
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>();
                            foreach(var p in list)
                                navByKey.Add(p.OrderID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.OrderID))
                                    c.Order = navByKey[c.OrderID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case OrderLineNavProperty.PackageType:
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
                    case OrderLineNavProperty.StockItem:
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
