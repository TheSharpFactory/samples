/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{
    public partial class StockItemTransaction
    {
    }
}

************************************************/

using System;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class StockItemTransaction
    {
        #region Simple Properties
        public int StockItemTransactionID { get; set; } 
        public int StockItemID { get; set; } 
        public int TransactionTypeID { get; set; } 
        public int? CustomerID { get; set; } 
        public int? InvoiceID { get; set; } 
        public int? SupplierID { get; set; } 
        public int? PurchaseOrderID { get; set; } 
        public DateTime TransactionOccurredWhen { get; set; } 
        public decimal Quantity { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime LastEditedWhen { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property CustomerID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer Customer { get; set; }
        /// <summary>
        /// Related to property InvoiceID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice Invoice { get; set; }
        /// <summary>
        /// Related to property PurchaseOrderID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder PurchaseOrder { get; set; }
        /// <summary>
        /// Related to property StockItemID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem StockItem { get; set; }
        /// <summary>
        /// Related to property SupplierID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier Supplier { get; set; }
        /// <summary>
        /// Related to property TransactionTypeID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType TransactionType { get; set; }
        #endregion
    }
}
