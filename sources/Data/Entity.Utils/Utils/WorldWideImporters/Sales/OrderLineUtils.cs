/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{
    public static partial class OrderLineUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Sales.OrderLine.
    /// </summary>
    public static partial class OrderLineUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(OrderLine one, OrderLine two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.OrderLineID != two.OrderLineID)
                return true;
            if(one.OrderID != two.OrderID)
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
            if(one.PickedQuantity != two.PickedQuantity)
                return true;
            if(one.PickingCompletedWhen != two.PickingCompletedWhen)
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
        public static void Merge(OrderLine source, OrderLine target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.OrderLineID = source.OrderLineID;
            target.OrderID = source.OrderID;
            target.StockItemID = source.StockItemID;
            target.Description = source.Description;
            target.PackageTypeID = source.PackageTypeID;
            target.Quantity = source.Quantity;
            target.UnitPrice = source.UnitPrice;
            target.TaxRate = source.TaxRate;
            target.PickedQuantity = source.PickedQuantity;
            target.PickingCompletedWhen = source.PickingCompletedWhen;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of OrderLineProperty</returns>
        public static QueryFilters<OrderLineProperty> GetChanges(OrderLine original, OrderLine changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<OrderLineProperty>(12);
            #region Detect Changes
            if(original.OrderLineID != changed.OrderLineID)
                changes.Add(QueryFilter.New(OrderLineProperty.OrderLineID, FilterConditions.Equals, changed.OrderLineID));
            if(original.OrderID != changed.OrderID)
                changes.Add(QueryFilter.New(OrderLineProperty.OrderID, FilterConditions.Equals, changed.OrderID));
            if(original.StockItemID != changed.StockItemID)
                changes.Add(QueryFilter.New(OrderLineProperty.StockItemID, FilterConditions.Equals, changed.StockItemID));
            if(string.CompareOrdinal(original.Description, changed.Description) != 0)
                changes.Add(QueryFilter.New(OrderLineProperty.Description, FilterConditions.Equals, changed.Description));
            if(original.PackageTypeID != changed.PackageTypeID)
                changes.Add(QueryFilter.New(OrderLineProperty.PackageTypeID, FilterConditions.Equals, changed.PackageTypeID));
            if(original.Quantity != changed.Quantity)
                changes.Add(QueryFilter.New(OrderLineProperty.Quantity, FilterConditions.Equals, changed.Quantity));
            if(original.UnitPrice != changed.UnitPrice)
                changes.Add(QueryFilter.New(OrderLineProperty.UnitPrice, FilterConditions.Equals, changed.UnitPrice));
            if(original.TaxRate != changed.TaxRate)
                changes.Add(QueryFilter.New(OrderLineProperty.TaxRate, FilterConditions.Equals, changed.TaxRate));
            if(original.PickedQuantity != changed.PickedQuantity)
                changes.Add(QueryFilter.New(OrderLineProperty.PickedQuantity, FilterConditions.Equals, changed.PickedQuantity));
            if(original.PickingCompletedWhen != changed.PickingCompletedWhen)
                changes.Add(QueryFilter.New(OrderLineProperty.PickingCompletedWhen, FilterConditions.Equals, changed.PickingCompletedWhen));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(OrderLineProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(OrderLineProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
