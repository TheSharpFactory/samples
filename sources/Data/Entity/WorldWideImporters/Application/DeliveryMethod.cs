/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{
    public partial class DeliveryMethod
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
    public partial class DeliveryMethod
    {
        #region Simple Properties
        public int DeliveryMethodID { get; set; } 
        public string DeliveryMethodName { get; set; } 
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
        /// Related to property DeliveryMethodID on Entity PurchaseOrder
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder> PurchaseOrders { get; set; }
        /// <summary>
        /// Related to property DeliveryMethodID on Entity Supplier
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier> Suppliers { get; set; }
        /// <summary>
        /// Related to property DeliveryMethodID on Entity Customer
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer> Customers { get; set; }
        /// <summary>
        /// Related to property DeliveryMethodID on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice> Invoices { get; set; }
        #endregion
    }
}
