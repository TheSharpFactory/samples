/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This enum represents the existing Navigation Properties for a DTO.
    /// </summary>
    public enum PurchaseOrderNavProperty
    {
        /// <summary>
        /// Related to property PurchaseOrderID on Entity PurchaseOrderLine
        /// </summary>
        PurchaseOrderLines, 
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        Person, 
        /// <summary>
        /// Related to property ContactPersonID on this entity
        /// </summary>
        Person1, 
        /// <summary>
        /// Related to property DeliveryMethodID on this entity
        /// </summary>
        DeliveryMethod, 
        /// <summary>
        /// Related to property SupplierID on this entity
        /// </summary>
        Supplier, 
        /// <summary>
        /// Related to property PurchaseOrderID on Entity SupplierTransaction
        /// </summary>
        SupplierTransactions, 
        /// <summary>
        /// Related to property PurchaseOrderID on Entity StockItemTransaction
        /// </summary>
        StockItemTransactions, 
    }
}
