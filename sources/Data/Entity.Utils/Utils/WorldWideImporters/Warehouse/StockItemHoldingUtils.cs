/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{
    public static partial class StockItemHoldingUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding.
    /// </summary>
    public static partial class StockItemHoldingUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(StockItemHolding one, StockItemHolding two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.StockItemID != two.StockItemID)
                return true;
            if(one.QuantityOnHand != two.QuantityOnHand)
                return true;
            if(string.CompareOrdinal(one.BinLocation, two.BinLocation) != 0)
                return true;
            if(one.LastStocktakeQuantity != two.LastStocktakeQuantity)
                return true;
            if(one.LastCostPrice != two.LastCostPrice)
                return true;
            if(one.ReorderLevel != two.ReorderLevel)
                return true;
            if(one.TargetStockLevel != two.TargetStockLevel)
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
        public static void Merge(StockItemHolding source, StockItemHolding target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.StockItemID = source.StockItemID;
            target.QuantityOnHand = source.QuantityOnHand;
            target.BinLocation = source.BinLocation;
            target.LastStocktakeQuantity = source.LastStocktakeQuantity;
            target.LastCostPrice = source.LastCostPrice;
            target.ReorderLevel = source.ReorderLevel;
            target.TargetStockLevel = source.TargetStockLevel;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of StockItemHoldingProperty</returns>
        public static QueryFilters<StockItemHoldingProperty> GetChanges(StockItemHolding original, StockItemHolding changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<StockItemHoldingProperty>(9);
            #region Detect Changes
            if(original.StockItemID != changed.StockItemID)
                changes.Add(QueryFilter.New(StockItemHoldingProperty.StockItemID, FilterConditions.Equals, changed.StockItemID));
            if(original.QuantityOnHand != changed.QuantityOnHand)
                changes.Add(QueryFilter.New(StockItemHoldingProperty.QuantityOnHand, FilterConditions.Equals, changed.QuantityOnHand));
            if(string.CompareOrdinal(original.BinLocation, changed.BinLocation) != 0)
                changes.Add(QueryFilter.New(StockItemHoldingProperty.BinLocation, FilterConditions.Equals, changed.BinLocation));
            if(original.LastStocktakeQuantity != changed.LastStocktakeQuantity)
                changes.Add(QueryFilter.New(StockItemHoldingProperty.LastStocktakeQuantity, FilterConditions.Equals, changed.LastStocktakeQuantity));
            if(original.LastCostPrice != changed.LastCostPrice)
                changes.Add(QueryFilter.New(StockItemHoldingProperty.LastCostPrice, FilterConditions.Equals, changed.LastCostPrice));
            if(original.ReorderLevel != changed.ReorderLevel)
                changes.Add(QueryFilter.New(StockItemHoldingProperty.ReorderLevel, FilterConditions.Equals, changed.ReorderLevel));
            if(original.TargetStockLevel != changed.TargetStockLevel)
                changes.Add(QueryFilter.New(StockItemHoldingProperty.TargetStockLevel, FilterConditions.Equals, changed.TargetStockLevel));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(StockItemHoldingProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(StockItemHoldingProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
