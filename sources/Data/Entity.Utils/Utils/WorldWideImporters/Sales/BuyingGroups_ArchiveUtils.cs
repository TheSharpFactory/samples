/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{
    public static partial class BuyingGroups_ArchiveUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroups_Archive.
    /// </summary>
    public static partial class BuyingGroups_ArchiveUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(BuyingGroups_Archive one, BuyingGroups_Archive two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.BuyingGroupID != two.BuyingGroupID)
                return true;
            if(string.CompareOrdinal(one.BuyingGroupName, two.BuyingGroupName) != 0)
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
        public static void Merge(BuyingGroups_Archive source, BuyingGroups_Archive target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.BuyingGroupID = source.BuyingGroupID;
            target.BuyingGroupName = source.BuyingGroupName;
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
        /// <returns>QueryFilters of BuyingGroups_ArchiveProperty</returns>
        public static QueryFilters<BuyingGroups_ArchiveProperty> GetChanges(BuyingGroups_Archive original, BuyingGroups_Archive changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<BuyingGroups_ArchiveProperty>(5);
            #region Detect Changes
            if(original.BuyingGroupID != changed.BuyingGroupID)
                changes.Add(QueryFilter.New(BuyingGroups_ArchiveProperty.BuyingGroupID, FilterConditions.Equals, changed.BuyingGroupID));
            if(string.CompareOrdinal(original.BuyingGroupName, changed.BuyingGroupName) != 0)
                changes.Add(QueryFilter.New(BuyingGroups_ArchiveProperty.BuyingGroupName, FilterConditions.Equals, changed.BuyingGroupName));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(BuyingGroups_ArchiveProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(BuyingGroups_ArchiveProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(BuyingGroups_ArchiveProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
