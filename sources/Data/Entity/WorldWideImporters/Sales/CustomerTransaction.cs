/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{
    public partial class CustomerTransaction
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
    public partial class CustomerTransaction
    {
        #region Simple Properties
        public int CustomerTransactionID { get; set; } 
        public int CustomerID { get; set; } 
        public int TransactionTypeID { get; set; } 
        public int? InvoiceID { get; set; } 
        public int? PaymentMethodID { get; set; } 
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
        /// Related to property CustomerID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer Customer { get; set; }
        /// <summary>
        /// Related to property InvoiceID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice Invoice { get; set; }
        /// <summary>
        /// Related to property PaymentMethodID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod PaymentMethod { get; set; }
        /// <summary>
        /// Related to property TransactionTypeID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType TransactionType { get; set; }
        #endregion
    }
}
