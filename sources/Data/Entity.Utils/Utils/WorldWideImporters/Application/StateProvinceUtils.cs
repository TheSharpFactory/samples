/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{
    public static partial class StateProvinceUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince.
    /// </summary>
    public static partial class StateProvinceUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(StateProvince one, StateProvince two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.StateProvinceID != two.StateProvinceID)
                return true;
            if(string.CompareOrdinal(one.StateProvinceCode, two.StateProvinceCode) != 0)
                return true;
            if(string.CompareOrdinal(one.StateProvinceName, two.StateProvinceName) != 0)
                return true;
            if(one.CountryID != two.CountryID)
                return true;
            if(string.CompareOrdinal(one.SalesTerritory, two.SalesTerritory) != 0)
                return true;
            if(one.Border != two.Border)
                return true;
            if(one.LatestRecordedPopulation != two.LatestRecordedPopulation)
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
        public static void Merge(StateProvince source, StateProvince target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.StateProvinceID = source.StateProvinceID;
            target.StateProvinceCode = source.StateProvinceCode;
            target.StateProvinceName = source.StateProvinceName;
            target.CountryID = source.CountryID;
            target.SalesTerritory = source.SalesTerritory;
            target.Border = source.Border;
            target.LatestRecordedPopulation = source.LatestRecordedPopulation;
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
        /// <returns>QueryFilters of StateProvinceProperty</returns>
        public static QueryFilters<StateProvinceProperty> GetChanges(StateProvince original, StateProvince changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<StateProvinceProperty>(10);
            #region Detect Changes
            if(original.StateProvinceID != changed.StateProvinceID)
                changes.Add(QueryFilter.New(StateProvinceProperty.StateProvinceID, FilterConditions.Equals, changed.StateProvinceID));
            if(string.CompareOrdinal(original.StateProvinceCode, changed.StateProvinceCode) != 0)
                changes.Add(QueryFilter.New(StateProvinceProperty.StateProvinceCode, FilterConditions.Equals, changed.StateProvinceCode));
            if(string.CompareOrdinal(original.StateProvinceName, changed.StateProvinceName) != 0)
                changes.Add(QueryFilter.New(StateProvinceProperty.StateProvinceName, FilterConditions.Equals, changed.StateProvinceName));
            if(original.CountryID != changed.CountryID)
                changes.Add(QueryFilter.New(StateProvinceProperty.CountryID, FilterConditions.Equals, changed.CountryID));
            if(string.CompareOrdinal(original.SalesTerritory, changed.SalesTerritory) != 0)
                changes.Add(QueryFilter.New(StateProvinceProperty.SalesTerritory, FilterConditions.Equals, changed.SalesTerritory));
            if(original.Border != changed.Border)
                changes.Add(QueryFilter.New(StateProvinceProperty.Border, FilterConditions.Equals, changed.Border));
            if(original.LatestRecordedPopulation != changed.LatestRecordedPopulation)
                changes.Add(QueryFilter.New(StateProvinceProperty.LatestRecordedPopulation, FilterConditions.Equals, changed.LatestRecordedPopulation));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(StateProvinceProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(StateProvinceProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(StateProvinceProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
