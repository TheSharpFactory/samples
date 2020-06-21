/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{
    public partial class Invoice
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
    public partial class Invoice
    {
        #region Simple Properties
        public int InvoiceID { get; set; } 
        public int CustomerID { get; set; } 
        public int BillToCustomerID { get; set; } 
        public int? OrderID { get; set; } 
        public int DeliveryMethodID { get; set; } 
        public int ContactPersonID { get; set; } 
        public int AccountsPersonID { get; set; } 
        public int SalespersonPersonID { get; set; } 
        public int PackedByPersonID { get; set; } 
        public DateTime InvoiceDate { get; set; } 
        public string CustomerPurchaseOrderNumber { get; set; } 
        public bool IsCreditNote { get; set; } 
        public string CreditNoteReason { get; set; } 
        public string Comments { get; set; } 
        public string DeliveryInstructions { get; set; } 
        public string InternalComments { get; set; } 
        public int TotalDryItems { get; set; } 
        public int TotalChillerItems { get; set; } 
        public string DeliveryRun { get; set; } 
        public string RunPosition { get; set; } 
        public string ReturnedDeliveryData { get; set; } 
        public DateTime? ConfirmedDeliveryTime { get; set; } 
        public string ConfirmedReceivedBy { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime LastEditedWhen { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property InvoiceID on Entity CustomerTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction> CustomerTransactions { get; set; }
        /// <summary>
        /// Related to property InvoiceID on Entity InvoiceLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine> InvoiceLines { get; set; }
        /// <summary>
        /// Related to property AccountsPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person1 { get; set; }
        /// <summary>
        /// Related to property BillToCustomerID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer Customer { get; set; }
        /// <summary>
        /// Related to property ContactPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person2 { get; set; }
        /// <summary>
        /// Related to property CustomerID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer Customer1 { get; set; }
        /// <summary>
        /// Related to property DeliveryMethodID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod DeliveryMethod { get; set; }
        /// <summary>
        /// Related to property OrderID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order Order { get; set; }
        /// <summary>
        /// Related to property PackedByPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person3 { get; set; }
        /// <summary>
        /// Related to property SalespersonPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person4 { get; set; }
        /// <summary>
        /// Related to property InvoiceID on Entity StockItemTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction> StockItemTransactions { get; set; }
        #endregion
    }
}
