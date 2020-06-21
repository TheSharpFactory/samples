/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{
    public partial class Supplier
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class Supplier
    {
        #region Simple Properties
        public int SupplierID { get; set; } 
        public string SupplierName { get; set; } 
        public int SupplierCategoryID { get; set; } 
        public int PrimaryContactPersonID { get; set; } 
        public int AlternateContactPersonID { get; set; } 
        public int? DeliveryMethodID { get; set; } 
        public int DeliveryCityID { get; set; } 
        public int PostalCityID { get; set; } 
        public string SupplierReference { get; set; } 
        public string BankAccountName { get; set; } 
        public string BankAccountBranch { get; set; } 
        public string BankAccountCode { get; set; } 
        public string BankAccountNumber { get; set; } 
        public string BankInternationalCode { get; set; } 
        public int PaymentDays { get; set; } 
        public string InternalComments { get; set; } 
        public string PhoneNumber { get; set; } 
        public string FaxNumber { get; set; } 
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
        /// Related to property SupplierID on Entity PurchaseOrder
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder> PurchaseOrders { get; set; }
        /// <summary>
        /// Related to property AlternateContactPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person1 { get; set; }
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
        /// Related to property SupplierCategoryID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory SupplierCategory { get; set; }
        /// <summary>
        /// Related to property SupplierID on Entity SupplierTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction> SupplierTransactions { get; set; }
        /// <summary>
        /// Related to property SupplierID on Entity StockItem
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem> StockItems { get; set; }
        /// <summary>
        /// Related to property SupplierID on Entity StockItemTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction> StockItemTransactions { get; set; }
        #endregion
    }
}
