/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class DeliveryMethodRepository
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
    /// This class represents the Repository for: DeliveryMethod.
    /// </summary>
    public partial class DeliveryMethodRepository:WritableRepositoryBase<DeliveryMethod, DeliveryMethodProperty, DeliveryMethodNavProperty>, IDeliveryMethodRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<DeliveryMethodNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<DeliveryMethodNavProperty, NavPropertyInfo>(5){ { DeliveryMethodNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { DeliveryMethodNavProperty.PurchaseOrders, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrder, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.DeliveryMethodID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.DeliveryMethodID, },} } }, { DeliveryMethodNavProperty.Suppliers, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.DeliveryMethodID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.DeliveryMethodID, },} } }, { DeliveryMethodNavProperty.Customers, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.DeliveryMethodID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.DeliveryMethodID, },} } }, { DeliveryMethodNavProperty.Invoices, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.DeliveryMethodID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.DeliveryMethodID, },} } },};
        #endregion
        #region Constructors
        public DeliveryMethodRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_DeliveryMethod;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Application_DeliveryMethods) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<DeliveryMethodProperty>(1){ SortFilter.New(DeliveryMethodProperty.DeliveryMethodID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Application_DeliveryMethods_DeliveryMethodName) sorting.
        private static readonly SortFilters<DeliveryMethodProperty> _sortBy_UQ_Application_DeliveryMethods_DeliveryMethodName = new SortFilters<DeliveryMethodProperty>(1){ SortFilter.New(DeliveryMethodProperty.DeliveryMethodName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Primary Key.
        /// </summary>
        /// <param name="deliverymethodid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        public DeliveryMethod ByPK(int deliverymethodid)
        {
            var where = new QueryFilters<DeliveryMethodProperty>(1){QueryFilter.New(DeliveryMethodProperty.DeliveryMethodID, FilterConditions.Equals, deliverymethodid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="deliverymethodid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        public DeliveryMethod ByPK(int deliverymethodid, NavProps<DeliveryMethodNavProperty> navprops)
        {
            var where = new QueryFilters<DeliveryMethodProperty>(1){QueryFilter.New(DeliveryMethodProperty.DeliveryMethodID, FilterConditions.Equals, deliverymethodid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Unique Key named UQ_Application_DeliveryMethods_DeliveryMethodName.
        /// </summary>
        /// <param name="deliverymethodname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        public DeliveryMethod ByUK(string deliverymethodname)
        {
            //this method uses the UniqueKey UQ_Application_DeliveryMethods_DeliveryMethodName
            var where = new QueryFilters<DeliveryMethodProperty>(1){QueryFilter.New(DeliveryMethodProperty.DeliveryMethodName, FilterConditions.Equals, deliverymethodname ), };
            return SelectSingle(where, _sortBy_UQ_Application_DeliveryMethods_DeliveryMethodName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Unique Key named UQ_Application_DeliveryMethods_DeliveryMethodName. Supports navigation properties.
        /// </summary>
        /// <param name="deliverymethodname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        public DeliveryMethod ByUK(string deliverymethodname, NavProps<DeliveryMethodNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Application_DeliveryMethods_DeliveryMethodName
            var where = new QueryFilters<DeliveryMethodProperty>(1){QueryFilter.New(DeliveryMethodProperty.DeliveryMethodName, FilterConditions.Equals, deliverymethodname ), };
            return SelectSingle(where, _sortBy_UQ_Application_DeliveryMethods_DeliveryMethodName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Primary Key.
        /// </summary>
        /// <param name="deliverymethodid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int deliverymethodid)
        {
            var where = new QueryFilters<DeliveryMethodProperty>(1){QueryFilter.New(DeliveryMethodProperty.DeliveryMethodID, FilterConditions.Equals, deliverymethodid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Unique Key named UQ_Application_DeliveryMethods_DeliveryMethodName
        /// </summary>
        /// <param name="deliverymethodname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string deliverymethodname)
        {
            //this method uses the UniqueKey UQ_Application_DeliveryMethods_DeliveryMethodName
            var where = new QueryFilters<DeliveryMethodProperty>(1){QueryFilter.New(DeliveryMethodProperty.DeliveryMethodName, FilterConditions.Equals, deliverymethodname), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<DeliveryMethodProperty> ComposeKeys(DeliveryMethod deliverymethod)
        {
            return new QueryFilters<DeliveryMethodProperty>{ QueryFilter.New(DeliveryMethodProperty.DeliveryMethodID, FilterConditions.Equals, deliverymethod.DeliveryMethodID) };
        }
        protected override QueryFilters<DeliveryMethodProperty> GetChanges(DeliveryMethod original, DeliveryMethod changed)
        {
            return DeliveryMethodUtils.GetChanges(original, changed);
        }
        protected override void Merge(DeliveryMethod source, DeliveryMethod target)
        {
            DeliveryMethodUtils.Merge(source, target);
        }
        protected override QueryFilters<DeliveryMethodProperty> ComposeInsertPredicate(DeliveryMethod deliverymethod)
        {
            return new QueryFilters<DeliveryMethodProperty>{ QueryFilter.New(DeliveryMethodProperty.DeliveryMethodID, FilterConditions.Equals, deliverymethod.DeliveryMethodID), QueryFilter.New(DeliveryMethodProperty.DeliveryMethodName, FilterConditions.Equals, deliverymethod.DeliveryMethodName), QueryFilter.New(DeliveryMethodProperty.LastEditedBy, FilterConditions.Equals, deliverymethod.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static DeliveryMethod MaterializeSingleEntity(SqlDataReader r)
        {
            return new DeliveryMethod
            {
                DeliveryMethodID = r.GetInt32(0),
                DeliveryMethodName = r.GetString(1),
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
                var np = (DeliveryMethodNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case DeliveryMethodNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case DeliveryMethodNavProperty.PurchaseOrders:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case DeliveryMethodNavProperty.Suppliers:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case DeliveryMethodNavProperty.Customers:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case DeliveryMethodNavProperty.Invoices:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (DeliveryMethodNavProperty)p.Value;
                switch(np)
                {
                    case DeliveryMethodNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case DeliveryMethodNavProperty.PurchaseOrders:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case DeliveryMethodNavProperty.Suppliers:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case DeliveryMethodNavProperty.Customers:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case DeliveryMethodNavProperty.Invoices:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<DeliveryMethod> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, DeliveryMethod> ComposeDictionaryByPK(List<DeliveryMethod> entities, MultiKeyDictionary<int, DeliveryMethod> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, DeliveryMethod>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.DeliveryMethodID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<DeliveryMethod> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, DeliveryMethod>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (DeliveryMethodNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case DeliveryMethodNavProperty.Person:
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
                    case DeliveryMethodNavProperty.PurchaseOrders:
                    #region PurchaseOrders
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.DeliveryMethodID];
                                p.PurchaseOrders = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(p.PurchaseOrders, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case DeliveryMethodNavProperty.Suppliers:
                    #region Suppliers
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.DeliveryMethodID.Value];
                                p.Suppliers = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(p.Suppliers, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case DeliveryMethodNavProperty.Customers:
                    #region Customers
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.DeliveryMethodID];
                                p.Customers = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(p.Customers, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case DeliveryMethodNavProperty.Invoices:
                    #region Invoices
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.DeliveryMethodID];
                                p.Invoices = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(p.Invoices, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
