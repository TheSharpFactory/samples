/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Sales
{
    public partial class Order
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
    public partial class Order
    {
        #region Simple Properties
        public int OrderID { get; set; } 
        public int CustomerID { get; set; } 
        public int SalespersonPersonID { get; set; } 
        public int? PickedByPersonID { get; set; } 
        public int ContactPersonID { get; set; } 
        public int? BackorderOrderID { get; set; } 
        public DateTime OrderDate { get; set; } 
        public DateTime ExpectedDeliveryDate { get; set; } 
        public string CustomerPurchaseOrderNumber { get; set; } 
        public bool IsUndersupplyBackordered { get; set; } 
        public string Comments { get; set; } 
        public string DeliveryInstructions { get; set; } 
        public string InternalComments { get; set; } 
        public DateTime? PickingCompletedWhen { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime LastEditedWhen { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property OrderID on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice> Invoices { get; set; }
        /// <summary>
        /// Related to property OrderID on Entity OrderLine
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine> OrderLines { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property BackorderOrderID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order Order1 { get; set; }
        /// <summary>
        /// Related to property ContactPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person1 { get; set; }
        /// <summary>
        /// Related to property CustomerID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer Customer { get; set; }
        /// <summary>
        /// Related to property PickedByPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person2 { get; set; }
        /// <summary>
        /// Related to property SalespersonPersonID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person3 { get; set; }
        #endregion
    }
}
