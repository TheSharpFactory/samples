/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{
    public static partial class TransactionTypes_ArchiveUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionTypes_Archive.
    /// </summary>
    public static partial class TransactionTypes_ArchiveUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(TransactionTypes_Archive one, TransactionTypes_Archive two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.TransactionTypeID != two.TransactionTypeID)
                return true;
            if(string.CompareOrdinal(one.TransactionTypeName, two.TransactionTypeName) != 0)
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
        public static void Merge(TransactionTypes_Archive source, TransactionTypes_Archive target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.TransactionTypeID = source.TransactionTypeID;
            target.TransactionTypeName = source.TransactionTypeName;
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
        /// <returns>QueryFilters of TransactionTypes_ArchiveProperty</returns>
        public static QueryFilters<TransactionTypes_ArchiveProperty> GetChanges(TransactionTypes_Archive original, TransactionTypes_Archive changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<TransactionTypes_ArchiveProperty>(5);
            #region Detect Changes
            if(original.TransactionTypeID != changed.TransactionTypeID)
                changes.Add(QueryFilter.New(TransactionTypes_ArchiveProperty.TransactionTypeID, FilterConditions.Equals, changed.TransactionTypeID));
            if(string.CompareOrdinal(original.TransactionTypeName, changed.TransactionTypeName) != 0)
                changes.Add(QueryFilter.New(TransactionTypes_ArchiveProperty.TransactionTypeName, FilterConditions.Equals, changed.TransactionTypeName));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(TransactionTypes_ArchiveProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(TransactionTypes_ArchiveProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(TransactionTypes_ArchiveProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
