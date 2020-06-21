/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{
    public static partial class CustomerTransactionUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction.
    /// </summary>
    public static partial class CustomerTransactionUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(CustomerTransaction one, CustomerTransaction two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.CustomerTransactionID != two.CustomerTransactionID)
                return true;
            if(one.CustomerID != two.CustomerID)
                return true;
            if(one.TransactionTypeID != two.TransactionTypeID)
                return true;
            if(one.InvoiceID != two.InvoiceID)
                return true;
            if(one.PaymentMethodID != two.PaymentMethodID)
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
        public static void Merge(CustomerTransaction source, CustomerTransaction target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.CustomerTransactionID = source.CustomerTransactionID;
            target.CustomerID = source.CustomerID;
            target.TransactionTypeID = source.TransactionTypeID;
            target.InvoiceID = source.InvoiceID;
            target.PaymentMethodID = source.PaymentMethodID;
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
        /// <returns>QueryFilters of CustomerTransactionProperty</returns>
        public static QueryFilters<CustomerTransactionProperty> GetChanges(CustomerTransaction original, CustomerTransaction changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<CustomerTransactionProperty>(14);
            #region Detect Changes
            if(original.CustomerTransactionID != changed.CustomerTransactionID)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.CustomerTransactionID, FilterConditions.Equals, changed.CustomerTransactionID));
            if(original.CustomerID != changed.CustomerID)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.CustomerID, FilterConditions.Equals, changed.CustomerID));
            if(original.TransactionTypeID != changed.TransactionTypeID)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.TransactionTypeID, FilterConditions.Equals, changed.TransactionTypeID));
            if(original.InvoiceID != changed.InvoiceID)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.InvoiceID, FilterConditions.Equals, changed.InvoiceID));
            if(original.PaymentMethodID != changed.PaymentMethodID)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.PaymentMethodID, FilterConditions.Equals, changed.PaymentMethodID));
            if(original.TransactionDate != changed.TransactionDate)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.TransactionDate, FilterConditions.Equals, changed.TransactionDate));
            if(original.AmountExcludingTax != changed.AmountExcludingTax)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.AmountExcludingTax, FilterConditions.Equals, changed.AmountExcludingTax));
            if(original.TaxAmount != changed.TaxAmount)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.TaxAmount, FilterConditions.Equals, changed.TaxAmount));
            if(original.TransactionAmount != changed.TransactionAmount)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.TransactionAmount, FilterConditions.Equals, changed.TransactionAmount));
            if(original.OutstandingBalance != changed.OutstandingBalance)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.OutstandingBalance, FilterConditions.Equals, changed.OutstandingBalance));
            if(original.FinalizationDate != changed.FinalizationDate)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.FinalizationDate, FilterConditions.Equals, changed.FinalizationDate));
            if(original.IsFinalized != changed.IsFinalized)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.IsFinalized, FilterConditions.Equals, changed.IsFinalized));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(CustomerTransactionProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
