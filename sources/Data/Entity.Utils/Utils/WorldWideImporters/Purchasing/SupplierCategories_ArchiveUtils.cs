/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{
    public static partial class SupplierCategories_ArchiveUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategories_Archive.
    /// </summary>
    public static partial class SupplierCategories_ArchiveUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(SupplierCategories_Archive one, SupplierCategories_Archive two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.SupplierCategoryID != two.SupplierCategoryID)
                return true;
            if(string.CompareOrdinal(one.SupplierCategoryName, two.SupplierCategoryName) != 0)
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
        public static void Merge(SupplierCategories_Archive source, SupplierCategories_Archive target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.SupplierCategoryID = source.SupplierCategoryID;
            target.SupplierCategoryName = source.SupplierCategoryName;
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
        /// <returns>QueryFilters of SupplierCategories_ArchiveProperty</returns>
        public static QueryFilters<SupplierCategories_ArchiveProperty> GetChanges(SupplierCategories_Archive original, SupplierCategories_Archive changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<SupplierCategories_ArchiveProperty>(5);
            #region Detect Changes
            if(original.SupplierCategoryID != changed.SupplierCategoryID)
                changes.Add(QueryFilter.New(SupplierCategories_ArchiveProperty.SupplierCategoryID, FilterConditions.Equals, changed.SupplierCategoryID));
            if(string.CompareOrdinal(original.SupplierCategoryName, changed.SupplierCategoryName) != 0)
                changes.Add(QueryFilter.New(SupplierCategories_ArchiveProperty.SupplierCategoryName, FilterConditions.Equals, changed.SupplierCategoryName));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(SupplierCategories_ArchiveProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(SupplierCategories_ArchiveProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(SupplierCategories_ArchiveProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
