/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{
    public static partial class CountryUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country.
    /// </summary>
    public static partial class CountryUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Country one, Country two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.CountryID != two.CountryID)
                return true;
            if(string.CompareOrdinal(one.CountryName, two.CountryName) != 0)
                return true;
            if(string.CompareOrdinal(one.FormalName, two.FormalName) != 0)
                return true;
            if(string.CompareOrdinal(one.IsoAlpha3Code, two.IsoAlpha3Code) != 0)
                return true;
            if(one.IsoNumericCode != two.IsoNumericCode)
                return true;
            if(string.CompareOrdinal(one.CountryType, two.CountryType) != 0)
                return true;
            if(one.LatestRecordedPopulation != two.LatestRecordedPopulation)
                return true;
            if(string.CompareOrdinal(one.Continent, two.Continent) != 0)
                return true;
            if(string.CompareOrdinal(one.Region, two.Region) != 0)
                return true;
            if(string.CompareOrdinal(one.Subregion, two.Subregion) != 0)
                return true;
            if(one.Border != two.Border)
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
        public static void Merge(Country source, Country target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.CountryID = source.CountryID;
            target.CountryName = source.CountryName;
            target.FormalName = source.FormalName;
            target.IsoAlpha3Code = source.IsoAlpha3Code;
            target.IsoNumericCode = source.IsoNumericCode;
            target.CountryType = source.CountryType;
            target.LatestRecordedPopulation = source.LatestRecordedPopulation;
            target.Continent = source.Continent;
            target.Region = source.Region;
            target.Subregion = source.Subregion;
            target.Border = source.Border;
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
        /// <returns>QueryFilters of CountryProperty</returns>
        public static QueryFilters<CountryProperty> GetChanges(Country original, Country changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<CountryProperty>(14);
            #region Detect Changes
            if(original.CountryID != changed.CountryID)
                changes.Add(QueryFilter.New(CountryProperty.CountryID, FilterConditions.Equals, changed.CountryID));
            if(string.CompareOrdinal(original.CountryName, changed.CountryName) != 0)
                changes.Add(QueryFilter.New(CountryProperty.CountryName, FilterConditions.Equals, changed.CountryName));
            if(string.CompareOrdinal(original.FormalName, changed.FormalName) != 0)
                changes.Add(QueryFilter.New(CountryProperty.FormalName, FilterConditions.Equals, changed.FormalName));
            if(string.CompareOrdinal(original.IsoAlpha3Code, changed.IsoAlpha3Code) != 0)
                changes.Add(QueryFilter.New(CountryProperty.IsoAlpha3Code, FilterConditions.Equals, changed.IsoAlpha3Code));
            if(original.IsoNumericCode != changed.IsoNumericCode)
                changes.Add(QueryFilter.New(CountryProperty.IsoNumericCode, FilterConditions.Equals, changed.IsoNumericCode));
            if(string.CompareOrdinal(original.CountryType, changed.CountryType) != 0)
                changes.Add(QueryFilter.New(CountryProperty.CountryType, FilterConditions.Equals, changed.CountryType));
            if(original.LatestRecordedPopulation != changed.LatestRecordedPopulation)
                changes.Add(QueryFilter.New(CountryProperty.LatestRecordedPopulation, FilterConditions.Equals, changed.LatestRecordedPopulation));
            if(string.CompareOrdinal(original.Continent, changed.Continent) != 0)
                changes.Add(QueryFilter.New(CountryProperty.Continent, FilterConditions.Equals, changed.Continent));
            if(string.CompareOrdinal(original.Region, changed.Region) != 0)
                changes.Add(QueryFilter.New(CountryProperty.Region, FilterConditions.Equals, changed.Region));
            if(string.CompareOrdinal(original.Subregion, changed.Subregion) != 0)
                changes.Add(QueryFilter.New(CountryProperty.Subregion, FilterConditions.Equals, changed.Subregion));
            if(original.Border != changed.Border)
                changes.Add(QueryFilter.New(CountryProperty.Border, FilterConditions.Equals, changed.Border));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(CountryProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(CountryProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(CountryProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
