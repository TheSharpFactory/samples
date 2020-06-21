/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class CustomerRepository
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
    /// This class represents the Repository for: Customer.
    /// </summary>
    public partial class CustomerRepository:WritableRepositoryBase<Customer, CustomerProperty, CustomerNavProperty>, ICustomerRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<CustomerNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<CustomerNavProperty, NavPropertyInfo>(15){ { CustomerNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.AlternateContactPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { CustomerNavProperty.Person1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { CustomerNavProperty.Customer1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.BillToCustomerID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, },} } }, { CustomerNavProperty.BuyingGroup, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_BuyingGroup, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.BuyingGroupID, OtherPropId = (int)WorldWideImportersE.Sales.BuyingGroupProperty.BuyingGroupID, },} } }, { CustomerNavProperty.CustomerCategory, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerCategory, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerCategoryID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerCategoryProperty.CustomerCategoryID, },} } }, { CustomerNavProperty.City, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_City, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.DeliveryCityID, OtherPropId = (int)WorldWideImportersE.Application.CityProperty.CityID, },} } }, { CustomerNavProperty.DeliveryMethod, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_DeliveryMethod, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.DeliveryMethodID, OtherPropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.DeliveryMethodID, },} } }, { CustomerNavProperty.City1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_City, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.PostalCityID, OtherPropId = (int)WorldWideImportersE.Application.CityProperty.CityID, },} } }, { CustomerNavProperty.Person2, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.PrimaryContactPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { CustomerNavProperty.CustomerTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.CustomerID, },} } }, { CustomerNavProperty.Invoices, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.BillToCustomerID, },} } }, { CustomerNavProperty.Invoices1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.CustomerID, },} } }, { CustomerNavProperty.Orders, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Order, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.OrderProperty.CustomerID, },} } }, { CustomerNavProperty.SpecialDeals, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_SpecialDeal, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.CustomerID, },} } }, { CustomerNavProperty.StockItemTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.CustomerID, },} } },};
        #endregion
        #region Constructors
        public CustomerRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Sales_Customers) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<CustomerProperty>(1){ SortFilter.New(CustomerProperty.CustomerID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Sales_Customers_CustomerName) sorting.
        private static readonly SortFilters<CustomerProperty> _sortBy_UQ_Sales_Customers_CustomerName = new SortFilters<CustomerProperty>(1){ SortFilter.New(CustomerProperty.CustomerName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Primary Key.
        /// </summary>
        /// <param name="customerid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        public Customer ByPK(int customerid)
        {
            var where = new QueryFilters<CustomerProperty>(1){QueryFilter.New(CustomerProperty.CustomerID, FilterConditions.Equals, customerid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="customerid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        public Customer ByPK(int customerid, NavProps<CustomerNavProperty> navprops)
        {
            var where = new QueryFilters<CustomerProperty>(1){QueryFilter.New(CustomerProperty.CustomerID, FilterConditions.Equals, customerid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Unique Key named UQ_Sales_Customers_CustomerName.
        /// </summary>
        /// <param name="customername">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        public Customer ByUK(string customername)
        {
            //this method uses the UniqueKey UQ_Sales_Customers_CustomerName
            var where = new QueryFilters<CustomerProperty>(1){QueryFilter.New(CustomerProperty.CustomerName, FilterConditions.Equals, customername ), };
            return SelectSingle(where, _sortBy_UQ_Sales_Customers_CustomerName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Unique Key named UQ_Sales_Customers_CustomerName. Supports navigation properties.
        /// </summary>
        /// <param name="customername">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        public Customer ByUK(string customername, NavProps<CustomerNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Sales_Customers_CustomerName
            var where = new QueryFilters<CustomerProperty>(1){QueryFilter.New(CustomerProperty.CustomerName, FilterConditions.Equals, customername ), };
            return SelectSingle(where, _sortBy_UQ_Sales_Customers_CustomerName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Primary Key.
        /// </summary>
        /// <param name="customerid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int customerid)
        {
            var where = new QueryFilters<CustomerProperty>(1){QueryFilter.New(CustomerProperty.CustomerID, FilterConditions.Equals, customerid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Unique Key named UQ_Sales_Customers_CustomerName
        /// </summary>
        /// <param name="customername">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string customername)
        {
            //this method uses the UniqueKey UQ_Sales_Customers_CustomerName
            var where = new QueryFilters<CustomerProperty>(1){QueryFilter.New(CustomerProperty.CustomerName, FilterConditions.Equals, customername), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<CustomerProperty> ComposeKeys(Customer customer)
        {
            return new QueryFilters<CustomerProperty>{ QueryFilter.New(CustomerProperty.CustomerID, FilterConditions.Equals, customer.CustomerID) };
        }
        protected override QueryFilters<CustomerProperty> GetChanges(Customer original, Customer changed)
        {
            return CustomerUtils.GetChanges(original, changed);
        }
        protected override void Merge(Customer source, Customer target)
        {
            CustomerUtils.Merge(source, target);
        }
        protected override QueryFilters<CustomerProperty> ComposeInsertPredicate(Customer customer)
        {
            return new QueryFilters<CustomerProperty>{ QueryFilter.New(CustomerProperty.CustomerID, FilterConditions.Equals, customer.CustomerID), QueryFilter.New(CustomerProperty.CustomerName, FilterConditions.Equals, customer.CustomerName), QueryFilter.New(CustomerProperty.BillToCustomerID, FilterConditions.Equals, customer.BillToCustomerID), QueryFilter.New(CustomerProperty.CustomerCategoryID, FilterConditions.Equals, customer.CustomerCategoryID), QueryFilter.New(CustomerProperty.BuyingGroupID, FilterConditions.Equals, customer.BuyingGroupID), QueryFilter.New(CustomerProperty.PrimaryContactPersonID, FilterConditions.Equals, customer.PrimaryContactPersonID), QueryFilter.New(CustomerProperty.AlternateContactPersonID, FilterConditions.Equals, customer.AlternateContactPersonID), QueryFilter.New(CustomerProperty.DeliveryMethodID, FilterConditions.Equals, customer.DeliveryMethodID), QueryFilter.New(CustomerProperty.DeliveryCityID, FilterConditions.Equals, customer.DeliveryCityID), QueryFilter.New(CustomerProperty.PostalCityID, FilterConditions.Equals, customer.PostalCityID), QueryFilter.New(CustomerProperty.CreditLimit, FilterConditions.Equals, customer.CreditLimit), QueryFilter.New(CustomerProperty.AccountOpenedDate, FilterConditions.Equals, customer.AccountOpenedDate), QueryFilter.New(CustomerProperty.StandardDiscountPercentage, FilterConditions.Equals, customer.StandardDiscountPercentage), QueryFilter.New(CustomerProperty.IsStatementSent, FilterConditions.Equals, customer.IsStatementSent), QueryFilter.New(CustomerProperty.IsOnCreditHold, FilterConditions.Equals, customer.IsOnCreditHold), QueryFilter.New(CustomerProperty.PaymentDays, FilterConditions.Equals, customer.PaymentDays), QueryFilter.New(CustomerProperty.PhoneNumber, FilterConditions.Equals, customer.PhoneNumber), QueryFilter.New(CustomerProperty.FaxNumber, FilterConditions.Equals, customer.FaxNumber), QueryFilter.New(CustomerProperty.DeliveryRun, FilterConditions.Equals, customer.DeliveryRun), QueryFilter.New(CustomerProperty.RunPosition, FilterConditions.Equals, customer.RunPosition), QueryFilter.New(CustomerProperty.WebsiteURL, FilterConditions.Equals, customer.WebsiteURL), QueryFilter.New(CustomerProperty.DeliveryAddressLine1, FilterConditions.Equals, customer.DeliveryAddressLine1), QueryFilter.New(CustomerProperty.DeliveryAddressLine2, FilterConditions.Equals, customer.DeliveryAddressLine2), QueryFilter.New(CustomerProperty.DeliveryPostalCode, FilterConditions.Equals, customer.DeliveryPostalCode), QueryFilter.New(CustomerProperty.DeliveryLocation, FilterConditions.Equals, customer.DeliveryLocation), QueryFilter.New(CustomerProperty.PostalAddressLine1, FilterConditions.Equals, customer.PostalAddressLine1), QueryFilter.New(CustomerProperty.PostalAddressLine2, FilterConditions.Equals, customer.PostalAddressLine2), QueryFilter.New(CustomerProperty.PostalPostalCode, FilterConditions.Equals, customer.PostalPostalCode), QueryFilter.New(CustomerProperty.LastEditedBy, FilterConditions.Equals, customer.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 31);
        }
        private static Customer MaterializeSingleEntity(SqlDataReader r)
        {
            return new Customer
            {
                CustomerID = r.GetInt32(0),
                CustomerName = r.GetString(1),
                BillToCustomerID = r.GetInt32(2),
                CustomerCategoryID = r.GetInt32(3),
                BuyingGroupID = r.GetValue(4) as int?,
                PrimaryContactPersonID = r.GetInt32(5),
                AlternateContactPersonID = r.GetValue(6) as int?,
                DeliveryMethodID = r.GetInt32(7),
                DeliveryCityID = r.GetInt32(8),
                PostalCityID = r.GetInt32(9),
                CreditLimit = r.GetValue(10) as decimal?,
                AccountOpenedDate = r.GetDateTime(11),
                StandardDiscountPercentage = r.GetDecimal(12),
                IsStatementSent = r.GetBoolean(13),
                IsOnCreditHold = r.GetBoolean(14),
                PaymentDays = r.GetInt32(15),
                PhoneNumber = r.GetString(16),
                FaxNumber = r.GetString(17),
                DeliveryRun = r.GetValue(18) as string,
                RunPosition = r.GetValue(19) as string,
                WebsiteURL = r.GetString(20),
                DeliveryAddressLine1 = r.GetString(21),
                DeliveryAddressLine2 = r.GetValue(22) as string,
                DeliveryPostalCode = r.GetString(23),
                DeliveryLocation = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(24)),
                PostalAddressLine1 = r.GetString(25),
                PostalAddressLine2 = r.GetValue(26) as string,
                PostalPostalCode = r.GetString(27),
                LastEditedBy = r.GetInt32(28),
                ValidFrom = r.GetDateTime(29),
                ValidTo = r.GetDateTime(30),
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
                var np = (CustomerNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case CustomerNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.Person1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.Customer1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.BuyingGroup:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.CustomerCategory:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.City:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.DeliveryMethod:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.City1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.Person2:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.CustomerTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.Invoices:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.Invoices1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.Orders:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.SpecialDeals:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.StockItemTransactions:
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
                var np = (CustomerNavProperty)p.Value;
                switch(np)
                {
                    case CustomerNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.Person1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.Customer1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.BuyingGroup:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.CustomerCategory:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.City:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.DeliveryMethod:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.City1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.Person2:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.CustomerTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.Invoices:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.Invoices1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.Orders:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.SpecialDeals:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.StockItemTransactions:
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
        protected override void BuildObjectGraph(List<Customer> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Customer> ComposeDictionaryByPK(List<Customer> entities, MultiKeyDictionary<int, Customer> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Customer>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.CustomerID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Customer> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Customer>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (CustomerNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case CustomerNavProperty.Person:
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
                                if(!c.AlternateContactPersonID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.AlternateContactPersonID.Value))
                                    c.Person = navByKey[c.AlternateContactPersonID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.Person1:
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
                    case CustomerNavProperty.Customer1:
                    #region Customer1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>();
                            foreach(var p in list)
                                navByKey.Add(p.CustomerID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.BillToCustomerID))
                                    c.Customer1 = navByKey[c.BillToCustomerID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.BuyingGroup:
                    #region BuyingGroup
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup>();
                            foreach(var p in list)
                                navByKey.Add(p.BuyingGroupID, p);
                            foreach(var c in entities)
                            {
                                if(!c.BuyingGroupID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.BuyingGroupID.Value))
                                    c.BuyingGroup = navByKey[c.BuyingGroupID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.CustomerCategory:
                    #region CustomerCategory
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory>();
                            foreach(var p in list)
                                navByKey.Add(p.CustomerCategoryID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.CustomerCategoryID))
                                    c.CustomerCategory = navByKey[c.CustomerCategoryID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.City:
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
                    case CustomerNavProperty.DeliveryMethod:
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
                    case CustomerNavProperty.City1:
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
                    case CustomerNavProperty.Person2:
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
                    case CustomerNavProperty.CustomerTransactions:
                    #region CustomerTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.CustomerID];
                                p.CustomerTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(p.CustomerTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.Invoices:
                    #region Invoices
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.BillToCustomerID];
                                p.Invoices = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(p.Invoices, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.Invoices1:
                    #region Invoices1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.CustomerID];
                                p.Invoices1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(p.Invoices1, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.Orders:
                    #region Orders
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.CustomerID];
                                p.Orders = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(p.Orders, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.SpecialDeals:
                    #region SpecialDeals
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.CustomerID.Value];
                                p.SpecialDeals = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(p.SpecialDeals, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.StockItemTransactions:
                    #region StockItemTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.CustomerID.Value];
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
