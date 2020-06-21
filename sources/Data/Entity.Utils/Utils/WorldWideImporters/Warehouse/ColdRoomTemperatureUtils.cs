/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{
    public static partial class ColdRoomTemperatureUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature.
    /// </summary>
    public static partial class ColdRoomTemperatureUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(ColdRoomTemperature one, ColdRoomTemperature two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.ColdRoomTemperatureID != two.ColdRoomTemperatureID)
                return true;
            if(one.ColdRoomSensorNumber != two.ColdRoomSensorNumber)
                return true;
            if(one.RecordedWhen != two.RecordedWhen)
                return true;
            if(one.Temperature != two.Temperature)
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
        public static void Merge(ColdRoomTemperature source, ColdRoomTemperature target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.ColdRoomTemperatureID = source.ColdRoomTemperatureID;
            target.ColdRoomSensorNumber = source.ColdRoomSensorNumber;
            target.RecordedWhen = source.RecordedWhen;
            target.Temperature = source.Temperature;
            target.ValidFrom = source.ValidFrom;
            target.ValidTo = source.ValidTo;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of ColdRoomTemperatureProperty</returns>
        public static QueryFilters<ColdRoomTemperatureProperty> GetChanges(ColdRoomTemperature original, ColdRoomTemperature changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<ColdRoomTemperatureProperty>(6);
            #region Detect Changes
            if(original.ColdRoomTemperatureID != changed.ColdRoomTemperatureID)
                changes.Add(QueryFilter.New(ColdRoomTemperatureProperty.ColdRoomTemperatureID, FilterConditions.Equals, changed.ColdRoomTemperatureID));
            if(original.ColdRoomSensorNumber != changed.ColdRoomSensorNumber)
                changes.Add(QueryFilter.New(ColdRoomTemperatureProperty.ColdRoomSensorNumber, FilterConditions.Equals, changed.ColdRoomSensorNumber));
            if(original.RecordedWhen != changed.RecordedWhen)
                changes.Add(QueryFilter.New(ColdRoomTemperatureProperty.RecordedWhen, FilterConditions.Equals, changed.RecordedWhen));
            if(original.Temperature != changed.Temperature)
                changes.Add(QueryFilter.New(ColdRoomTemperatureProperty.Temperature, FilterConditions.Equals, changed.Temperature));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(ColdRoomTemperatureProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(ColdRoomTemperatureProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
