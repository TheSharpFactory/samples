/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{
    public partial class PurchaseOrderLine
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
    public partial class PurchaseOrderLine
    {
        #region Simple Properties
        public int PurchaseOrderLineID { get; set; } 
        public int PurchaseOrderID { get; set; } 
        public int StockItemID { get; set; } 
        public int OrderedOuters { get; set; } 
        public string Description { get; set; } 
        public int ReceivedOuters { get; set; } 
        public int PackageTypeID { get; set; } 
        public decimal? ExpectedUnitPricePerOuter { get; set; } 
        public DateTime? LastReceiptDate { get; set; } 
        public bool IsOrderLineFinalized { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime LastEditedWhen { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property PackageTypeID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType PackageType { get; set; }
        /// <summary>
        /// Related to property PurchaseOrderID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder PurchaseOrder { get; set; }
        /// <summary>
        /// Related to property StockItemID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem StockItem { get; set; }
        #endregion
    }
}
