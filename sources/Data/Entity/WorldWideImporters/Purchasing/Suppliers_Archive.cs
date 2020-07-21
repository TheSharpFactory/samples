/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{
    public partial class Suppliers_Archive
    {
    }
}

************************************************/

using System;

namespace TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class Suppliers_Archive
    {
        #region Simple Properties
        public int SupplierID { get; set; } 
        public string SupplierName { get; set; } 
        public int SupplierCategoryID { get; set; } 
        public int PrimaryContactPersonID { get; set; } 
        public int AlternateContactPersonID { get; set; } 
        public int? DeliveryMethodID { get; set; } 
        public int DeliveryCityID { get; set; } 
        public int PostalCityID { get; set; } 
        public string SupplierReference { get; set; } 
        public string BankAccountName { get; set; } 
        public string BankAccountBranch { get; set; } 
        public string BankAccountCode { get; set; } 
        public string BankAccountNumber { get; set; } 
        public string BankInternationalCode { get; set; } 
        public int PaymentDays { get; set; } 
        public string InternalComments { get; set; } 
        public string PhoneNumber { get; set; } 
        public string FaxNumber { get; set; } 
        public string WebsiteURL { get; set; } 
        public string DeliveryAddressLine1 { get; set; } 
        public string DeliveryAddressLine2 { get; set; } 
        public string DeliveryPostalCode { get; set; } 
        public Microsoft.SqlServer.Types.SqlGeography DeliveryLocation { get; set; } 
        public string PostalAddressLine1 { get; set; } 
        public string PostalAddressLine2 { get; set; } 
        public string PostalPostalCode { get; set; } 
        public int LastEditedBy { get; set; } 
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidTo { get; set; } 
        #endregion
    }
}
