/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{
    public static partial class StockGroupUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup.
    /// </summary>
    public static partial class StockGroupUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(StockGroup one, StockGroup two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.StockGroupID != two.StockGroupID)
                return true;
            if(string.CompareOrdinal(one.StockGroupName, two.StockGroupName) != 0)
                return true;
            if(one.LastEditedBy != two.LastEditedBy)
                return true;
            if(one.ValidFrom != two.ValidFrom)
                return true;
            if(one.ValidTo != two.ValidTo)
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
        public static void Merge(StockGroup source, StockGroup target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.StockGroupID = source.StockGroupID;
            target.StockGroupName = source.StockGroupName;
            target.LastEditedBy = source.LastEditedBy;
            target.ValidFrom = source.ValidFrom;
            target.ValidTo = source.ValidTo;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of StockGroupProperty</returns>
        public static QueryFilters<StockGroupProperty> GetChanges(StockGroup original, StockGroup changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<StockGroupProperty>(5);
            #region Detect Changes
            if(original.StockGroupID != changed.StockGroupID)
                changes.Add(QueryFilter.New(StockGroupProperty.StockGroupID, FilterConditions.Equals, changed.StockGroupID));
            if(string.CompareOrdinal(original.StockGroupName, changed.StockGroupName) != 0)
                changes.Add(QueryFilter.New(StockGroupProperty.StockGroupName, FilterConditions.Equals, changed.StockGroupName));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(StockGroupProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(StockGroupProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(StockGroupProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
