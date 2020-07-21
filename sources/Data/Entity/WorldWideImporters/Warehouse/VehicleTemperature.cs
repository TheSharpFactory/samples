/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{
    public partial class VehicleTemperature
    {
    }
}

************************************************/

using System;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class VehicleTemperature
    {
        #region Simple Properties
        public long VehicleTemperatureID { get; set; } 
        public string VehicleRegistration { get; set; } 
        public int ChillerSensorNumber { get; set; } 
        public DateTime RecordedWhen { get; set; } 
        public decimal Temperature { get; set; } 
        public string FullSensorData { get; set; } 
        public bool IsCompressed { get; set; } 
        public byte[] CompressedSensorData { get; set; } 
        #endregion
    }
}
