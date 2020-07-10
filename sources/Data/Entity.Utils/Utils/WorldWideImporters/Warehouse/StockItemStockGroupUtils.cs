/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{
    public static partial class StockItemStockGroupUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup.
    /// </summary>
    public static partial class StockItemStockGroupUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(StockItemStockGroup one, StockItemStockGroup two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.StockItemStockGroupID != two.StockItemStockGroupID)
                return true;
            if(one.StockItemID != two.StockItemID)
                return true;
            if(one.StockGroupID != two.StockGroupID)
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
        public static void Merge(StockItemStockGroup source, StockItemStockGroup target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.StockItemStockGroupID = source.StockItemStockGroupID;
            target.StockItemID = source.StockItemID;
            target.StockGroupID = source.StockGroupID;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of StockItemStockGroupProperty</returns>
        public static QueryFilters<StockItemStockGroupProperty> GetChanges(StockItemStockGroup original, StockItemStockGroup changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<StockItemStockGroupProperty>(5);
            #region Detect Changes
            if(original.StockItemStockGroupID != changed.StockItemStockGroupID)
                changes.Add(QueryFilter.New(StockItemStockGroupProperty.StockItemStockGroupID, FilterConditions.Equals, changed.StockItemStockGroupID));
            if(original.StockItemID != changed.StockItemID)
                changes.Add(QueryFilter.New(StockItemStockGroupProperty.StockItemID, FilterConditions.Equals, changed.StockItemID));
            if(original.StockGroupID != changed.StockGroupID)
                changes.Add(QueryFilter.New(StockItemStockGroupProperty.StockGroupID, FilterConditions.Equals, changed.StockGroupID));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(StockItemStockGroupProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(StockItemStockGroupProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
