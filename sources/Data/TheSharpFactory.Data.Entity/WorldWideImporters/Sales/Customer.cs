/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{
    public partial class Customer
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class Customer
    {
        #region Simple Properties
        public int CustomerID { get; set; } 
        public string CustomerName { get; set; } 
        public int BillToCustomerID { get; set; } 
        public int CustomerCategoryID { get; set; } 
        public int? BuyingGroupID { get; set; } 
        public int PrimaryContactPersonID { get; set; } 
        public int? AlternateContactPersonID { get; set; } 
        public int DeliveryMethodID { get; set; } 
        public int DeliveryCityID { get; set; } 
        public int PostalCityID { get; set; } 
        public decimal? CreditLimit { get; set; } 
        public DateTime AccountOpenedDate { get; set; } 
        public decimal StandardDiscountPercentage { get; set; } 
        public bool IsStatementSent { get; set; } 
        public bool IsOnCreditHold { get; set; } 
        public int PaymentDays { get; set; } 
        public string PhoneNumber { get; set; } 
        public string FaxNumber { get; set; } 
        public string DeliveryRun { get; set; } 
        public string RunPosition { get; set; } 
        public string WebsiteURL { get; set; } 
        public string DeliveryAddressLine1 { get; set; } 
        public string DeliveryAddressLine2 { get; set; } 
        public string DeliveryPostalCode { get; set; } 
        public Microsoft.SqlServer.Types.SqlGeography DeliveryLocation { get; set; } 
        public string PostalAddressLine1 { get; set; } 
        public string PostalAddressLine2 { get; set; } 
        public string PostalPostalCode { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property AlternateContactPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person1 { get; set; }
        /// <summary>
        /// Related to property BillToCustomerID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer Customer1 { get; set; }
        /// <summary>
        /// Related to property BuyingGroupID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup BuyingGroup { get; set; }
        /// <summary>
        /// Related to property CustomerCategoryID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory CustomerCategory { get; set; }
        /// <summary>
        /// Related to property DeliveryCityID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.City City { get; set; }
        /// <summary>
        /// Related to property DeliveryMethodID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod DeliveryMethod { get; set; }
        /// <summary>
        /// Related to property PostalCityID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.City City1 { get; set; }
        /// <summary>
        /// Related to property PrimaryContactPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person2 { get; set; }
        /// <summary>
        /// Related to property CustomerID on Entity CustomerTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction> CustomerTransactions { get; set; }
        /// <summary>
        /// Related to property BillToCustomerID on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice> Invoices { get; set; }
        /// <summary>
        /// Related to property CustomerID on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice> Invoices1 { get; set; }
        /// <summary>
        /// Related to property CustomerID on Entity Order
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order> Orders { get; set; }
        /// <summary>
        /// Related to property CustomerID on Entity SpecialDeal
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal> SpecialDeals { get; set; }
        /// <summary>
        /// Related to property CustomerID on Entity StockItemTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction> StockItemTransactions { get; set; }
        #endregion
    }
}
