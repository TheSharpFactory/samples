/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{
    public static partial class VehicleTemperatureUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature.
    /// </summary>
    public static partial class VehicleTemperatureUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(VehicleTemperature one, VehicleTemperature two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.VehicleTemperatureID != two.VehicleTemperatureID)
                return true;
            if(string.CompareOrdinal(one.VehicleRegistration, two.VehicleRegistration) != 0)
                return true;
            if(one.ChillerSensorNumber != two.ChillerSensorNumber)
                return true;
            if(one.RecordedWhen != two.RecordedWhen)
                return true;
            if(one.Temperature != two.Temperature)
                return true;
            if(string.CompareOrdinal(one.FullSensorData, two.FullSensorData) != 0)
                return true;
            if(one.IsCompressed != two.IsCompressed)
                return true;
            if(!Compare.ByteArrays(one.CompressedSensorData, two.CompressedSensorData))
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
        public static void Merge(VehicleTemperature source, VehicleTemperature target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.VehicleTemperatureID = source.VehicleTemperatureID;
            target.VehicleRegistration = source.VehicleRegistration;
            target.ChillerSensorNumber = source.ChillerSensorNumber;
            target.RecordedWhen = source.RecordedWhen;
            target.Temperature = source.Temperature;
            target.FullSensorData = source.FullSensorData;
            target.IsCompressed = source.IsCompressed;
            target.CompressedSensorData = source.CompressedSensorData;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of VehicleTemperatureProperty</returns>
        public static QueryFilters<VehicleTemperatureProperty> GetChanges(VehicleTemperature original, VehicleTemperature changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<VehicleTemperatureProperty>(8);
            #region Detect Changes
            if(original.VehicleTemperatureID != changed.VehicleTemperatureID)
                changes.Add(QueryFilter.New(VehicleTemperatureProperty.VehicleTemperatureID, FilterConditions.Equals, changed.VehicleTemperatureID));
            if(string.CompareOrdinal(original.VehicleRegistration, changed.VehicleRegistration) != 0)
                changes.Add(QueryFilter.New(VehicleTemperatureProperty.VehicleRegistration, FilterConditions.Equals, changed.VehicleRegistration));
            if(original.ChillerSensorNumber != changed.ChillerSensorNumber)
                changes.Add(QueryFilter.New(VehicleTemperatureProperty.ChillerSensorNumber, FilterConditions.Equals, changed.ChillerSensorNumber));
            if(original.RecordedWhen != changed.RecordedWhen)
                changes.Add(QueryFilter.New(VehicleTemperatureProperty.RecordedWhen, FilterConditions.Equals, changed.RecordedWhen));
            if(original.Temperature != changed.Temperature)
                changes.Add(QueryFilter.New(VehicleTemperatureProperty.Temperature, FilterConditions.Equals, changed.Temperature));
            if(string.CompareOrdinal(original.FullSensorData, changed.FullSensorData) != 0)
                changes.Add(QueryFilter.New(VehicleTemperatureProperty.FullSensorData, FilterConditions.Equals, changed.FullSensorData));
            if(original.IsCompressed != changed.IsCompressed)
                changes.Add(QueryFilter.New(VehicleTemperatureProperty.IsCompressed, FilterConditions.Equals, changed.IsCompressed));
            if(!Compare.ByteArrays(original.CompressedSensorData, changed.CompressedSensorData))
                changes.Add(QueryFilter.New(VehicleTemperatureProperty.CompressedSensorData, FilterConditions.Equals, changed.CompressedSensorData));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
