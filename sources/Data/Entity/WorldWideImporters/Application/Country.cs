/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{
    public partial class Country
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
    public partial class Country
    {
        #region Simple Properties
        public int CountryID { get; set; } 
        public string CountryName { get; set; } 
        public string FormalName { get; set; } 
        public string IsoAlpha3Code { get; set; } 
        public int? IsoNumericCode { get; set; } 
        public string CountryType { get; set; } 
        public long? LatestRecordedPopulation { get; set; } 
        public string Continent { get; set; } 
        public string Region { get; set; } 
        public string Subregion { get; set; } 
        public Microsoft.SqlServer.Types.SqlGeography Border { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property CountryID on Entity StateProvince
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince> StateProvinces { get; set; }
        #endregion
    }
}
