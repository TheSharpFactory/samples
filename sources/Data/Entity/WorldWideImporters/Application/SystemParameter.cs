/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Application
{
    public partial class SystemParameter
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
    public partial class SystemParameter
    {
        #region Simple Properties
        public int SystemParameterID { get; set; } 
        public string DeliveryAddressLine1 { get; set; } 
        public string DeliveryAddressLine2 { get; set; } 
        public int DeliveryCityID { get; set; } 
        public string DeliveryPostalCode { get; set; } 
        public Microsoft.SqlServer.Types.SqlGeography DeliveryLocation { get; set; } 
        public string PostalAddressLine1 { get; set; } 
        public string PostalAddressLine2 { get; set; } 
        public int PostalCityID { get; set; } 
        public string PostalPostalCode { get; set; } 
        public string ApplicationSettings { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime LastEditedWhen { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property LastEditedBy on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person Person { get; set; }
        /// <summary>
        /// Related to property DeliveryCityID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.City City { get; set; }
        /// <summary>
        /// Related to property PostalCityID on this entity
        /// </summary>
        public TheSharpFactory.Data.Entity.WorldWideImporters.Application.City City1 { get; set; }
        #endregion
    }
}
