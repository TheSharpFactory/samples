/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{
    public partial class TransactionType
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
    public partial class TransactionType
    {
        #region Simple Properties
        public int TransactionTypeID { get; set; } 
        public string TransactionTypeName { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property TransactionTypeID on Entity SupplierTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction> SupplierTransactions { get; set; }
        /// <summary>
        /// Related to property TransactionTypeID on Entity CustomerTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction> CustomerTransactions { get; set; }
        /// <summary>
        /// Related to property TransactionTypeID on Entity StockItemTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction> StockItemTransactions { get; set; }
        #endregion
    }
}
