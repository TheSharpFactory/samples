/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class StockItemRepository
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
    /// This class represents the Repository for: StockItem.
    /// </summary>
    public partial class StockItemRepository:WritableRepositoryBase<StockItem, StockItemProperty, StockItemNavProperty>, IStockItemRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<StockItemNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<StockItemNavProperty, NavPropertyInfo>(12){ { StockItemNavProperty.PurchaseOrderLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrderLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderLineProperty.StockItemID, },} } }, { StockItemNavProperty.InvoiceLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_InvoiceLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceLineProperty.StockItemID, },} } }, { StockItemNavProperty.OrderLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_OrderLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Sales.OrderLineProperty.StockItemID, },} } }, { StockItemNavProperty.SpecialDeals, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_SpecialDeal, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.StockItemID, },} } }, { StockItemNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { StockItemNavProperty.Color, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_Color, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.ColorID, OtherPropId = (int)WorldWideImportersE.Warehouse.ColorProperty.ColorID, },} } }, { StockItemNavProperty.PackageType, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_PackageType, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.OuterPackageID, OtherPropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, },} } }, { StockItemNavProperty.Supplier, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.SupplierID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierID, },} } }, { StockItemNavProperty.PackageType1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_PackageType, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.UnitPackageID, OtherPropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, },} } }, { StockItemNavProperty.StockItemStockGroups, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemStockGroup, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemStockGroupProperty.StockItemID, },} } }, { StockItemNavProperty.StockItemTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.StockItemID, },} } }, { StockItemNavProperty.StockItemHolding, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemHolding, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemHoldingProperty.StockItemID, },} } },};
        #endregion
        #region Constructors
        public StockItemRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Warehouse_StockItems) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<StockItemProperty>(1){ SortFilter.New(StockItemProperty.StockItemID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Warehouse_StockItems_StockItemName) sorting.
        private static readonly SortFilters<StockItemProperty> _sortBy_UQ_Warehouse_StockItems_StockItemName = new SortFilters<StockItemProperty>(1){ SortFilter.New(StockItemProperty.StockItemName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem</returns>
        public StockItem ByPK(int stockitemid)
        {
            var where = new QueryFilters<StockItemProperty>(1){QueryFilter.New(StockItemProperty.StockItemID, FilterConditions.Equals, stockitemid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem</returns>
        public StockItem ByPK(int stockitemid, NavProps<StockItemNavProperty> navprops)
        {
            var where = new QueryFilters<StockItemProperty>(1){QueryFilter.New(StockItemProperty.StockItemID, FilterConditions.Equals, stockitemid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem from the database by Unique Key named UQ_Warehouse_StockItems_StockItemName.
        /// </summary>
        /// <param name="stockitemname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem</returns>
        public StockItem ByUK(string stockitemname)
        {
            //this method uses the UniqueKey UQ_Warehouse_StockItems_StockItemName
            var where = new QueryFilters<StockItemProperty>(1){QueryFilter.New(StockItemProperty.StockItemName, FilterConditions.Equals, stockitemname ), };
            return SelectSingle(where, _sortBy_UQ_Warehouse_StockItems_StockItemName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem from the database by Unique Key named UQ_Warehouse_StockItems_StockItemName. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem</returns>
        public StockItem ByUK(string stockitemname, NavProps<StockItemNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Warehouse_StockItems_StockItemName
            var where = new QueryFilters<StockItemProperty>(1){QueryFilter.New(StockItemProperty.StockItemName, FilterConditions.Equals, stockitemname ), };
            return SelectSingle(where, _sortBy_UQ_Warehouse_StockItems_StockItemName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int stockitemid)
        {
            var where = new QueryFilters<StockItemProperty>(1){QueryFilter.New(StockItemProperty.StockItemID, FilterConditions.Equals, stockitemid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem from the database by Unique Key named UQ_Warehouse_StockItems_StockItemName
        /// </summary>
        /// <param name="stockitemname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string stockitemname)
        {
            //this method uses the UniqueKey UQ_Warehouse_StockItems_StockItemName
            var where = new QueryFilters<StockItemProperty>(1){QueryFilter.New(StockItemProperty.StockItemName, FilterConditions.Equals, stockitemname), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<StockItemProperty> ComposeKeys(StockItem stockitem)
        {
            return new QueryFilters<StockItemProperty>{ QueryFilter.New(StockItemProperty.StockItemID, FilterConditions.Equals, stockitem.StockItemID) };
        }
        protected override QueryFilters<StockItemProperty> GetChanges(StockItem original, StockItem changed)
        {
            return StockItemUtils.GetChanges(original, changed);
        }
        protected override void Merge(StockItem source, StockItem target)
        {
            StockItemUtils.Merge(source, target);
        }
        protected override QueryFilters<StockItemProperty> ComposeInsertPredicate(StockItem stockitem)
        {
            return new QueryFilters<StockItemProperty>{ QueryFilter.New(StockItemProperty.StockItemID, FilterConditions.Equals, stockitem.StockItemID), QueryFilter.New(StockItemProperty.StockItemName, FilterConditions.Equals, stockitem.StockItemName), QueryFilter.New(StockItemProperty.SupplierID, FilterConditions.Equals, stockitem.SupplierID), QueryFilter.New(StockItemProperty.ColorID, FilterConditions.Equals, stockitem.ColorID), QueryFilter.New(StockItemProperty.UnitPackageID, FilterConditions.Equals, stockitem.UnitPackageID), QueryFilter.New(StockItemProperty.OuterPackageID, FilterConditions.Equals, stockitem.OuterPackageID), QueryFilter.New(StockItemProperty.Brand, FilterConditions.Equals, stockitem.Brand), QueryFilter.New(StockItemProperty.Size, FilterConditions.Equals, stockitem.Size), QueryFilter.New(StockItemProperty.LeadTimeDays, FilterConditions.Equals, stockitem.LeadTimeDays), QueryFilter.New(StockItemProperty.QuantityPerOuter, FilterConditions.Equals, stockitem.QuantityPerOuter), QueryFilter.New(StockItemProperty.IsChillerStock, FilterConditions.Equals, stockitem.IsChillerStock), QueryFilter.New(StockItemProperty.Barcode, FilterConditions.Equals, stockitem.Barcode), QueryFilter.New(StockItemProperty.TaxRate, FilterConditions.Equals, stockitem.TaxRate), QueryFilter.New(StockItemProperty.UnitPrice, FilterConditions.Equals, stockitem.UnitPrice), QueryFilter.New(StockItemProperty.RecommendedRetailPrice, FilterConditions.Equals, stockitem.RecommendedRetailPrice), QueryFilter.New(StockItemProperty.TypicalWeightPerUnit, FilterConditions.Equals, stockitem.TypicalWeightPerUnit), QueryFilter.New(StockItemProperty.MarketingComments, FilterConditions.Equals, stockitem.MarketingComments), QueryFilter.New(StockItemProperty.InternalComments, FilterConditions.Equals, stockitem.InternalComments), QueryFilter.New(StockItemProperty.Photo, FilterConditions.Equals, stockitem.Photo), QueryFilter.New(StockItemProperty.CustomFields, FilterConditions.Equals, stockitem.CustomFields), QueryFilter.New(StockItemProperty.LastEditedBy, FilterConditions.Equals, stockitem.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 25);
        }
        private static StockItem MaterializeSingleEntity(SqlDataReader r)
        {
            return new StockItem
            {
                StockItemID = r.GetInt32(0),
                StockItemName = r.GetString(1),
                SupplierID = r.GetInt32(2),
                ColorID = r.GetValue(3) as int?,
                UnitPackageID = r.GetInt32(4),
                OuterPackageID = r.GetInt32(5),
                Brand = r.GetValue(6) as string,
                Size = r.GetValue(7) as string,
                LeadTimeDays = r.GetInt32(8),
                QuantityPerOuter = r.GetInt32(9),
                IsChillerStock = r.GetBoolean(10),
                Barcode = r.GetValue(11) as string,
                TaxRate = r.GetDecimal(12),
                UnitPrice = r.GetDecimal(13),
                RecommendedRetailPrice = r.GetValue(14) as decimal?,
                TypicalWeightPerUnit = r.GetDecimal(15),
                MarketingComments = r.GetValue(16) as string,
                InternalComments = r.GetValue(17) as string,
                Photo = r.GetValue(18) as byte[],
                CustomFields = r.GetValue(19) as string,
                Tags = r.GetValue(20) as string,
                SearchDetails = r.GetString(21),
                LastEditedBy = r.GetInt32(22),
                ValidFrom = r.GetDateTime(23),
                ValidTo = r.GetDateTime(24),
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
                var np = (StockItemNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case StockItemNavProperty.PurchaseOrderLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.InvoiceLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.OrderLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.SpecialDeals:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.Color:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.ColorRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.PackageType:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.Supplier:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.PackageType1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.StockItemStockGroups:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.StockItemTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemNavProperty.StockItemHolding:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemHoldingRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (StockItemNavProperty)p.Value;
                switch(np)
                {
                    case StockItemNavProperty.PurchaseOrderLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.InvoiceLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.OrderLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.SpecialDeals:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.Color:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.ColorRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.ColorRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.PackageType:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.Supplier:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.PackageType1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.StockItemStockGroups:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.StockItemTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemNavProperty.StockItemHolding:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemHoldingRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemHoldingRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<StockItem> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, StockItem> ComposeDictionaryByPK(List<StockItem> entities, MultiKeyDictionary<int, StockItem> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, StockItem>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.StockItemID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<StockItem> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, StockItem>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (StockItemNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case StockItemNavProperty.PurchaseOrderLines:
                    #region PurchaseOrderLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StockItemID];
                                p.PurchaseOrderLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine>(p.PurchaseOrderLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemNavProperty.InvoiceLines:
                    #region InvoiceLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StockItemID];
                                p.InvoiceLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine>(p.InvoiceLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemNavProperty.OrderLines:
                    #region OrderLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StockItemID];
                                p.OrderLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine>(p.OrderLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemNavProperty.SpecialDeals:
                    #region SpecialDeals
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StockItemID.Value];
                                p.SpecialDeals = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(p.SpecialDeals, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemNavProperty.Person:
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
                    case StockItemNavProperty.Color:
                    #region Color
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color>();
                            foreach(var p in list)
                                navByKey.Add(p.ColorID, p);
                            foreach(var c in entities)
                            {
                                if(!c.ColorID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.ColorID.Value))
                                    c.Color = navByKey[c.ColorID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.ColorRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemNavProperty.PackageType:
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
                                if(navByKey.ContainsKey(c.OuterPackageID))
                                    c.PackageType = navByKey[c.OuterPackageID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemNavProperty.Supplier:
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
                    case StockItemNavProperty.PackageType1:
                    #region PackageType1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType>();
                            foreach(var p in list)
                                navByKey.Add(p.PackageTypeID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.UnitPackageID))
                                    c.PackageType1 = navByKey[c.UnitPackageID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemNavProperty.StockItemStockGroups:
                    #region StockItemStockGroups
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StockItemID];
                                p.StockItemStockGroups = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup>(p.StockItemStockGroups, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemNavProperty.StockItemTransactions:
                    #region StockItemTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StockItemID];
                                p.StockItemTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(p.StockItemTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemNavProperty.StockItemHolding:
                    #region StockItemHolding
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StockItemID];
                                p.StockItemHolding = c;
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemHoldingRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
