/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{
    public partial class SupplierRepository
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
    /// This class represents the Repository for: Supplier.
    /// </summary>
    public partial class SupplierRepository:WritableRepositoryBase<Supplier, SupplierProperty, SupplierNavProperty>, ISupplierRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<SupplierNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<SupplierNavProperty, NavPropertyInfo>(11){ { SupplierNavProperty.PurchaseOrders, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrder, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.SupplierID, },} } }, { SupplierNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.AlternateContactPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { SupplierNavProperty.Person1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { SupplierNavProperty.City, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_City, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.DeliveryCityID, OtherPropId = (int)WorldWideImportersE.Application.CityProperty.CityID, },} } }, { SupplierNavProperty.DeliveryMethod, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_DeliveryMethod, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.DeliveryMethodID, OtherPropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.DeliveryMethodID, },} } }, { SupplierNavProperty.City1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_City, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.PostalCityID, OtherPropId = (int)WorldWideImportersE.Application.CityProperty.CityID, },} } }, { SupplierNavProperty.Person2, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.PrimaryContactPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { SupplierNavProperty.SupplierCategory, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierCategory, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierCategoryID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierCategoryProperty.SupplierCategoryID, },} } }, { SupplierNavProperty.SupplierTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.SupplierID, },} } }, { SupplierNavProperty.StockItems, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.SupplierID, },} } }, { SupplierNavProperty.StockItemTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.SupplierID, },} } },};
        #endregion
        #region Constructors
        public SupplierRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Purchasing_Suppliers) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<SupplierProperty>(1){ SortFilter.New(SupplierProperty.SupplierID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Purchasing_Suppliers_SupplierName) sorting.
        private static readonly SortFilters<SupplierProperty> _sortBy_UQ_Purchasing_Suppliers_SupplierName = new SortFilters<SupplierProperty>(1){ SortFilter.New(SupplierProperty.SupplierName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Primary Key.
        /// </summary>
        /// <param name="supplierid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        public Supplier ByPK(int supplierid)
        {
            var where = new QueryFilters<SupplierProperty>(1){QueryFilter.New(SupplierProperty.SupplierID, FilterConditions.Equals, supplierid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="supplierid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        public Supplier ByPK(int supplierid, NavProps<SupplierNavProperty> navprops)
        {
            var where = new QueryFilters<SupplierProperty>(1){QueryFilter.New(SupplierProperty.SupplierID, FilterConditions.Equals, supplierid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Unique Key named UQ_Purchasing_Suppliers_SupplierName.
        /// </summary>
        /// <param name="suppliername">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        public Supplier ByUK(string suppliername)
        {
            //this method uses the UniqueKey UQ_Purchasing_Suppliers_SupplierName
            var where = new QueryFilters<SupplierProperty>(1){QueryFilter.New(SupplierProperty.SupplierName, FilterConditions.Equals, suppliername ), };
            return SelectSingle(where, _sortBy_UQ_Purchasing_Suppliers_SupplierName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Unique Key named UQ_Purchasing_Suppliers_SupplierName. Supports navigation properties.
        /// </summary>
        /// <param name="suppliername">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        public Supplier ByUK(string suppliername, NavProps<SupplierNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Purchasing_Suppliers_SupplierName
            var where = new QueryFilters<SupplierProperty>(1){QueryFilter.New(SupplierProperty.SupplierName, FilterConditions.Equals, suppliername ), };
            return SelectSingle(where, _sortBy_UQ_Purchasing_Suppliers_SupplierName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Primary Key.
        /// </summary>
        /// <param name="supplierid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int supplierid)
        {
            var where = new QueryFilters<SupplierProperty>(1){QueryFilter.New(SupplierProperty.SupplierID, FilterConditions.Equals, supplierid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Unique Key named UQ_Purchasing_Suppliers_SupplierName
        /// </summary>
        /// <param name="suppliername">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string suppliername)
        {
            //this method uses the UniqueKey UQ_Purchasing_Suppliers_SupplierName
            var where = new QueryFilters<SupplierProperty>(1){QueryFilter.New(SupplierProperty.SupplierName, FilterConditions.Equals, suppliername), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<SupplierProperty> ComposeKeys(Supplier supplier)
        {
            return new QueryFilters<SupplierProperty>{ QueryFilter.New(SupplierProperty.SupplierID, FilterConditions.Equals, supplier.SupplierID) };
        }
        protected override QueryFilters<SupplierProperty> GetChanges(Supplier original, Supplier changed)
        {
            return SupplierUtils.GetChanges(original, changed);
        }
        protected override void Merge(Supplier source, Supplier target)
        {
            SupplierUtils.Merge(source, target);
        }
        protected override QueryFilters<SupplierProperty> ComposeInsertPredicate(Supplier supplier)
        {
            return new QueryFilters<SupplierProperty>{ QueryFilter.New(SupplierProperty.SupplierID, FilterConditions.Equals, supplier.SupplierID), QueryFilter.New(SupplierProperty.SupplierName, FilterConditions.Equals, supplier.SupplierName), QueryFilter.New(SupplierProperty.SupplierCategoryID, FilterConditions.Equals, supplier.SupplierCategoryID), QueryFilter.New(SupplierProperty.PrimaryContactPersonID, FilterConditions.Equals, supplier.PrimaryContactPersonID), QueryFilter.New(SupplierProperty.AlternateContactPersonID, FilterConditions.Equals, supplier.AlternateContactPersonID), QueryFilter.New(SupplierProperty.DeliveryMethodID, FilterConditions.Equals, supplier.DeliveryMethodID), QueryFilter.New(SupplierProperty.DeliveryCityID, FilterConditions.Equals, supplier.DeliveryCityID), QueryFilter.New(SupplierProperty.PostalCityID, FilterConditions.Equals, supplier.PostalCityID), QueryFilter.New(SupplierProperty.SupplierReference, FilterConditions.Equals, supplier.SupplierReference), QueryFilter.New(SupplierProperty.BankAccountName, FilterConditions.Equals, supplier.BankAccountName), QueryFilter.New(SupplierProperty.BankAccountBranch, FilterConditions.Equals, supplier.BankAccountBranch), QueryFilter.New(SupplierProperty.BankAccountCode, FilterConditions.Equals, supplier.BankAccountCode), QueryFilter.New(SupplierProperty.BankAccountNumber, FilterConditions.Equals, supplier.BankAccountNumber), QueryFilter.New(SupplierProperty.BankInternationalCode, FilterConditions.Equals, supplier.BankInternationalCode), QueryFilter.New(SupplierProperty.PaymentDays, FilterConditions.Equals, supplier.PaymentDays), QueryFilter.New(SupplierProperty.InternalComments, FilterConditions.Equals, supplier.InternalComments), QueryFilter.New(SupplierProperty.PhoneNumber, FilterConditions.Equals, supplier.PhoneNumber), QueryFilter.New(SupplierProperty.FaxNumber, FilterConditions.Equals, supplier.FaxNumber), QueryFilter.New(SupplierProperty.WebsiteURL, FilterConditions.Equals, supplier.WebsiteURL), QueryFilter.New(SupplierProperty.DeliveryAddressLine1, FilterConditions.Equals, supplier.DeliveryAddressLine1), QueryFilter.New(SupplierProperty.DeliveryAddressLine2, FilterConditions.Equals, supplier.DeliveryAddressLine2), QueryFilter.New(SupplierProperty.DeliveryPostalCode, FilterConditions.Equals, supplier.DeliveryPostalCode), QueryFilter.New(SupplierProperty.DeliveryLocation, FilterConditions.Equals, supplier.DeliveryLocation), QueryFilter.New(SupplierProperty.PostalAddressLine1, FilterConditions.Equals, supplier.PostalAddressLine1), QueryFilter.New(SupplierProperty.PostalAddressLine2, FilterConditions.Equals, supplier.PostalAddressLine2), QueryFilter.New(SupplierProperty.PostalPostalCode, FilterConditions.Equals, supplier.PostalPostalCode), QueryFilter.New(SupplierProperty.LastEditedBy, FilterConditions.Equals, supplier.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 29);
        }
        private static Supplier MaterializeSingleEntity(SqlDataReader r)
        {
            return new Supplier
            {
                SupplierID = r.GetInt32(0),
                SupplierName = r.GetString(1),
                SupplierCategoryID = r.GetInt32(2),
                PrimaryContactPersonID = r.GetInt32(3),
                AlternateContactPersonID = r.GetInt32(4),
                DeliveryMethodID = r.GetValue(5) as int?,
                DeliveryCityID = r.GetInt32(6),
                PostalCityID = r.GetInt32(7),
                SupplierReference = r.GetValue(8) as string,
                BankAccountName = r.GetValue(9) as string,
                BankAccountBranch = r.GetValue(10) as string,
                BankAccountCode = r.GetValue(11) as string,
                BankAccountNumber = r.GetValue(12) as string,
                BankInternationalCode = r.GetValue(13) as string,
                PaymentDays = r.GetInt32(14),
                InternalComments = r.GetValue(15) as string,
                PhoneNumber = r.GetString(16),
                FaxNumber = r.GetString(17),
                WebsiteURL = r.GetString(18),
                DeliveryAddressLine1 = r.GetString(19),
                DeliveryAddressLine2 = r.GetValue(20) as string,
                DeliveryPostalCode = r.GetString(21),
                DeliveryLocation = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(22)),
                PostalAddressLine1 = r.GetString(23),
                PostalAddressLine2 = r.GetValue(24) as string,
                PostalPostalCode = r.GetString(25),
                LastEditedBy = r.GetInt32(26),
                ValidFrom = r.GetDateTime(27),
                ValidTo = r.GetDateTime(28),
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
                var np = (SupplierNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case SupplierNavProperty.PurchaseOrders:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.Person1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.City:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.DeliveryMethod:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.City1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.Person2:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.SupplierCategory:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierCategoryRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.SupplierTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.StockItems:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierNavProperty.StockItemTransactions:
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
                var np = (SupplierNavProperty)p.Value;
                switch(np)
                {
                    case SupplierNavProperty.PurchaseOrders:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.Person1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.City:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.DeliveryMethod:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.City1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.Person2:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.SupplierCategory:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierCategoryRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierCategoryRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.SupplierTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.StockItems:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierNavProperty.StockItemTransactions:
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
        protected override void BuildObjectGraph(List<Supplier> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Supplier> ComposeDictionaryByPK(List<Supplier> entities, MultiKeyDictionary<int, Supplier> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Supplier>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.SupplierID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Supplier> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Supplier>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (SupplierNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case SupplierNavProperty.PurchaseOrders:
                    #region PurchaseOrders
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.SupplierID];
                                p.PurchaseOrders = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(p.PurchaseOrders, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.Person:
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
                                if(navByKey.ContainsKey(c.AlternateContactPersonID))
                                    c.Person = navByKey[c.AlternateContactPersonID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.Person1:
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
                                if(navByKey.ContainsKey(c.LastEditedBy))
                                    c.Person1 = navByKey[c.LastEditedBy];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.City:
                    #region City
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>();
                            foreach(var p in list)
                                navByKey.Add(p.CityID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.DeliveryCityID))
                                    c.City = navByKey[c.DeliveryCityID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.DeliveryMethod:
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
                                if(!c.DeliveryMethodID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.DeliveryMethodID.Value))
                                    c.DeliveryMethod = navByKey[c.DeliveryMethodID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.City1:
                    #region City1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>();
                            foreach(var p in list)
                                navByKey.Add(p.CityID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.PostalCityID))
                                    c.City1 = navByKey[c.PostalCityID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.Person2:
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
                                if(navByKey.ContainsKey(c.PrimaryContactPersonID))
                                    c.Person2 = navByKey[c.PrimaryContactPersonID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.SupplierCategory:
                    #region SupplierCategory
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory>();
                            foreach(var p in list)
                                navByKey.Add(p.SupplierCategoryID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.SupplierCategoryID))
                                    c.SupplierCategory = navByKey[c.SupplierCategoryID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierCategoryRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.SupplierTransactions:
                    #region SupplierTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.SupplierID];
                                p.SupplierTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(p.SupplierTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.StockItems:
                    #region StockItems
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.SupplierID];
                                p.StockItems = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(p.StockItems, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierNavProperty.StockItemTransactions:
                    #region StockItemTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.SupplierID.Value];
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
