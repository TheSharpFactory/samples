/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{
    public partial class SupplierTransaction
    {
    }
}

************************************************/

using System;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class SupplierTransaction
    {
        #region Simple Properties
        public int SupplierTransactionID { get; set; } 
        public int SupplierID { get; set; } 
        public int TransactionTypeID { get; set; } 
        public int? PurchaseOrderID { get; set; } 
        public int? PaymentMethodID { get; set; } 
        public string SupplierInvoiceNumber { get; set; } 
        public DateTime TransactionDate { get; set; } 
        public decimal AmountExcludingTax { get; set; } 
        public decimal TaxAmount { get; set; } 
        public decimal TransactionAmount { get; set; } 
        public decimal OutstandingBalance { get; set; } 
        public DateTime? FinalizationDate { get; set; } 
        public bool? IsFinalized { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime LastEditedWhen { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property PaymentMethodID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod PaymentMethod { get; set; }
        /// <summary>
        /// Related to property PurchaseOrderID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder PurchaseOrder { get; set; }
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
