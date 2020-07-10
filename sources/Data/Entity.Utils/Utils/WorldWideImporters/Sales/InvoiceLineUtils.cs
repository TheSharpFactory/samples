/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{
    public static partial class InvoiceLineUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine.
    /// </summary>
    public static partial class InvoiceLineUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(InvoiceLine one, InvoiceLine two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.InvoiceLineID != two.InvoiceLineID)
                return true;
            if(one.InvoiceID != two.InvoiceID)
                return true;
            if(one.StockItemID != two.StockItemID)
                return true;
            if(string.CompareOrdinal(one.Description, two.Description) != 0)
                return true;
            if(one.PackageTypeID != two.PackageTypeID)
                return true;
            if(one.Quantity != two.Quantity)
                return true;
            if(one.UnitPrice != two.UnitPrice)
                return true;
            if(one.TaxRate != two.TaxRate)
                return true;
            if(one.TaxAmount != two.TaxAmount)
                return true;
            if(one.LineProfit != two.LineProfit)
                return true;
            if(one.ExtendedPrice != two.ExtendedPrice)
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
        public static void Merge(InvoiceLine source, InvoiceLine target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.InvoiceLineID = source.InvoiceLineID;
            target.InvoiceID = source.InvoiceID;
            target.StockItemID = source.StockItemID;
            target.Description = source.Description;
            target.PackageTypeID = source.PackageTypeID;
            target.Quantity = source.Quantity;
            target.UnitPrice = source.UnitPrice;
            target.TaxRate = source.TaxRate;
            target.TaxAmount = source.TaxAmount;
            target.LineProfit = source.LineProfit;
            target.ExtendedPrice = source.ExtendedPrice;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of InvoiceLineProperty</returns>
        public static QueryFilters<InvoiceLineProperty> GetChanges(InvoiceLine original, InvoiceLine changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<InvoiceLineProperty>(13);
            #region Detect Changes
            if(original.InvoiceLineID != changed.InvoiceLineID)
                changes.Add(QueryFilter.New(InvoiceLineProperty.InvoiceLineID, FilterConditions.Equals, changed.InvoiceLineID));
            if(original.InvoiceID != changed.InvoiceID)
                changes.Add(QueryFilter.New(InvoiceLineProperty.InvoiceID, FilterConditions.Equals, changed.InvoiceID));
            if(original.StockItemID != changed.StockItemID)
                changes.Add(QueryFilter.New(InvoiceLineProperty.StockItemID, FilterConditions.Equals, changed.StockItemID));
            if(string.CompareOrdinal(original.Description, changed.Description) != 0)
                changes.Add(QueryFilter.New(InvoiceLineProperty.Description, FilterConditions.Equals, changed.Description));
            if(original.PackageTypeID != changed.PackageTypeID)
                changes.Add(QueryFilter.New(InvoiceLineProperty.PackageTypeID, FilterConditions.Equals, changed.PackageTypeID));
            if(original.Quantity != changed.Quantity)
                changes.Add(QueryFilter.New(InvoiceLineProperty.Quantity, FilterConditions.Equals, changed.Quantity));
            if(original.UnitPrice != changed.UnitPrice)
                changes.Add(QueryFilter.New(InvoiceLineProperty.UnitPrice, FilterConditions.Equals, changed.UnitPrice));
            if(original.TaxRate != changed.TaxRate)
                changes.Add(QueryFilter.New(InvoiceLineProperty.TaxRate, FilterConditions.Equals, changed.TaxRate));
            if(original.TaxAmount != changed.TaxAmount)
                changes.Add(QueryFilter.New(InvoiceLineProperty.TaxAmount, FilterConditions.Equals, changed.TaxAmount));
            if(original.LineProfit != changed.LineProfit)
                changes.Add(QueryFilter.New(InvoiceLineProperty.LineProfit, FilterConditions.Equals, changed.LineProfit));
            if(original.ExtendedPrice != changed.ExtendedPrice)
                changes.Add(QueryFilter.New(InvoiceLineProperty.ExtendedPrice, FilterConditions.Equals, changed.ExtendedPrice));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(InvoiceLineProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(InvoiceLineProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
