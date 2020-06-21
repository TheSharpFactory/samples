/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{
    public partial class PurchaseOrder
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
    public partial class PurchaseOrder
    {
        #region Simple Properties
        public int PurchaseOrderID { get; set; } 
        public int SupplierID { get; set; } 
        public DateTime OrderDate { get; set; } 
        public int DeliveryMethodID { get; set; } 
        public int ContactPersonID { get; set; } 
        public DateTime? ExpectedDeliveryDate { get; set; } 
        public string SupplierReference { get; set; } 
        public bool IsOrderFinalized { get; set; } 
        public string Comments { get; set; } 
        public string InternalComments { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime LastEditedWhen { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property PurchaseOrderID on Entity PurchaseOrderLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine> PurchaseOrderLines { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property ContactPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person1 { get; set; }
        /// <summary>
        /// Related to property DeliveryMethodID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod DeliveryMethod { get; set; }
        /// <summary>
        /// Related to property SupplierID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier Supplier { get; set; }
        /// <summary>
        /// Related to property PurchaseOrderID on Entity SupplierTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction> SupplierTransactions { get; set; }
        /// <summary>
        /// Related to property PurchaseOrderID on Entity StockItemTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction> StockItemTransactions { get; set; }
        #endregion
    }
}
