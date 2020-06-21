/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{
    public partial class CustomerCategory
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
    public partial class CustomerCategory
    {
        #region Simple Properties
        public int CustomerCategoryID { get; set; } 
        public string CustomerCategoryName { get; set; } 
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
        /// Related to property CustomerCategoryID on Entity Customer
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer> Customers { get; set; }
        /// <summary>
        /// Related to property CustomerCategoryID on Entity SpecialDeal
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal> SpecialDeals { get; set; }
        #endregion
    }
}
