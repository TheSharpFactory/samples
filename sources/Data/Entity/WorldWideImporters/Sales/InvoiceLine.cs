/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{
    public partial class InvoiceLine
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
    public partial class InvoiceLine
    {
        #region Simple Properties
        public int InvoiceLineID { get; set; } 
        public int InvoiceID { get; set; } 
        public int StockItemID { get; set; } 
        public string Description { get; set; } 
        public int PackageTypeID { get; set; } 
        public int Quantity { get; set; } 
        public decimal? UnitPrice { get; set; } 
        public decimal TaxRate { get; set; } 
        public decimal TaxAmount { get; set; } 
        public decimal LineProfit { get; set; } 
        public decimal ExtendedPrice { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime LastEditedWhen { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property InvoiceID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice Invoice { get; set; }
        /// <summary>
        /// Related to property PackageTypeID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType PackageType { get; set; }
        /// <summary>
        /// Related to property StockItemID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem StockItem { get; set; }
        #endregion
    }
}
