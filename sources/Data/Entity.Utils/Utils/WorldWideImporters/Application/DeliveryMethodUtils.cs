/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{
    public static partial class DeliveryMethodUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod.
    /// </summary>
    public static partial class DeliveryMethodUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(DeliveryMethod one, DeliveryMethod two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.DeliveryMethodID != two.DeliveryMethodID)
                return true;
            if(string.CompareOrdinal(one.DeliveryMethodName, two.DeliveryMethodName) != 0)
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
        public static void Merge(DeliveryMethod source, DeliveryMethod target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.DeliveryMethodID = source.DeliveryMethodID;
            target.DeliveryMethodName = source.DeliveryMethodName;
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
        /// <returns>QueryFilters of DeliveryMethodProperty</returns>
        public static QueryFilters<DeliveryMethodProperty> GetChanges(DeliveryMethod original, DeliveryMethod changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<DeliveryMethodProperty>(5);
            #region Detect Changes
            if(original.DeliveryMethodID != changed.DeliveryMethodID)
                changes.Add(QueryFilter.New(DeliveryMethodProperty.DeliveryMethodID, FilterConditions.Equals, changed.DeliveryMethodID));
            if(string.CompareOrdinal(original.DeliveryMethodName, changed.DeliveryMethodName) != 0)
                changes.Add(QueryFilter.New(DeliveryMethodProperty.DeliveryMethodName, FilterConditions.Equals, changed.DeliveryMethodName));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(DeliveryMethodProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(DeliveryMethodProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(DeliveryMethodProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}