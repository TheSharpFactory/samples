/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{
    public static partial class PurchaseOrderLineUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine.
    /// </summary>
    public static partial class PurchaseOrderLineUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(PurchaseOrderLine one, PurchaseOrderLine two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.PurchaseOrderLineID != two.PurchaseOrderLineID)
                return true;
            if(one.PurchaseOrderID != two.PurchaseOrderID)
                return true;
            if(one.StockItemID != two.StockItemID)
                return true;
            if(one.OrderedOuters != two.OrderedOuters)
                return true;
            if(string.CompareOrdinal(one.Description, two.Description) != 0)
                return true;
            if(one.ReceivedOuters != two.ReceivedOuters)
                return true;
            if(one.PackageTypeID != two.PackageTypeID)
                return true;
            if(one.ExpectedUnitPricePerOuter != two.ExpectedUnitPricePerOuter)
                return true;
            if(one.LastReceiptDate != two.LastReceiptDate)
                return true;
            if(one.IsOrderLineFinalized != two.IsOrderLineFinalized)
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
        public static void Merge(PurchaseOrderLine source, PurchaseOrderLine target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.PurchaseOrderLineID = source.PurchaseOrderLineID;
            target.PurchaseOrderID = source.PurchaseOrderID;
            target.StockItemID = source.StockItemID;
            target.OrderedOuters = source.OrderedOuters;
            target.Description = source.Description;
            target.ReceivedOuters = source.ReceivedOuters;
            target.PackageTypeID = source.PackageTypeID;
            target.ExpectedUnitPricePerOuter = source.ExpectedUnitPricePerOuter;
            target.LastReceiptDate = source.LastReceiptDate;
            target.IsOrderLineFinalized = source.IsOrderLineFinalized;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of PurchaseOrderLineProperty</returns>
        public static QueryFilters<PurchaseOrderLineProperty> GetChanges(PurchaseOrderLine original, PurchaseOrderLine changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<PurchaseOrderLineProperty>(12);
            #region Detect Changes
            if(original.PurchaseOrderLineID != changed.PurchaseOrderLineID)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.PurchaseOrderLineID, FilterConditions.Equals, changed.PurchaseOrderLineID));
            if(original.PurchaseOrderID != changed.PurchaseOrderID)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.PurchaseOrderID, FilterConditions.Equals, changed.PurchaseOrderID));
            if(original.StockItemID != changed.StockItemID)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.StockItemID, FilterConditions.Equals, changed.StockItemID));
            if(original.OrderedOuters != changed.OrderedOuters)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.OrderedOuters, FilterConditions.Equals, changed.OrderedOuters));
            if(string.CompareOrdinal(original.Description, changed.Description) != 0)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.Description, FilterConditions.Equals, changed.Description));
            if(original.ReceivedOuters != changed.ReceivedOuters)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.ReceivedOuters, FilterConditions.Equals, changed.ReceivedOuters));
            if(original.PackageTypeID != changed.PackageTypeID)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.PackageTypeID, FilterConditions.Equals, changed.PackageTypeID));
            if(original.ExpectedUnitPricePerOuter != changed.ExpectedUnitPricePerOuter)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.ExpectedUnitPricePerOuter, FilterConditions.Equals, changed.ExpectedUnitPricePerOuter));
            if(original.LastReceiptDate != changed.LastReceiptDate)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.LastReceiptDate, FilterConditions.Equals, changed.LastReceiptDate));
            if(original.IsOrderLineFinalized != changed.IsOrderLineFinalized)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.IsOrderLineFinalized, FilterConditions.Equals, changed.IsOrderLineFinalized));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(PurchaseOrderLineProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
