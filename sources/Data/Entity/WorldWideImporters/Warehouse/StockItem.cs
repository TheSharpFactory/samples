/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{
    public partial class StockItem
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
    public partial class StockItem
    {
        #region Simple Properties
        public int StockItemID { get; set; } 
        public string StockItemName { get; set; } 
        public int SupplierID { get; set; } 
        public int? ColorID { get; set; } 
        public int UnitPackageID { get; set; } 
        public int OuterPackageID { get; set; } 
        public string Brand { get; set; } 
        public string Size { get; set; } 
        public int LeadTimeDays { get; set; } 
        public int QuantityPerOuter { get; set; } 
        public bool IsChillerStock { get; set; } 
        public string Barcode { get; set; } 
        public decimal TaxRate { get; set; } 
        public decimal UnitPrice { get; set; } 
        public decimal? RecommendedRetailPrice { get; set; } 
        public decimal TypicalWeightPerUnit { get; set; } 
        public string MarketingComments { get; set; } 
        public string InternalComments { get; set; } 
        public byte[] Photo { get; set; } 
        public string CustomFields { get; set; } 
        public string Tags { get; set; } 
        public string SearchDetails { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property StockItemID on Entity PurchaseOrderLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine> PurchaseOrderLines { get; set; }
        /// <summary>
        /// Related to property StockItemID on Entity InvoiceLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine> InvoiceLines { get; set; }
        /// <summary>
        /// Related to property StockItemID on Entity OrderLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine> OrderLines { get; set; }
        /// <summary>
        /// Related to property StockItemID on Entity SpecialDeal
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal> SpecialDeals { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property ColorID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color Color { get; set; }
        /// <summary>
        /// Related to property OuterPackageID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType PackageType { get; set; }
        /// <summary>
        /// Related to property SupplierID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier Supplier { get; set; }
        /// <summary>
        /// Related to property UnitPackageID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType PackageType1 { get; set; }
        /// <summary>
        /// Related to property StockItemID on Entity StockItemStockGroup
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup> StockItemStockGroups { get; set; }
        /// <summary>
        /// Related to property StockItemID on Entity StockItemTransaction
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction> StockItemTransactions { get; set; }
        /// <summary>
        /// Related to property StockItemID on Entity StockItemHolding
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding StockItemHolding { get; set; }
        #endregion
    }
}
