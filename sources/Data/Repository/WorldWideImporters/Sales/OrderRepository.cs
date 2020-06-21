/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class OrderRepository
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
    /// This class represents the Repository for: Order.
    /// </summary>
    public partial class OrderRepository:WritableRepositoryBase<Order, OrderProperty, OrderNavProperty>, IOrderRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<OrderNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<OrderNavProperty, NavPropertyInfo>(8){ { OrderNavProperty.Invoices, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderProperty.OrderID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.OrderID, },} } }, { OrderNavProperty.OrderLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_OrderLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderProperty.OrderID, OtherPropId = (int)WorldWideImportersE.Sales.OrderLineProperty.OrderID, },} } }, { OrderNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { OrderNavProperty.Order1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Order, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderProperty.BackorderOrderID, OtherPropId = (int)WorldWideImportersE.Sales.OrderProperty.OrderID, },} } }, { OrderNavProperty.Person1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderProperty.ContactPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { OrderNavProperty.Customer, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, },} } }, { OrderNavProperty.Person2, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderProperty.PickedByPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { OrderNavProperty.Person3, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.OrderProperty.SalespersonPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } },};
        #endregion
        #region Constructors
        public OrderRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Order;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Sales_Orders) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<OrderProperty>(1){ SortFilter.New(OrderProperty.OrderID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order from the database by Primary Key.
        /// </summary>
        /// <param name="orderid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order</returns>
        public Order ByPK(int orderid)
        {
            var where = new QueryFilters<OrderProperty>(1){QueryFilter.New(OrderProperty.OrderID, FilterConditions.Equals, orderid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="orderid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order</returns>
        public Order ByPK(int orderid, NavProps<OrderNavProperty> navprops)
        {
            var where = new QueryFilters<OrderProperty>(1){QueryFilter.New(OrderProperty.OrderID, FilterConditions.Equals, orderid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order from the database by Primary Key.
        /// </summary>
        /// <param name="orderid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int orderid)
        {
            var where = new QueryFilters<OrderProperty>(1){QueryFilter.New(OrderProperty.OrderID, FilterConditions.Equals, orderid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<OrderProperty> ComposeKeys(Order order)
        {
            return new QueryFilters<OrderProperty>{ QueryFilter.New(OrderProperty.OrderID, FilterConditions.Equals, order.OrderID) };
        }
        protected override QueryFilters<OrderProperty> GetChanges(Order original, Order changed)
        {
            return OrderUtils.GetChanges(original, changed);
        }
        protected override void Merge(Order source, Order target)
        {
            OrderUtils.Merge(source, target);
        }
        protected override QueryFilters<OrderProperty> ComposeInsertPredicate(Order order)
        {
            return new QueryFilters<OrderProperty>{ QueryFilter.New(OrderProperty.OrderID, FilterConditions.Equals, order.OrderID), QueryFilter.New(OrderProperty.CustomerID, FilterConditions.Equals, order.CustomerID), QueryFilter.New(OrderProperty.SalespersonPersonID, FilterConditions.Equals, order.SalespersonPersonID), QueryFilter.New(OrderProperty.PickedByPersonID, FilterConditions.Equals, order.PickedByPersonID), QueryFilter.New(OrderProperty.ContactPersonID, FilterConditions.Equals, order.ContactPersonID), QueryFilter.New(OrderProperty.BackorderOrderID, FilterConditions.Equals, order.BackorderOrderID), QueryFilter.New(OrderProperty.OrderDate, FilterConditions.Equals, order.OrderDate), QueryFilter.New(OrderProperty.ExpectedDeliveryDate, FilterConditions.Equals, order.ExpectedDeliveryDate), QueryFilter.New(OrderProperty.CustomerPurchaseOrderNumber, FilterConditions.Equals, order.CustomerPurchaseOrderNumber), QueryFilter.New(OrderProperty.IsUndersupplyBackordered, FilterConditions.Equals, order.IsUndersupplyBackordered), QueryFilter.New(OrderProperty.Comments, FilterConditions.Equals, order.Comments), QueryFilter.New(OrderProperty.DeliveryInstructions, FilterConditions.Equals, order.DeliveryInstructions), QueryFilter.New(OrderProperty.InternalComments, FilterConditions.Equals, order.InternalComments), QueryFilter.New(OrderProperty.PickingCompletedWhen, FilterConditions.Equals, order.PickingCompletedWhen), QueryFilter.New(OrderProperty.LastEditedBy, FilterConditions.Equals, order.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 16);
        }
        private static Order MaterializeSingleEntity(SqlDataReader r)
        {
            return new Order
            {
                OrderID = r.GetInt32(0),
                CustomerID = r.GetInt32(1),
                SalespersonPersonID = r.GetInt32(2),
                PickedByPersonID = r.GetValue(3) as int?,
                ContactPersonID = r.GetInt32(4),
                BackorderOrderID = r.GetValue(5) as int?,
                OrderDate = r.GetDateTime(6),
                ExpectedDeliveryDate = r.GetDateTime(7),
                CustomerPurchaseOrderNumber = r.GetValue(8) as string,
                IsUndersupplyBackordered = r.GetBoolean(9),
                Comments = r.GetValue(10) as string,
                DeliveryInstructions = r.GetValue(11) as string,
                InternalComments = r.GetValue(12) as string,
                PickingCompletedWhen = r.GetValue(13) as DateTime?,
                LastEditedBy = r.GetInt32(14),
                LastEditedWhen = r.GetDateTime(15),
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
                var np = (OrderNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case OrderNavProperty.Invoices:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderNavProperty.OrderLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderNavProperty.Order1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderNavProperty.Person1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderNavProperty.Customer:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderNavProperty.Person2:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case OrderNavProperty.Person3:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (OrderNavProperty)p.Value;
                switch(np)
                {
                    case OrderNavProperty.Invoices:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderNavProperty.OrderLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderNavProperty.Order1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderNavProperty.Person1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderNavProperty.Customer:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderNavProperty.Person2:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case OrderNavProperty.Person3:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<Order> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Order> ComposeDictionaryByPK(List<Order> entities, MultiKeyDictionary<int, Order> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Order>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.OrderID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Order> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Order>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (OrderNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case OrderNavProperty.Invoices:
                    #region Invoices
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.OrderID.Value];
                                p.Invoices = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(p.Invoices, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case OrderNavProperty.OrderLines:
                    #region OrderLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.OrderID];
                                p.OrderLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine>(p.OrderLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case OrderNavProperty.Person:
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
                    case OrderNavProperty.Order1:
                    #region Order1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>();
                            foreach(var p in list)
                                navByKey.Add(p.OrderID, p);
                            foreach(var c in entities)
                            {
                                if(!c.BackorderOrderID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.BackorderOrderID.Value))
                                    c.Order1 = navByKey[c.BackorderOrderID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case OrderNavProperty.Person1:
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
                    case OrderNavProperty.Customer:
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
                                if(navByKey.ContainsKey(c.CustomerID))
                                    c.Customer = navByKey[c.CustomerID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case OrderNavProperty.Person2:
                    #region Person2
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>();
                            foreach(var p in list)
                                navByKey.Add(p.PersonID, p);
                            foreach(var c in entities)
                            {
                                if(!c.PickedByPersonID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.PickedByPersonID.Value))
                                    c.Person2 = navByKey[c.PickedByPersonID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case OrderNavProperty.Person3:
                    #region Person3
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>();
                            foreach(var p in list)
                                navByKey.Add(p.PersonID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.SalespersonPersonID))
                                    c.Person3 = navByKey[c.SalespersonPersonID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
