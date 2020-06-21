/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{
    public static partial class StockItemTransactionUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction.
    /// </summary>
    public static partial class StockItemTransactionUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(StockItemTransaction one, StockItemTransaction two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.StockItemTransactionID != two.StockItemTransactionID)
                return true;
            if(one.StockItemID != two.StockItemID)
                return true;
            if(one.TransactionTypeID != two.TransactionTypeID)
                return true;
            if(one.CustomerID != two.CustomerID)
                return true;
            if(one.InvoiceID != two.InvoiceID)
                return true;
            if(one.SupplierID != two.SupplierID)
                return true;
            if(one.PurchaseOrderID != two.PurchaseOrderID)
                return true;
            if(one.TransactionOccurredWhen != two.TransactionOccurredWhen)
                return true;
            if(one.Quantity != two.Quantity)
                return true;
            if(one.LastEditedBy != two.LastEditedBy)
                return true;
            if(one.LastEditedWhen != two.LastEditedWhen)
                return true;
            #endregion
            return false;
        }
        /// <summary>
        /// Merge all values from one Entity into another one.
        /// </summary>
        /// <param name="source">Source Entity. Will be copied to the target.</param>
        /// <param name="target">Target Entity. Will receive the values from the source.</param>
        /// <returns>void.</returns>
        public static void Merge(StockItemTransaction source, StockItemTransaction target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.StockItemTransactionID = source.StockItemTransactionID;
            target.StockItemID = source.StockItemID;
            target.TransactionTypeID = source.TransactionTypeID;
            target.CustomerID = source.CustomerID;
            target.InvoiceID = source.InvoiceID;
            target.SupplierID = source.SupplierID;
            target.PurchaseOrderID = source.PurchaseOrderID;
            target.TransactionOccurredWhen = source.TransactionOccurredWhen;
            target.Quantity = source.Quantity;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of StockItemTransactionProperty</returns>
        public static QueryFilters<StockItemTransactionProperty> GetChanges(StockItemTransaction original, StockItemTransaction changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<StockItemTransactionProperty>(11);
            #region Detect Changes
            if(original.StockItemTransactionID != changed.StockItemTransactionID)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.StockItemTransactionID, FilterConditions.Equals, changed.StockItemTransactionID));
            if(original.StockItemID != changed.StockItemID)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.StockItemID, FilterConditions.Equals, changed.StockItemID));
            if(original.TransactionTypeID != changed.TransactionTypeID)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.TransactionTypeID, FilterConditions.Equals, changed.TransactionTypeID));
            if(original.CustomerID != changed.CustomerID)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.CustomerID, FilterConditions.Equals, changed.CustomerID));
            if(original.InvoiceID != changed.InvoiceID)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.InvoiceID, FilterConditions.Equals, changed.InvoiceID));
            if(original.SupplierID != changed.SupplierID)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.SupplierID, FilterConditions.Equals, changed.SupplierID));
            if(original.PurchaseOrderID != changed.PurchaseOrderID)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.PurchaseOrderID, FilterConditions.Equals, changed.PurchaseOrderID));
            if(original.TransactionOccurredWhen != changed.TransactionOccurredWhen)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.TransactionOccurredWhen, FilterConditions.Equals, changed.TransactionOccurredWhen));
            if(original.Quantity != changed.Quantity)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.Quantity, FilterConditions.Equals, changed.Quantity));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(StockItemTransactionProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
