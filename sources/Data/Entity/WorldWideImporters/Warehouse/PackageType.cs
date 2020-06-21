/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{
    public partial class PackageType
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class PackageType
    {
        #region Simple Properties
        public int PackageTypeID { get; set; } 
        public string PackageTypeName { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property PackageTypeID on Entity PurchaseOrderLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine> PurchaseOrderLines { get; set; }
        /// <summary>
        /// Related to property PackageTypeID on Entity InvoiceLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine> InvoiceLines { get; set; }
        /// <summary>
        /// Related to property PackageTypeID on Entity OrderLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine> OrderLines { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property OuterPackageID on Entity StockItem
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem> StockItems { get; set; }
        /// <summary>
        /// Related to property UnitPackageID on Entity StockItem
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem> StockItems1 { get; set; }
        #endregion
    }
}
