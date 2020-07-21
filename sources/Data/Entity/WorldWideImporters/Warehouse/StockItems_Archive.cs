/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{
    public partial class StockItems_Archive
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
    public partial class StockItems_Archive
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
    }
}
