/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{
    public static partial class SupplierUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier.
    /// </summary>
    public static partial class SupplierUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Supplier one, Supplier two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.SupplierID != two.SupplierID)
                return true;
            if(string.CompareOrdinal(one.SupplierName, two.SupplierName) != 0)
                return true;
            if(one.SupplierCategoryID != two.SupplierCategoryID)
                return true;
            if(one.PrimaryContactPersonID != two.PrimaryContactPersonID)
                return true;
            if(one.AlternateContactPersonID != two.AlternateContactPersonID)
                return true;
            if(one.DeliveryMethodID != two.DeliveryMethodID)
                return true;
            if(one.DeliveryCityID != two.DeliveryCityID)
                return true;
            if(one.PostalCityID != two.PostalCityID)
                return true;
            if(string.CompareOrdinal(one.SupplierReference, two.SupplierReference) != 0)
                return true;
            if(string.CompareOrdinal(one.BankAccountName, two.BankAccountName) != 0)
                return true;
            if(string.CompareOrdinal(one.BankAccountBranch, two.BankAccountBranch) != 0)
                return true;
            if(string.CompareOrdinal(one.BankAccountCode, two.BankAccountCode) != 0)
                return true;
            if(string.CompareOrdinal(one.BankAccountNumber, two.BankAccountNumber) != 0)
                return true;
            if(string.CompareOrdinal(one.BankInternationalCode, two.BankInternationalCode) != 0)
                return true;
            if(one.PaymentDays != two.PaymentDays)
                return true;
            if(string.CompareOrdinal(one.InternalComments, two.InternalComments) != 0)
                return true;
            if(string.CompareOrdinal(one.PhoneNumber, two.PhoneNumber) != 0)
                return true;
            if(string.CompareOrdinal(one.FaxNumber, two.FaxNumber) != 0)
                return true;
            if(string.CompareOrdinal(one.WebsiteURL, two.WebsiteURL) != 0)
                return true;
            if(string.CompareOrdinal(one.DeliveryAddressLine1, two.DeliveryAddressLine1) != 0)
                return true;
            if(string.CompareOrdinal(one.DeliveryAddressLine2, two.DeliveryAddressLine2) != 0)
                return true;
            if(string.CompareOrdinal(one.DeliveryPostalCode, two.DeliveryPostalCode) != 0)
                return true;
            if(one.DeliveryLocation != two.DeliveryLocation)
                return true;
            if(string.CompareOrdinal(one.PostalAddressLine1, two.PostalAddressLine1) != 0)
                return true;
            if(string.CompareOrdinal(one.PostalAddressLine2, two.PostalAddressLine2) != 0)
                return true;
            if(string.CompareOrdinal(one.PostalPostalCode, two.PostalPostalCode) != 0)
                return true;
            if(one.LastEditedBy != two.LastEditedBy)
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
        public static void Merge(Supplier source, Supplier target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.SupplierID = source.SupplierID;
            target.SupplierName = source.SupplierName;
            target.SupplierCategoryID = source.SupplierCategoryID;
            target.PrimaryContactPersonID = source.PrimaryContactPersonID;
            target.AlternateContactPersonID = source.AlternateContactPersonID;
            target.DeliveryMethodID = source.DeliveryMethodID;
            target.DeliveryCityID = source.DeliveryCityID;
            target.PostalCityID = source.PostalCityID;
            target.SupplierReference = source.SupplierReference;
            target.BankAccountName = source.BankAccountName;
            target.BankAccountBranch = source.BankAccountBranch;
            target.BankAccountCode = source.BankAccountCode;
            target.BankAccountNumber = source.BankAccountNumber;
            target.BankInternationalCode = source.BankInternationalCode;
            target.PaymentDays = source.PaymentDays;
            target.InternalComments = source.InternalComments;
            target.PhoneNumber = source.PhoneNumber;
            target.FaxNumber = source.FaxNumber;
            target.WebsiteURL = source.WebsiteURL;
            target.DeliveryAddressLine1 = source.DeliveryAddressLine1;
            target.DeliveryAddressLine2 = source.DeliveryAddressLine2;
            target.DeliveryPostalCode = source.DeliveryPostalCode;
            target.DeliveryLocation = source.DeliveryLocation;
            target.PostalAddressLine1 = source.PostalAddressLine1;
            target.PostalAddressLine2 = source.PostalAddressLine2;
            target.PostalPostalCode = source.PostalPostalCode;
            target.LastEditedBy = source.LastEditedBy;
            target.ValidFrom = source.ValidFrom;
            target.ValidTo = source.ValidTo;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of SupplierProperty</returns>
        public static QueryFilters<SupplierProperty> GetChanges(Supplier original, Supplier changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<SupplierProperty>(29);
            #region Detect Changes
            if(original.SupplierID != changed.SupplierID)
                changes.Add(QueryFilter.New(SupplierProperty.SupplierID, FilterConditions.Equals, changed.SupplierID));
            if(string.CompareOrdinal(original.SupplierName, changed.SupplierName) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.SupplierName, FilterConditions.Equals, changed.SupplierName));
            if(original.SupplierCategoryID != changed.SupplierCategoryID)
                changes.Add(QueryFilter.New(SupplierProperty.SupplierCategoryID, FilterConditions.Equals, changed.SupplierCategoryID));
            if(original.PrimaryContactPersonID != changed.PrimaryContactPersonID)
                changes.Add(QueryFilter.New(SupplierProperty.PrimaryContactPersonID, FilterConditions.Equals, changed.PrimaryContactPersonID));
            if(original.AlternateContactPersonID != changed.AlternateContactPersonID)
                changes.Add(QueryFilter.New(SupplierProperty.AlternateContactPersonID, FilterConditions.Equals, changed.AlternateContactPersonID));
            if(original.DeliveryMethodID != changed.DeliveryMethodID)
                changes.Add(QueryFilter.New(SupplierProperty.DeliveryMethodID, FilterConditions.Equals, changed.DeliveryMethodID));
            if(original.DeliveryCityID != changed.DeliveryCityID)
                changes.Add(QueryFilter.New(SupplierProperty.DeliveryCityID, FilterConditions.Equals, changed.DeliveryCityID));
            if(original.PostalCityID != changed.PostalCityID)
                changes.Add(QueryFilter.New(SupplierProperty.PostalCityID, FilterConditions.Equals, changed.PostalCityID));
            if(string.CompareOrdinal(original.SupplierReference, changed.SupplierReference) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.SupplierReference, FilterConditions.Equals, changed.SupplierReference));
            if(string.CompareOrdinal(original.BankAccountName, changed.BankAccountName) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.BankAccountName, FilterConditions.Equals, changed.BankAccountName));
            if(string.CompareOrdinal(original.BankAccountBranch, changed.BankAccountBranch) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.BankAccountBranch, FilterConditions.Equals, changed.BankAccountBranch));
            if(string.CompareOrdinal(original.BankAccountCode, changed.BankAccountCode) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.BankAccountCode, FilterConditions.Equals, changed.BankAccountCode));
            if(string.CompareOrdinal(original.BankAccountNumber, changed.BankAccountNumber) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.BankAccountNumber, FilterConditions.Equals, changed.BankAccountNumber));
            if(string.CompareOrdinal(original.BankInternationalCode, changed.BankInternationalCode) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.BankInternationalCode, FilterConditions.Equals, changed.BankInternationalCode));
            if(original.PaymentDays != changed.PaymentDays)
                changes.Add(QueryFilter.New(SupplierProperty.PaymentDays, FilterConditions.Equals, changed.PaymentDays));
            if(string.CompareOrdinal(original.InternalComments, changed.InternalComments) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.InternalComments, FilterConditions.Equals, changed.InternalComments));
            if(string.CompareOrdinal(original.PhoneNumber, changed.PhoneNumber) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.PhoneNumber, FilterConditions.Equals, changed.PhoneNumber));
            if(string.CompareOrdinal(original.FaxNumber, changed.FaxNumber) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.FaxNumber, FilterConditions.Equals, changed.FaxNumber));
            if(string.CompareOrdinal(original.WebsiteURL, changed.WebsiteURL) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.WebsiteURL, FilterConditions.Equals, changed.WebsiteURL));
            if(string.CompareOrdinal(original.DeliveryAddressLine1, changed.DeliveryAddressLine1) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.DeliveryAddressLine1, FilterConditions.Equals, changed.DeliveryAddressLine1));
            if(string.CompareOrdinal(original.DeliveryAddressLine2, changed.DeliveryAddressLine2) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.DeliveryAddressLine2, FilterConditions.Equals, changed.DeliveryAddressLine2));
            if(string.CompareOrdinal(original.DeliveryPostalCode, changed.DeliveryPostalCode) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.DeliveryPostalCode, FilterConditions.Equals, changed.DeliveryPostalCode));
            if(original.DeliveryLocation != changed.DeliveryLocation)
                changes.Add(QueryFilter.New(SupplierProperty.DeliveryLocation, FilterConditions.Equals, changed.DeliveryLocation));
            if(string.CompareOrdinal(original.PostalAddressLine1, changed.PostalAddressLine1) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.PostalAddressLine1, FilterConditions.Equals, changed.PostalAddressLine1));
            if(string.CompareOrdinal(original.PostalAddressLine2, changed.PostalAddressLine2) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.PostalAddressLine2, FilterConditions.Equals, changed.PostalAddressLine2));
            if(string.CompareOrdinal(original.PostalPostalCode, changed.PostalPostalCode) != 0)
                changes.Add(QueryFilter.New(SupplierProperty.PostalPostalCode, FilterConditions.Equals, changed.PostalPostalCode));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(SupplierProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(SupplierProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(SupplierProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
