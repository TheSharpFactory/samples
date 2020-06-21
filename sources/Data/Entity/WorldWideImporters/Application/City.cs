/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{
    public partial class City
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
    public partial class City
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

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property StateProvinceID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince StateProvince { get; set; }
        /// <summary>
        /// Related to property DeliveryCityID on Entity SystemParameter
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter> SystemParameters { get; set; }
        /// <summary>
        /// Related to property PostalCityID on Entity SystemParameter
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter> SystemParameters1 { get; set; }
        /// <summary>
        /// Related to property DeliveryCityID on Entity Supplier
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier> Suppliers { get; set; }
        /// <summary>
        /// Related to property PostalCityID on Entity Supplier
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier> Suppliers1 { get; set; }
        /// <summary>
        /// Related to property DeliveryCityID on Entity Customer
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer> Customers { get; set; }
        /// <summary>
        /// Related to property PostalCityID on Entity Customer
        /// </summary>
        public List<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer> Customers1 { get; set; }
        #endregion
    }
}
