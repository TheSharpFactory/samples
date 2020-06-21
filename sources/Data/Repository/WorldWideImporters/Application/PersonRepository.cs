/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class PersonRepository
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
    /// This class represents the Repository for: Person.
    /// </summary>
    public partial class PersonRepository:WritableRepositoryBase<Person, PersonProperty, PersonNavProperty>, IPersonRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<PersonNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<PersonNavProperty, NavPropertyInfo>(41){ { PersonNavProperty.Cities, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_City, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Application.CityProperty.LastEditedBy, },} } }, { PersonNavProperty.Countries, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Country, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Application.CountryProperty.LastEditedBy, },} } }, { PersonNavProperty.DeliveryMethods, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_DeliveryMethod, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.LastEditedBy, },} } }, { PersonNavProperty.PaymentMethods, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_PaymentMethod, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Application.PaymentMethodProperty.LastEditedBy, },} } }, { PersonNavProperty.Person1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { PersonNavProperty.StateProvinces, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_StateProvince, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Application.StateProvinceProperty.LastEditedBy, },} } }, { PersonNavProperty.SystemParameters, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_SystemParameter, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Application.SystemParameterProperty.LastEditedBy, },} } }, { PersonNavProperty.TransactionTypes, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_TransactionType, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Application.TransactionTypeProperty.LastEditedBy, },} } }, { PersonNavProperty.PurchaseOrderLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrderLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderLineProperty.LastEditedBy, },} } }, { PersonNavProperty.PurchaseOrders, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrder, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.LastEditedBy, },} } }, { PersonNavProperty.PurchaseOrders1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrder, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.ContactPersonID, },} } }, { PersonNavProperty.SupplierCategories, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierCategory, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierCategoryProperty.LastEditedBy, },} } }, { PersonNavProperty.Suppliers, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.AlternateContactPersonID, },} } }, { PersonNavProperty.Suppliers1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.LastEditedBy, },} } }, { PersonNavProperty.Suppliers2, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.PrimaryContactPersonID, },} } }, { PersonNavProperty.SupplierTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.LastEditedBy, },} } }, { PersonNavProperty.BuyingGroups, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_BuyingGroup, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.BuyingGroupProperty.LastEditedBy, },} } }, { PersonNavProperty.CustomerCategories, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerCategory, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerCategoryProperty.LastEditedBy, },} } }, { PersonNavProperty.Customers, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.AlternateContactPersonID, },} } }, { PersonNavProperty.Customers1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.LastEditedBy, },} } }, { PersonNavProperty.Customers2, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.PrimaryContactPersonID, },} } }, { PersonNavProperty.CustomerTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.LastEditedBy, },} } }, { PersonNavProperty.InvoiceLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_InvoiceLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceLineProperty.LastEditedBy, },} } }, { PersonNavProperty.Invoices, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.AccountsPersonID, },} } }, { PersonNavProperty.Invoices1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.LastEditedBy, },} } }, { PersonNavProperty.Invoices2, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.ContactPersonID, },} } }, { PersonNavProperty.Invoices3, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.PackedByPersonID, },} } }, { PersonNavProperty.Invoices4, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.SalespersonPersonID, },} } }, { PersonNavProperty.OrderLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_OrderLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.OrderLineProperty.LastEditedBy, },} } }, { PersonNavProperty.Orders, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Order, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.OrderProperty.LastEditedBy, },} } }, { PersonNavProperty.Orders1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Order, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.OrderProperty.ContactPersonID, },} } }, { PersonNavProperty.Orders2, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Order, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.OrderProperty.PickedByPersonID, },} } }, { PersonNavProperty.Orders3, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Order, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.OrderProperty.SalespersonPersonID, },} } }, { PersonNavProperty.SpecialDeals, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_SpecialDeal, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.LastEditedBy, },} } }, { PersonNavProperty.Colors, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_Color, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Warehouse.ColorProperty.LastEditedBy, },} } }, { PersonNavProperty.PackageTypes, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_PackageType, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.LastEditedBy, },} } }, { PersonNavProperty.StockGroups, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockGroup, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockGroupProperty.LastEditedBy, },} } }, { PersonNavProperty.StockItemHoldings, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemHolding, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemHoldingProperty.LastEditedBy, },} } }, { PersonNavProperty.StockItems, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.LastEditedBy, },} } }, { PersonNavProperty.StockItemStockGroups, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemStockGroup, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemStockGroupProperty.LastEditedBy, },} } }, { PersonNavProperty.StockItemTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.LastEditedBy, },} } },};
        #endregion
        #region Constructors
        public PersonRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Application_People) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<PersonProperty>(1){ SortFilter.New(PersonProperty.PersonID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person from the database by Primary Key.
        /// </summary>
        /// <param name="personid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person</returns>
        public Person ByPK(int personid)
        {
            var where = new QueryFilters<PersonProperty>(1){QueryFilter.New(PersonProperty.PersonID, FilterConditions.Equals, personid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="personid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person</returns>
        public Person ByPK(int personid, NavProps<PersonNavProperty> navprops)
        {
            var where = new QueryFilters<PersonProperty>(1){QueryFilter.New(PersonProperty.PersonID, FilterConditions.Equals, personid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person from the database by Primary Key.
        /// </summary>
        /// <param name="personid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int personid)
        {
            var where = new QueryFilters<PersonProperty>(1){QueryFilter.New(PersonProperty.PersonID, FilterConditions.Equals, personid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<PersonProperty> ComposeKeys(Person person)
        {
            return new QueryFilters<PersonProperty>{ QueryFilter.New(PersonProperty.PersonID, FilterConditions.Equals, person.PersonID) };
        }
        protected override QueryFilters<PersonProperty> GetChanges(Person original, Person changed)
        {
            return PersonUtils.GetChanges(original, changed);
        }
        protected override void Merge(Person source, Person target)
        {
            PersonUtils.Merge(source, target);
        }
        protected override QueryFilters<PersonProperty> ComposeInsertPredicate(Person person)
        {
            return new QueryFilters<PersonProperty>{ QueryFilter.New(PersonProperty.PersonID, FilterConditions.Equals, person.PersonID), QueryFilter.New(PersonProperty.FullName, FilterConditions.Equals, person.FullName), QueryFilter.New(PersonProperty.PreferredName, FilterConditions.Equals, person.PreferredName), QueryFilter.New(PersonProperty.IsPermittedToLogon, FilterConditions.Equals, person.IsPermittedToLogon), QueryFilter.New(PersonProperty.LogonName, FilterConditions.Equals, person.LogonName), QueryFilter.New(PersonProperty.IsExternalLogonProvider, FilterConditions.Equals, person.IsExternalLogonProvider), QueryFilter.New(PersonProperty.HashedPassword, FilterConditions.Equals, person.HashedPassword), QueryFilter.New(PersonProperty.IsSystemUser, FilterConditions.Equals, person.IsSystemUser), QueryFilter.New(PersonProperty.IsEmployee, FilterConditions.Equals, person.IsEmployee), QueryFilter.New(PersonProperty.IsSalesperson, FilterConditions.Equals, person.IsSalesperson), QueryFilter.New(PersonProperty.UserPreferences, FilterConditions.Equals, person.UserPreferences), QueryFilter.New(PersonProperty.PhoneNumber, FilterConditions.Equals, person.PhoneNumber), QueryFilter.New(PersonProperty.FaxNumber, FilterConditions.Equals, person.FaxNumber), QueryFilter.New(PersonProperty.EmailAddress, FilterConditions.Equals, person.EmailAddress), QueryFilter.New(PersonProperty.Photo, FilterConditions.Equals, person.Photo), QueryFilter.New(PersonProperty.CustomFields, FilterConditions.Equals, person.CustomFields), QueryFilter.New(PersonProperty.LastEditedBy, FilterConditions.Equals, person.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 21);
        }
        private static Person MaterializeSingleEntity(SqlDataReader r)
        {
            return new Person
            {
                PersonID = r.GetInt32(0),
                FullName = r.GetString(1),
                PreferredName = r.GetString(2),
                SearchName = r.GetString(3),
                IsPermittedToLogon = r.GetBoolean(4),
                LogonName = r.GetValue(5) as string,
                IsExternalLogonProvider = r.GetBoolean(6),
                HashedPassword = r.GetValue(7) as byte[],
                IsSystemUser = r.GetBoolean(8),
                IsEmployee = r.GetBoolean(9),
                IsSalesperson = r.GetBoolean(10),
                UserPreferences = r.GetValue(11) as string,
                PhoneNumber = r.GetValue(12) as string,
                FaxNumber = r.GetValue(13) as string,
                EmailAddress = r.GetValue(14) as string,
                Photo = r.GetValue(15) as byte[],
                CustomFields = r.GetValue(16) as string,
                OtherLanguages = r.GetValue(17) as string,
                LastEditedBy = r.GetInt32(18),
                ValidFrom = r.GetDateTime(19),
                ValidTo = r.GetDateTime(20),
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
                var np = (PersonNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case PersonNavProperty.Cities:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Countries:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CountryRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.DeliveryMethods:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.PaymentMethods:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Person1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.StateProvinces:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.SystemParameters:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.TransactionTypes:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.PurchaseOrderLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.PurchaseOrders:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.PurchaseOrders1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.SupplierCategories:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierCategoryRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Suppliers:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Suppliers1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Suppliers2:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.SupplierTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.BuyingGroups:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.CustomerCategories:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Customers:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Customers1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Customers2:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.CustomerTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.InvoiceLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Invoices:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Invoices1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Invoices2:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Invoices3:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Invoices4:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.OrderLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Orders:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Orders1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Orders2:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Orders3:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.SpecialDeals:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.Colors:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.ColorRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.PackageTypes:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.StockGroups:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.StockItemHoldings:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemHoldingRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.StockItems:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.StockItemStockGroups:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PersonNavProperty.StockItemTransactions:
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
                var np = (PersonNavProperty)p.Value;
                switch(np)
                {
                    case PersonNavProperty.Cities:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Countries:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CountryRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CountryRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.DeliveryMethods:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.PaymentMethods:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Person1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.StateProvinces:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.SystemParameters:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.TransactionTypes:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.PurchaseOrderLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.PurchaseOrders:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.PurchaseOrders1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.SupplierCategories:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierCategoryRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierCategoryRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Suppliers:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Suppliers1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Suppliers2:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.SupplierTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.BuyingGroups:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.CustomerCategories:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Customers:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Customers1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Customers2:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.CustomerTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.InvoiceLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Invoices:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Invoices1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Invoices2:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Invoices3:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Invoices4:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.OrderLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Orders:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Orders1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Orders2:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Orders3:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.SpecialDeals:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.Colors:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.ColorRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.ColorRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.PackageTypes:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.StockGroups:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.StockItemHoldings:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemHoldingRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemHoldingRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.StockItems:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.StockItemStockGroups:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PersonNavProperty.StockItemTransactions:
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
        protected override void BuildObjectGraph(List<Person> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Person> ComposeDictionaryByPK(List<Person> entities, MultiKeyDictionary<int, Person> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Person>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.PersonID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Person> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Person>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (PersonNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case PersonNavProperty.Cities:
                    #region Cities
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.Cities = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>(p.Cities, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Countries:
                    #region Countries
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.Countries = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country>(p.Countries, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CountryRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.DeliveryMethods:
                    #region DeliveryMethods
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.DeliveryMethods = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod>(p.DeliveryMethods, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.PaymentMethods:
                    #region PaymentMethods
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.PaymentMethods = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod>(p.PaymentMethods, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Person1:
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
                    case PersonNavProperty.StateProvinces:
                    #region StateProvinces
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.StateProvinces = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince>(p.StateProvinces, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.SystemParameters:
                    #region SystemParameters
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.SystemParameters = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter>(p.SystemParameters, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.TransactionTypes:
                    #region TransactionTypes
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.TransactionTypes = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType>(p.TransactionTypes, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.PurchaseOrderLines:
                    #region PurchaseOrderLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.PurchaseOrderLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine>(p.PurchaseOrderLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.PurchaseOrders:
                    #region PurchaseOrders
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.PurchaseOrders = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(p.PurchaseOrders, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.PurchaseOrders1:
                    #region PurchaseOrders1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.ContactPersonID];
                                p.PurchaseOrders1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(p.PurchaseOrders1, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.SupplierCategories:
                    #region SupplierCategories
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.SupplierCategories = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory>(p.SupplierCategories, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierCategoryRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Suppliers:
                    #region Suppliers
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.AlternateContactPersonID];
                                p.Suppliers = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(p.Suppliers, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Suppliers1:
                    #region Suppliers1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.Suppliers1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(p.Suppliers1, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Suppliers2:
                    #region Suppliers2
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PrimaryContactPersonID];
                                p.Suppliers2 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(p.Suppliers2, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.SupplierTransactions:
                    #region SupplierTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.SupplierTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(p.SupplierTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.BuyingGroups:
                    #region BuyingGroups
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.BuyingGroups = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup>(p.BuyingGroups, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.CustomerCategories:
                    #region CustomerCategories
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.CustomerCategories = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory>(p.CustomerCategories, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Customers:
                    #region Customers
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.AlternateContactPersonID.Value];
                                p.Customers = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(p.Customers, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Customers1:
                    #region Customers1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.Customers1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(p.Customers1, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Customers2:
                    #region Customers2
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PrimaryContactPersonID];
                                p.Customers2 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(p.Customers2, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.CustomerTransactions:
                    #region CustomerTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.CustomerTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(p.CustomerTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.InvoiceLines:
                    #region InvoiceLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.InvoiceLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine>(p.InvoiceLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Invoices:
                    #region Invoices
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.AccountsPersonID];
                                p.Invoices = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(p.Invoices, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Invoices1:
                    #region Invoices1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.Invoices1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(p.Invoices1, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Invoices2:
                    #region Invoices2
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.ContactPersonID];
                                p.Invoices2 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(p.Invoices2, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Invoices3:
                    #region Invoices3
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PackedByPersonID];
                                p.Invoices3 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(p.Invoices3, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Invoices4:
                    #region Invoices4
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.SalespersonPersonID];
                                p.Invoices4 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(p.Invoices4, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.OrderLines:
                    #region OrderLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.OrderLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine>(p.OrderLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Orders:
                    #region Orders
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.Orders = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(p.Orders, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Orders1:
                    #region Orders1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.ContactPersonID];
                                p.Orders1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(p.Orders1, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Orders2:
                    #region Orders2
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PickedByPersonID.Value];
                                p.Orders2 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(p.Orders2, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Orders3:
                    #region Orders3
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.SalespersonPersonID];
                                p.Orders3 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(p.Orders3, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.SpecialDeals:
                    #region SpecialDeals
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.SpecialDeals = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(p.SpecialDeals, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.Colors:
                    #region Colors
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.Colors = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color>(p.Colors, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.ColorRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.PackageTypes:
                    #region PackageTypes
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.PackageTypes = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType>(p.PackageTypes, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.StockGroups:
                    #region StockGroups
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.StockGroups = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup>(p.StockGroups, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.StockItemHoldings:
                    #region StockItemHoldings
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.StockItemHoldings = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding>(p.StockItemHoldings, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemHoldingRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.StockItems:
                    #region StockItems
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.StockItems = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(p.StockItems, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.StockItemStockGroups:
                    #region StockItemStockGroups
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
                                p.StockItemStockGroups = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup>(p.StockItemStockGroups, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PersonNavProperty.StockItemTransactions:
                    #region StockItemTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.LastEditedBy];
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
