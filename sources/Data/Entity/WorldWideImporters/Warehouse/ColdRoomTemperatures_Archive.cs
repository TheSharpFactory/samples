/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{
    public partial class ColdRoomTemperatures_Archive
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class ColdRoomTemperatures_Archive
    {
        #region Simple Properties
        public long ColdRoomTemperatureID { get; set; } 
        public int ColdRoomSensorNumber { get; set; } 
        public DateTime RecordedWhen { get; set; } 
        public decimal Temperature { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion
    }
}
