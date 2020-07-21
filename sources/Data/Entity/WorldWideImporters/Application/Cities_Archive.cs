/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{
    public partial class Cities_Archive
    {
    }
}

************************************************/

using System;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class Cities_Archive
    {
        #region Simple Properties
        public int CityID { get; set; } 
        public string CityName { get; set; } 
        public int StateProvinceID { get; set; } 
        public Microsoft.SqlServer.Types.SqlGeography Location { get; set; } 
        public long? LatestRecordedPopulation { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion
    }
}
