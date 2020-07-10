/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{
    public static partial class SupplierTransactionUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction.
    /// </summary>
    public static partial class SupplierTransactionUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(SupplierTransaction one, SupplierTransaction two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.SupplierTransactionID != two.SupplierTransactionID)
                return true;
            if(one.SupplierID != two.SupplierID)
                return true;
            if(one.TransactionTypeID != two.TransactionTypeID)
                return true;
            if(one.PurchaseOrderID != two.PurchaseOrderID)
                return true;
            if(one.PaymentMethodID != two.PaymentMethodID)
                return true;
            if(string.CompareOrdinal(one.SupplierInvoiceNumber, two.SupplierInvoiceNumber) != 0)
                return true;
            if(one.TransactionDate != two.TransactionDate)
                return true;
            if(one.AmountExcludingTax != two.AmountExcludingTax)
                return true;
            if(one.TaxAmount != two.TaxAmount)
                return true;
            if(one.TransactionAmount != two.TransactionAmount)
                return true;
            if(one.OutstandingBalance != two.OutstandingBalance)
                return true;
            if(one.FinalizationDate != two.FinalizationDate)
                return true;
            if(one.IsFinalized != two.IsFinalized)
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
        public static void Merge(SupplierTransaction source, SupplierTransaction target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.SupplierTransactionID = source.SupplierTransactionID;
            target.SupplierID = source.SupplierID;
            target.TransactionTypeID = source.TransactionTypeID;
            target.PurchaseOrderID = source.PurchaseOrderID;
            target.PaymentMethodID = source.PaymentMethodID;
            target.SupplierInvoiceNumber = source.SupplierInvoiceNumber;
            target.TransactionDate = source.TransactionDate;
            target.AmountExcludingTax = source.AmountExcludingTax;
            target.TaxAmount = source.TaxAmount;
            target.TransactionAmount = source.TransactionAmount;
            target.OutstandingBalance = source.OutstandingBalance;
            target.FinalizationDate = source.FinalizationDate;
            target.IsFinalized = source.IsFinalized;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of SupplierTransactionProperty</returns>
        public static QueryFilters<SupplierTransactionProperty> GetChanges(SupplierTransaction original, SupplierTransaction changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<SupplierTransactionProperty>(15);
            #region Detect Changes
            if(original.SupplierTransactionID != changed.SupplierTransactionID)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.SupplierTransactionID, FilterConditions.Equals, changed.SupplierTransactionID));
            if(original.SupplierID != changed.SupplierID)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.SupplierID, FilterConditions.Equals, changed.SupplierID));
            if(original.TransactionTypeID != changed.TransactionTypeID)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.TransactionTypeID, FilterConditions.Equals, changed.TransactionTypeID));
            if(original.PurchaseOrderID != changed.PurchaseOrderID)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.PurchaseOrderID, FilterConditions.Equals, changed.PurchaseOrderID));
            if(original.PaymentMethodID != changed.PaymentMethodID)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.PaymentMethodID, FilterConditions.Equals, changed.PaymentMethodID));
            if(string.CompareOrdinal(original.SupplierInvoiceNumber, changed.SupplierInvoiceNumber) != 0)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.SupplierInvoiceNumber, FilterConditions.Equals, changed.SupplierInvoiceNumber));
            if(original.TransactionDate != changed.TransactionDate)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.TransactionDate, FilterConditions.Equals, changed.TransactionDate));
            if(original.AmountExcludingTax != changed.AmountExcludingTax)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.AmountExcludingTax, FilterConditions.Equals, changed.AmountExcludingTax));
            if(original.TaxAmount != changed.TaxAmount)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.TaxAmount, FilterConditions.Equals, changed.TaxAmount));
            if(original.TransactionAmount != changed.TransactionAmount)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.TransactionAmount, FilterConditions.Equals, changed.TransactionAmount));
            if(original.OutstandingBalance != changed.OutstandingBalance)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.OutstandingBalance, FilterConditions.Equals, changed.OutstandingBalance));
            if(original.FinalizationDate != changed.FinalizationDate)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.FinalizationDate, FilterConditions.Equals, changed.FinalizationDate));
            if(original.IsFinalized != changed.IsFinalized)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.IsFinalized, FilterConditions.Equals, changed.IsFinalized));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(SupplierTransactionProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
