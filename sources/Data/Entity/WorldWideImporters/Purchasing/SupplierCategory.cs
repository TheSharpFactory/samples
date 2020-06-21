/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{
    public partial class SupplierCategory
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
    public partial class SupplierCategory
    {
        #region Simple Properties
        public int SupplierCategoryID { get; set; } 
        public string SupplierCategoryName { get; set; } 
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
        /// Related to property SupplierCategoryID on Entity Supplier
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier> Suppliers { get; set; }
        #endregion
    }
}
