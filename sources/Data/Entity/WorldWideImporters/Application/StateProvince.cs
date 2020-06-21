/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{
    public partial class StateProvince
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class StateProvince
    {
        #region Simple Properties
        public int StateProvinceID { get; set; } 
        public string StateProvinceCode { get; set; } 
        public string StateProvinceName { get; set; } 
        public int CountryID { get; set; } 
        public string SalesTerritory { get; set; } 
        public Microsoft.SqlServer.Types.SqlGeography Border { get; set; } 
        public long? LatestRecordedPopulation { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property StateProvinceID on Entity City
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City> Cities { get; set; }
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property CountryID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country Country { get; set; }
        #endregion
    }
}
