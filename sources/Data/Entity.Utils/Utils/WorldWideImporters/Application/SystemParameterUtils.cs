/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{
    public static partial class SystemParameterUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter.
    /// </summary>
    public static partial class SystemParameterUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(SystemParameter one, SystemParameter two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.SystemParameterID != two.SystemParameterID)
                return true;
            if(string.CompareOrdinal(one.DeliveryAddressLine1, two.DeliveryAddressLine1) != 0)
                return true;
            if(string.CompareOrdinal(one.DeliveryAddressLine2, two.DeliveryAddressLine2) != 0)
                return true;
            if(one.DeliveryCityID != two.DeliveryCityID)
                return true;
            if(string.CompareOrdinal(one.DeliveryPostalCode, two.DeliveryPostalCode) != 0)
                return true;
            if(one.DeliveryLocation != two.DeliveryLocation)
                return true;
            if(string.CompareOrdinal(one.PostalAddressLine1, two.PostalAddressLine1) != 0)
                return true;
            if(string.CompareOrdinal(one.PostalAddressLine2, two.PostalAddressLine2) != 0)
                return true;
            if(one.PostalCityID != two.PostalCityID)
                return true;
            if(string.CompareOrdinal(one.PostalPostalCode, two.PostalPostalCode) != 0)
                return true;
            if(string.CompareOrdinal(one.ApplicationSettings, two.ApplicationSettings) != 0)
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
        public static void Merge(SystemParameter source, SystemParameter target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.SystemParameterID = source.SystemParameterID;
            target.DeliveryAddressLine1 = source.DeliveryAddressLine1;
            target.DeliveryAddressLine2 = source.DeliveryAddressLine2;
            target.DeliveryCityID = source.DeliveryCityID;
            target.DeliveryPostalCode = source.DeliveryPostalCode;
            target.DeliveryLocation = source.DeliveryLocation;
            target.PostalAddressLine1 = source.PostalAddressLine1;
            target.PostalAddressLine2 = source.PostalAddressLine2;
            target.PostalCityID = source.PostalCityID;
            target.PostalPostalCode = source.PostalPostalCode;
            target.ApplicationSettings = source.ApplicationSettings;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of SystemParameterProperty</returns>
        public static QueryFilters<SystemParameterProperty> GetChanges(SystemParameter original, SystemParameter changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<SystemParameterProperty>(13);
            #region Detect Changes
            if(original.SystemParameterID != changed.SystemParameterID)
                changes.Add(QueryFilter.New(SystemParameterProperty.SystemParameterID, FilterConditions.Equals, changed.SystemParameterID));
            if(string.CompareOrdinal(original.DeliveryAddressLine1, changed.DeliveryAddressLine1) != 0)
                changes.Add(QueryFilter.New(SystemParameterProperty.DeliveryAddressLine1, FilterConditions.Equals, changed.DeliveryAddressLine1));
            if(string.CompareOrdinal(original.DeliveryAddressLine2, changed.DeliveryAddressLine2) != 0)
                changes.Add(QueryFilter.New(SystemParameterProperty.DeliveryAddressLine2, FilterConditions.Equals, changed.DeliveryAddressLine2));
            if(original.DeliveryCityID != changed.DeliveryCityID)
                changes.Add(QueryFilter.New(SystemParameterProperty.DeliveryCityID, FilterConditions.Equals, changed.DeliveryCityID));
            if(string.CompareOrdinal(original.DeliveryPostalCode, changed.DeliveryPostalCode) != 0)
                changes.Add(QueryFilter.New(SystemParameterProperty.DeliveryPostalCode, FilterConditions.Equals, changed.DeliveryPostalCode));
            if(original.DeliveryLocation != changed.DeliveryLocation)
                changes.Add(QueryFilter.New(SystemParameterProperty.DeliveryLocation, FilterConditions.Equals, changed.DeliveryLocation));
            if(string.CompareOrdinal(original.PostalAddressLine1, changed.PostalAddressLine1) != 0)
                changes.Add(QueryFilter.New(SystemParameterProperty.PostalAddressLine1, FilterConditions.Equals, changed.PostalAddressLine1));
            if(string.CompareOrdinal(original.PostalAddressLine2, changed.PostalAddressLine2) != 0)
                changes.Add(QueryFilter.New(SystemParameterProperty.PostalAddressLine2, FilterConditions.Equals, changed.PostalAddressLine2));
            if(original.PostalCityID != changed.PostalCityID)
                changes.Add(QueryFilter.New(SystemParameterProperty.PostalCityID, FilterConditions.Equals, changed.PostalCityID));
            if(string.CompareOrdinal(original.PostalPostalCode, changed.PostalPostalCode) != 0)
                changes.Add(QueryFilter.New(SystemParameterProperty.PostalPostalCode, FilterConditions.Equals, changed.PostalPostalCode));
            if(string.CompareOrdinal(original.ApplicationSettings, changed.ApplicationSettings) != 0)
                changes.Add(QueryFilter.New(SystemParameterProperty.ApplicationSettings, FilterConditions.Equals, changed.ApplicationSettings));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(SystemParameterProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(SystemParameterProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
