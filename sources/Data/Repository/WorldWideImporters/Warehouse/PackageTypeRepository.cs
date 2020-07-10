/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class PackageTypeRepository
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
    /// This class represents the Repository for: PackageType.
    /// </summary>
    public partial class PackageTypeRepository:WritableRepositoryBase<PackageType, PackageTypeProperty, PackageTypeNavProperty>, IPackageTypeRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<PackageTypeNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<PackageTypeNavProperty, NavPropertyInfo>(6){ { PackageTypeNavProperty.PurchaseOrderLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrderLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderLineProperty.PackageTypeID, },} } }, { PackageTypeNavProperty.InvoiceLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_InvoiceLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceLineProperty.PackageTypeID, },} } }, { PackageTypeNavProperty.OrderLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_OrderLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, OtherPropId = (int)WorldWideImportersE.Sales.OrderLineProperty.PackageTypeID, },} } }, { PackageTypeNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { PackageTypeNavProperty.StockItems, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.OuterPackageID, },} } }, { PackageTypeNavProperty.StockItems1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.UnitPackageID, },} } },};
        #endregion
        #region Constructors
        public PackageTypeRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_PackageType;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Warehouse_PackageTypes) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<PackageTypeProperty>(1){ SortFilter.New(PackageTypeProperty.PackageTypeID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Warehouse_PackageTypes_PackageTypeName) sorting.
        private static readonly SortFilters<PackageTypeProperty> _sortBy_UQ_Warehouse_PackageTypes_PackageTypeName = new SortFilters<PackageTypeProperty>(1){ SortFilter.New(PackageTypeProperty.PackageTypeName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Primary Key.
        /// </summary>
        /// <param name="packagetypeid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        public PackageType ByPK(int packagetypeid)
        {
            var where = new QueryFilters<PackageTypeProperty>(1){QueryFilter.New(PackageTypeProperty.PackageTypeID, FilterConditions.Equals, packagetypeid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="packagetypeid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        public PackageType ByPK(int packagetypeid, NavProps<PackageTypeNavProperty> navprops)
        {
            var where = new QueryFilters<PackageTypeProperty>(1){QueryFilter.New(PackageTypeProperty.PackageTypeID, FilterConditions.Equals, packagetypeid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Unique Key named UQ_Warehouse_PackageTypes_PackageTypeName.
        /// </summary>
        /// <param name="packagetypename">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        public PackageType ByUK(string packagetypename)
        {
            //this method uses the UniqueKey UQ_Warehouse_PackageTypes_PackageTypeName
            var where = new QueryFilters<PackageTypeProperty>(1){QueryFilter.New(PackageTypeProperty.PackageTypeName, FilterConditions.Equals, packagetypename ), };
            return SelectSingle(where, _sortBy_UQ_Warehouse_PackageTypes_PackageTypeName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Unique Key named UQ_Warehouse_PackageTypes_PackageTypeName. Supports navigation properties.
        /// </summary>
        /// <param name="packagetypename">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        public PackageType ByUK(string packagetypename, NavProps<PackageTypeNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Warehouse_PackageTypes_PackageTypeName
            var where = new QueryFilters<PackageTypeProperty>(1){QueryFilter.New(PackageTypeProperty.PackageTypeName, FilterConditions.Equals, packagetypename ), };
            return SelectSingle(where, _sortBy_UQ_Warehouse_PackageTypes_PackageTypeName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Primary Key.
        /// </summary>
        /// <param name="packagetypeid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int packagetypeid)
        {
            var where = new QueryFilters<PackageTypeProperty>(1){QueryFilter.New(PackageTypeProperty.PackageTypeID, FilterConditions.Equals, packagetypeid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Unique Key named UQ_Warehouse_PackageTypes_PackageTypeName
        /// </summary>
        /// <param name="packagetypename">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string packagetypename)
        {
            //this method uses the UniqueKey UQ_Warehouse_PackageTypes_PackageTypeName
            var where = new QueryFilters<PackageTypeProperty>(1){QueryFilter.New(PackageTypeProperty.PackageTypeName, FilterConditions.Equals, packagetypename), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<PackageTypeProperty> ComposeKeys(PackageType packagetype)
        {
            return new QueryFilters<PackageTypeProperty>{ QueryFilter.New(PackageTypeProperty.PackageTypeID, FilterConditions.Equals, packagetype.PackageTypeID) };
        }
        protected override QueryFilters<PackageTypeProperty> GetChanges(PackageType original, PackageType changed)
        {
            return PackageTypeUtils.GetChanges(original, changed);
        }
        protected override void Merge(PackageType source, PackageType target)
        {
            PackageTypeUtils.Merge(source, target);
        }
        protected override QueryFilters<PackageTypeProperty> ComposeInsertPredicate(PackageType packagetype)
        {
            return new QueryFilters<PackageTypeProperty>{ QueryFilter.New(PackageTypeProperty.PackageTypeID, FilterConditions.Equals, packagetype.PackageTypeID), QueryFilter.New(PackageTypeProperty.PackageTypeName, FilterConditions.Equals, packagetype.PackageTypeName), QueryFilter.New(PackageTypeProperty.LastEditedBy, FilterConditions.Equals, packagetype.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static PackageType MaterializeSingleEntity(SqlDataReader r)
        {
            return new PackageType
            {
                PackageTypeID = r.GetInt32(0),
                PackageTypeName = r.GetString(1),
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
                var np = (PackageTypeNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case PackageTypeNavProperty.PurchaseOrderLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PackageTypeNavProperty.InvoiceLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PackageTypeNavProperty.OrderLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PackageTypeNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PackageTypeNavProperty.StockItems:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PackageTypeNavProperty.StockItems1:
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
                var np = (PackageTypeNavProperty)p.Value;
                switch(np)
                {
                    case PackageTypeNavProperty.PurchaseOrderLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PackageTypeNavProperty.InvoiceLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PackageTypeNavProperty.OrderLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PackageTypeNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PackageTypeNavProperty.StockItems:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PackageTypeNavProperty.StockItems1:
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
        protected override void BuildObjectGraph(List<PackageType> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, PackageType> ComposeDictionaryByPK(List<PackageType> entities, MultiKeyDictionary<int, PackageType> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, PackageType>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.PackageTypeID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<PackageType> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, PackageType>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (PackageTypeNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case PackageTypeNavProperty.PurchaseOrderLines:
                    #region PurchaseOrderLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PackageTypeID];
                                p.PurchaseOrderLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine>(p.PurchaseOrderLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PackageTypeNavProperty.InvoiceLines:
                    #region InvoiceLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PackageTypeID];
                                p.InvoiceLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine>(p.InvoiceLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PackageTypeNavProperty.OrderLines:
                    #region OrderLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PackageTypeID];
                                p.OrderLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine>(p.OrderLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PackageTypeNavProperty.Person:
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
                    case PackageTypeNavProperty.StockItems:
                    #region StockItems
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.OuterPackageID];
                                p.StockItems = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(p.StockItems, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PackageTypeNavProperty.StockItems1:
                    #region StockItems1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.UnitPackageID];
                                p.StockItems1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(p.StockItems1, c);
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
