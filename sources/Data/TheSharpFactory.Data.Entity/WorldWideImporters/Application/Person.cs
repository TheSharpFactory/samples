/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{
    public partial class Person
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class Person
    {
        #region Simple Properties
        public int PersonID { get; set; } 
        public string FullName { get; set; } 
        public string PreferredName { get; set; } 
        public string SearchName { get; set; } 
        public bool IsPermittedToLogon { get; set; } 
        public string LogonName { get; set; } 
        public bool IsExternalLogonProvider { get; set; } 
        public byte[] HashedPassword { get; set; } 
        public bool IsSystemUser { get; set; } 
        public bool IsEmployee { get; set; } 
        public bool IsSalesperson { get; set; } 
        public string UserPreferences { get; set; } 
        public string PhoneNumber { get; set; } 
        public string FaxNumber { get; set; } 
        public string EmailAddress { get; set; } 
        public byte[] Photo { get; set; } 
        public string CustomFields { get; set; } 
        public string OtherLanguages { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on Entity City
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City> Cities { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity Country
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country> Countries { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity DeliveryMethod
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod> DeliveryMethods { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity PaymentMethod
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod> PaymentMethods { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person1 { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity StateProvince
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince> StateProvinces { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity SystemParameter
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter> SystemParameters { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity TransactionType
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType> TransactionTypes { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity PurchaseOrderLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine> PurchaseOrderLines { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity PurchaseOrder
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder> PurchaseOrders { get; set; }
        /// <summary>
        /// Related to property ContactPersonID on Entity PurchaseOrder
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder> PurchaseOrders1 { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity SupplierCategory
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory> SupplierCategories { get; set; }
        /// <summary>
        /// Related to property AlternateContactPersonID on Entity Supplier
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier> Suppliers { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity Supplier
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier> Suppliers1 { get; set; }
        /// <summary>
        /// Related to property PrimaryContactPersonID on Entity Supplier
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier> Suppliers2 { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity SupplierTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction> SupplierTransactions { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity BuyingGroup
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup> BuyingGroups { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity CustomerCategory
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory> CustomerCategories { get; set; }
        /// <summary>
        /// Related to property AlternateContactPersonID on Entity Customer
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer> Customers { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity Customer
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer> Customers1 { get; set; }
        /// <summary>
        /// Related to property PrimaryContactPersonID on Entity Customer
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer> Customers2 { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity CustomerTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction> CustomerTransactions { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity InvoiceLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine> InvoiceLines { get; set; }
        /// <summary>
        /// Related to property AccountsPersonID on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice> Invoices { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice> Invoices1 { get; set; }
        /// <summary>
        /// Related to property ContactPersonID on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice> Invoices2 { get; set; }
        /// <summary>
        /// Related to property PackedByPersonID on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice> Invoices3 { get; set; }
        /// <summary>
        /// Related to property SalespersonPersonID on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice> Invoices4 { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity OrderLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine> OrderLines { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity Order
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order> Orders { get; set; }
        /// <summary>
        /// Related to property ContactPersonID on Entity Order
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order> Orders1 { get; set; }
        /// <summary>
        /// Related to property PickedByPersonID on Entity Order
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order> Orders2 { get; set; }
        /// <summary>
        /// Related to property SalespersonPersonID on Entity Order
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order> Orders3 { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity SpecialDeal
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal> SpecialDeals { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity Color
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color> Colors { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity PackageType
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType> PackageTypes { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity StockGroup
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup> StockGroups { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity StockItemHolding
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding> StockItemHoldings { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity StockItem
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem> StockItems { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity StockItemStockGroup
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup> StockItemStockGroups { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on Entity StockItemTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction> StockItemTransactions { get; set; }
        #endregion
    }
}
