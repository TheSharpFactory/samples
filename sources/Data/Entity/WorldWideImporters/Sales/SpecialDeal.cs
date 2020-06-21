/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{
    public partial class SpecialDeal
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
    public partial class SpecialDeal
    {
        #region Simple Properties
        public int SpecialDealID { get; set; } 
        public int? StockItemID { get; set; } 
        public int? CustomerID { get; set; } 
        public int? BuyingGroupID { get; set; } 
        public int? CustomerCategoryID { get; set; } 
        public int? StockGroupID { get; set; } 
        public string DealDescription { get; set; } 
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 
        public decimal? DiscountAmount { get; set; } 
        public decimal? DiscountPercentage { get; set; } 
        public decimal? UnitPrice { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime LastEditedWhen { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property BuyingGroupID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup BuyingGroup { get; set; }
        /// <summary>
        /// Related to property CustomerCategoryID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory CustomerCategory { get; set; }
        /// <summary>
        /// Related to property CustomerID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer Customer { get; set; }
        /// <summary>
        /// Related to property StockGroupID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup StockGroup { get; set; }
        /// <summary>
        /// Related to property StockItemID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem StockItem { get; set; }
        #endregion
    }
}
