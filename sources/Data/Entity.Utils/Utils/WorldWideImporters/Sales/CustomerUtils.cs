/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{
    public static partial class CustomerUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer.
    /// </summary>
    public static partial class CustomerUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Customer one, Customer two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.CustomerID != two.CustomerID)
                return true;
            if(string.CompareOrdinal(one.CustomerName, two.CustomerName) != 0)
                return true;
            if(one.BillToCustomerID != two.BillToCustomerID)
                return true;
            if(one.CustomerCategoryID != two.CustomerCategoryID)
                return true;
            if(one.BuyingGroupID != two.BuyingGroupID)
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
            if(one.CreditLimit != two.CreditLimit)
                return true;
            if(one.AccountOpenedDate != two.AccountOpenedDate)
                return true;
            if(one.StandardDiscountPercentage != two.StandardDiscountPercentage)
                return true;
            if(one.IsStatementSent != two.IsStatementSent)
                return true;
            if(one.IsOnCreditHold != two.IsOnCreditHold)
                return true;
            if(one.PaymentDays != two.PaymentDays)
                return true;
            if(string.CompareOrdinal(one.PhoneNumber, two.PhoneNumber) != 0)
                return true;
            if(string.CompareOrdinal(one.FaxNumber, two.FaxNumber) != 0)
                return true;
            if(string.CompareOrdinal(one.DeliveryRun, two.DeliveryRun) != 0)
                return true;
            if(string.CompareOrdinal(one.RunPosition, two.RunPosition) != 0)
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
        public static void Merge(Customer source, Customer target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.CustomerID = source.CustomerID;
            target.CustomerName = source.CustomerName;
            target.BillToCustomerID = source.BillToCustomerID;
            target.CustomerCategoryID = source.CustomerCategoryID;
            target.BuyingGroupID = source.BuyingGroupID;
            target.PrimaryContactPersonID = source.PrimaryContactPersonID;
            target.AlternateContactPersonID = source.AlternateContactPersonID;
            target.DeliveryMethodID = source.DeliveryMethodID;
            target.DeliveryCityID = source.DeliveryCityID;
            target.PostalCityID = source.PostalCityID;
            target.CreditLimit = source.CreditLimit;
            target.AccountOpenedDate = source.AccountOpenedDate;
            target.StandardDiscountPercentage = source.StandardDiscountPercentage;
            target.IsStatementSent = source.IsStatementSent;
            target.IsOnCreditHold = source.IsOnCreditHold;
            target.PaymentDays = source.PaymentDays;
            target.PhoneNumber = source.PhoneNumber;
            target.FaxNumber = source.FaxNumber;
            target.DeliveryRun = source.DeliveryRun;
            target.RunPosition = source.RunPosition;
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
        /// <returns>QueryFilters of CustomerProperty</returns>
        public static QueryFilters<CustomerProperty> GetChanges(Customer original, Customer changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<CustomerProperty>(31);
            #region Detect Changes
            if(original.CustomerID != changed.CustomerID)
                changes.Add(QueryFilter.New(CustomerProperty.CustomerID, FilterConditions.Equals, changed.CustomerID));
            if(string.CompareOrdinal(original.CustomerName, changed.CustomerName) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.CustomerName, FilterConditions.Equals, changed.CustomerName));
            if(original.BillToCustomerID != changed.BillToCustomerID)
                changes.Add(QueryFilter.New(CustomerProperty.BillToCustomerID, FilterConditions.Equals, changed.BillToCustomerID));
            if(original.CustomerCategoryID != changed.CustomerCategoryID)
                changes.Add(QueryFilter.New(CustomerProperty.CustomerCategoryID, FilterConditions.Equals, changed.CustomerCategoryID));
            if(original.BuyingGroupID != changed.BuyingGroupID)
                changes.Add(QueryFilter.New(CustomerProperty.BuyingGroupID, FilterConditions.Equals, changed.BuyingGroupID));
            if(original.PrimaryContactPersonID != changed.PrimaryContactPersonID)
                changes.Add(QueryFilter.New(CustomerProperty.PrimaryContactPersonID, FilterConditions.Equals, changed.PrimaryContactPersonID));
            if(original.AlternateContactPersonID != changed.AlternateContactPersonID)
                changes.Add(QueryFilter.New(CustomerProperty.AlternateContactPersonID, FilterConditions.Equals, changed.AlternateContactPersonID));
            if(original.DeliveryMethodID != changed.DeliveryMethodID)
                changes.Add(QueryFilter.New(CustomerProperty.DeliveryMethodID, FilterConditions.Equals, changed.DeliveryMethodID));
            if(original.DeliveryCityID != changed.DeliveryCityID)
                changes.Add(QueryFilter.New(CustomerProperty.DeliveryCityID, FilterConditions.Equals, changed.DeliveryCityID));
            if(original.PostalCityID != changed.PostalCityID)
                changes.Add(QueryFilter.New(CustomerProperty.PostalCityID, FilterConditions.Equals, changed.PostalCityID));
            if(original.CreditLimit != changed.CreditLimit)
                changes.Add(QueryFilter.New(CustomerProperty.CreditLimit, FilterConditions.Equals, changed.CreditLimit));
            if(original.AccountOpenedDate != changed.AccountOpenedDate)
                changes.Add(QueryFilter.New(CustomerProperty.AccountOpenedDate, FilterConditions.Equals, changed.AccountOpenedDate));
            if(original.StandardDiscountPercentage != changed.StandardDiscountPercentage)
                changes.Add(QueryFilter.New(CustomerProperty.StandardDiscountPercentage, FilterConditions.Equals, changed.StandardDiscountPercentage));
            if(original.IsStatementSent != changed.IsStatementSent)
                changes.Add(QueryFilter.New(CustomerProperty.IsStatementSent, FilterConditions.Equals, changed.IsStatementSent));
            if(original.IsOnCreditHold != changed.IsOnCreditHold)
                changes.Add(QueryFilter.New(CustomerProperty.IsOnCreditHold, FilterConditions.Equals, changed.IsOnCreditHold));
            if(original.PaymentDays != changed.PaymentDays)
                changes.Add(QueryFilter.New(CustomerProperty.PaymentDays, FilterConditions.Equals, changed.PaymentDays));
            if(string.CompareOrdinal(original.PhoneNumber, changed.PhoneNumber) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.PhoneNumber, FilterConditions.Equals, changed.PhoneNumber));
            if(string.CompareOrdinal(original.FaxNumber, changed.FaxNumber) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.FaxNumber, FilterConditions.Equals, changed.FaxNumber));
            if(string.CompareOrdinal(original.DeliveryRun, changed.DeliveryRun) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.DeliveryRun, FilterConditions.Equals, changed.DeliveryRun));
            if(string.CompareOrdinal(original.RunPosition, changed.RunPosition) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.RunPosition, FilterConditions.Equals, changed.RunPosition));
            if(string.CompareOrdinal(original.WebsiteURL, changed.WebsiteURL) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.WebsiteURL, FilterConditions.Equals, changed.WebsiteURL));
            if(string.CompareOrdinal(original.DeliveryAddressLine1, changed.DeliveryAddressLine1) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.DeliveryAddressLine1, FilterConditions.Equals, changed.DeliveryAddressLine1));
            if(string.CompareOrdinal(original.DeliveryAddressLine2, changed.DeliveryAddressLine2) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.DeliveryAddressLine2, FilterConditions.Equals, changed.DeliveryAddressLine2));
            if(string.CompareOrdinal(original.DeliveryPostalCode, changed.DeliveryPostalCode) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.DeliveryPostalCode, FilterConditions.Equals, changed.DeliveryPostalCode));
            if(original.DeliveryLocation != changed.DeliveryLocation)
                changes.Add(QueryFilter.New(CustomerProperty.DeliveryLocation, FilterConditions.Equals, changed.DeliveryLocation));
            if(string.CompareOrdinal(original.PostalAddressLine1, changed.PostalAddressLine1) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.PostalAddressLine1, FilterConditions.Equals, changed.PostalAddressLine1));
            if(string.CompareOrdinal(original.PostalAddressLine2, changed.PostalAddressLine2) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.PostalAddressLine2, FilterConditions.Equals, changed.PostalAddressLine2));
            if(string.CompareOrdinal(original.PostalPostalCode, changed.PostalPostalCode) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.PostalPostalCode, FilterConditions.Equals, changed.PostalPostalCode));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(CustomerProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(CustomerProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(CustomerProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
