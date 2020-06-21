/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class Customers_ArchiveRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{

    /// <summary>
    /// This class represents the Repository for: Customers_Archive.
    /// </summary>
    public partial class Customers_ArchiveRepository:WritableRepositoryBase<Customers_Archive, Customers_ArchiveProperty>, ICustomers_ArchiveRepository
    {
        #region Constructors
        public Customers_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customers_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<Customers_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<Customers_ArchiveProperty> ComposeKeys(Customers_Archive customers_archive)
        {
            return new QueryFilters<Customers_ArchiveProperty>{ QueryFilter.New(Customers_ArchiveProperty.CustomerID, FilterConditions.Equals, customers_archive.CustomerID), QueryFilter.New(Customers_ArchiveProperty.CustomerName, FilterConditions.Equals, customers_archive.CustomerName), QueryFilter.New(Customers_ArchiveProperty.BillToCustomerID, FilterConditions.Equals, customers_archive.BillToCustomerID), QueryFilter.New(Customers_ArchiveProperty.CustomerCategoryID, FilterConditions.Equals, customers_archive.CustomerCategoryID), QueryFilter.New(Customers_ArchiveProperty.BuyingGroupID, FilterConditions.Equals, customers_archive.BuyingGroupID), QueryFilter.New(Customers_ArchiveProperty.PrimaryContactPersonID, FilterConditions.Equals, customers_archive.PrimaryContactPersonID), QueryFilter.New(Customers_ArchiveProperty.AlternateContactPersonID, FilterConditions.Equals, customers_archive.AlternateContactPersonID), QueryFilter.New(Customers_ArchiveProperty.DeliveryMethodID, FilterConditions.Equals, customers_archive.DeliveryMethodID), QueryFilter.New(Customers_ArchiveProperty.DeliveryCityID, FilterConditions.Equals, customers_archive.DeliveryCityID), QueryFilter.New(Customers_ArchiveProperty.PostalCityID, FilterConditions.Equals, customers_archive.PostalCityID), QueryFilter.New(Customers_ArchiveProperty.CreditLimit, FilterConditions.Equals, customers_archive.CreditLimit), QueryFilter.New(Customers_ArchiveProperty.AccountOpenedDate, FilterConditions.Equals, customers_archive.AccountOpenedDate), QueryFilter.New(Customers_ArchiveProperty.StandardDiscountPercentage, FilterConditions.Equals, customers_archive.StandardDiscountPercentage), QueryFilter.New(Customers_ArchiveProperty.IsStatementSent, FilterConditions.Equals, customers_archive.IsStatementSent), QueryFilter.New(Customers_ArchiveProperty.IsOnCreditHold, FilterConditions.Equals, customers_archive.IsOnCreditHold), QueryFilter.New(Customers_ArchiveProperty.PaymentDays, FilterConditions.Equals, customers_archive.PaymentDays), QueryFilter.New(Customers_ArchiveProperty.PhoneNumber, FilterConditions.Equals, customers_archive.PhoneNumber), QueryFilter.New(Customers_ArchiveProperty.FaxNumber, FilterConditions.Equals, customers_archive.FaxNumber), QueryFilter.New(Customers_ArchiveProperty.DeliveryRun, FilterConditions.Equals, customers_archive.DeliveryRun), QueryFilter.New(Customers_ArchiveProperty.RunPosition, FilterConditions.Equals, customers_archive.RunPosition), QueryFilter.New(Customers_ArchiveProperty.WebsiteURL, FilterConditions.Equals, customers_archive.WebsiteURL), QueryFilter.New(Customers_ArchiveProperty.DeliveryAddressLine1, FilterConditions.Equals, customers_archive.DeliveryAddressLine1), QueryFilter.New(Customers_ArchiveProperty.DeliveryAddressLine2, FilterConditions.Equals, customers_archive.DeliveryAddressLine2), QueryFilter.New(Customers_ArchiveProperty.DeliveryPostalCode, FilterConditions.Equals, customers_archive.DeliveryPostalCode), QueryFilter.New(Customers_ArchiveProperty.DeliveryLocation, FilterConditions.Equals, customers_archive.DeliveryLocation), QueryFilter.New(Customers_ArchiveProperty.PostalAddressLine1, FilterConditions.Equals, customers_archive.PostalAddressLine1), QueryFilter.New(Customers_ArchiveProperty.PostalAddressLine2, FilterConditions.Equals, customers_archive.PostalAddressLine2), QueryFilter.New(Customers_ArchiveProperty.PostalPostalCode, FilterConditions.Equals, customers_archive.PostalPostalCode), QueryFilter.New(Customers_ArchiveProperty.LastEditedBy, FilterConditions.Equals, customers_archive.LastEditedBy), QueryFilter.New(Customers_ArchiveProperty.ValidFrom, FilterConditions.Equals, customers_archive.ValidFrom), QueryFilter.New(Customers_ArchiveProperty.ValidTo, FilterConditions.Equals, customers_archive.ValidTo) };
        }
        protected override QueryFilters<Customers_ArchiveProperty> GetChanges(Customers_Archive original, Customers_Archive changed)
        {
            return Customers_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(Customers_Archive source, Customers_Archive target)
        {
            Customers_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<Customers_ArchiveProperty> ComposeInsertPredicate(Customers_Archive customers_archive)
        {
            return new QueryFilters<Customers_ArchiveProperty>{ QueryFilter.New(Customers_ArchiveProperty.CustomerID, FilterConditions.Equals, customers_archive.CustomerID), QueryFilter.New(Customers_ArchiveProperty.CustomerName, FilterConditions.Equals, customers_archive.CustomerName), QueryFilter.New(Customers_ArchiveProperty.BillToCustomerID, FilterConditions.Equals, customers_archive.BillToCustomerID), QueryFilter.New(Customers_ArchiveProperty.CustomerCategoryID, FilterConditions.Equals, customers_archive.CustomerCategoryID), QueryFilter.New(Customers_ArchiveProperty.BuyingGroupID, FilterConditions.Equals, customers_archive.BuyingGroupID), QueryFilter.New(Customers_ArchiveProperty.PrimaryContactPersonID, FilterConditions.Equals, customers_archive.PrimaryContactPersonID), QueryFilter.New(Customers_ArchiveProperty.AlternateContactPersonID, FilterConditions.Equals, customers_archive.AlternateContactPersonID), QueryFilter.New(Customers_ArchiveProperty.DeliveryMethodID, FilterConditions.Equals, customers_archive.DeliveryMethodID), QueryFilter.New(Customers_ArchiveProperty.DeliveryCityID, FilterConditions.Equals, customers_archive.DeliveryCityID), QueryFilter.New(Customers_ArchiveProperty.PostalCityID, FilterConditions.Equals, customers_archive.PostalCityID), QueryFilter.New(Customers_ArchiveProperty.CreditLimit, FilterConditions.Equals, customers_archive.CreditLimit), QueryFilter.New(Customers_ArchiveProperty.AccountOpenedDate, FilterConditions.Equals, customers_archive.AccountOpenedDate), QueryFilter.New(Customers_ArchiveProperty.StandardDiscountPercentage, FilterConditions.Equals, customers_archive.StandardDiscountPercentage), QueryFilter.New(Customers_ArchiveProperty.IsStatementSent, FilterConditions.Equals, customers_archive.IsStatementSent), QueryFilter.New(Customers_ArchiveProperty.IsOnCreditHold, FilterConditions.Equals, customers_archive.IsOnCreditHold), QueryFilter.New(Customers_ArchiveProperty.PaymentDays, FilterConditions.Equals, customers_archive.PaymentDays), QueryFilter.New(Customers_ArchiveProperty.PhoneNumber, FilterConditions.Equals, customers_archive.PhoneNumber), QueryFilter.New(Customers_ArchiveProperty.FaxNumber, FilterConditions.Equals, customers_archive.FaxNumber), QueryFilter.New(Customers_ArchiveProperty.DeliveryRun, FilterConditions.Equals, customers_archive.DeliveryRun), QueryFilter.New(Customers_ArchiveProperty.RunPosition, FilterConditions.Equals, customers_archive.RunPosition), QueryFilter.New(Customers_ArchiveProperty.WebsiteURL, FilterConditions.Equals, customers_archive.WebsiteURL), QueryFilter.New(Customers_ArchiveProperty.DeliveryAddressLine1, FilterConditions.Equals, customers_archive.DeliveryAddressLine1), QueryFilter.New(Customers_ArchiveProperty.DeliveryAddressLine2, FilterConditions.Equals, customers_archive.DeliveryAddressLine2), QueryFilter.New(Customers_ArchiveProperty.DeliveryPostalCode, FilterConditions.Equals, customers_archive.DeliveryPostalCode), QueryFilter.New(Customers_ArchiveProperty.DeliveryLocation, FilterConditions.Equals, customers_archive.DeliveryLocation), QueryFilter.New(Customers_ArchiveProperty.PostalAddressLine1, FilterConditions.Equals, customers_archive.PostalAddressLine1), QueryFilter.New(Customers_ArchiveProperty.PostalAddressLine2, FilterConditions.Equals, customers_archive.PostalAddressLine2), QueryFilter.New(Customers_ArchiveProperty.PostalPostalCode, FilterConditions.Equals, customers_archive.PostalPostalCode), QueryFilter.New(Customers_ArchiveProperty.LastEditedBy, FilterConditions.Equals, customers_archive.LastEditedBy), QueryFilter.New(Customers_ArchiveProperty.ValidFrom, FilterConditions.Equals, customers_archive.ValidFrom), QueryFilter.New(Customers_ArchiveProperty.ValidTo, FilterConditions.Equals, customers_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 31);
        }
        private static Customers_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new Customers_Archive
            {
                CustomerID = r.GetInt32(0),
                CustomerName = r.GetString(1),
                BillToCustomerID = r.GetInt32(2),
                CustomerCategoryID = r.GetInt32(3),
                BuyingGroupID = r.GetValue(4) as int?,
                PrimaryContactPersonID = r.GetInt32(5),
                AlternateContactPersonID = r.GetValue(6) as int?,
                DeliveryMethodID = r.GetInt32(7),
                DeliveryCityID = r.GetInt32(8),
                PostalCityID = r.GetInt32(9),
                CreditLimit = r.GetValue(10) as decimal?,
                AccountOpenedDate = r.GetDateTime(11),
                StandardDiscountPercentage = r.GetDecimal(12),
                IsStatementSent = r.GetBoolean(13),
                IsOnCreditHold = r.GetBoolean(14),
                PaymentDays = r.GetInt32(15),
                PhoneNumber = r.GetString(16),
                FaxNumber = r.GetString(17),
                DeliveryRun = r.GetValue(18) as string,
                RunPosition = r.GetValue(19) as string,
                WebsiteURL = r.GetString(20),
                DeliveryAddressLine1 = r.GetString(21),
                DeliveryAddressLine2 = r.GetValue(22) as string,
                DeliveryPostalCode = r.GetString(23),
                DeliveryLocation = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(24)),
                PostalAddressLine1 = r.GetString(25),
                PostalAddressLine2 = r.GetValue(26) as string,
                PostalPostalCode = r.GetString(27),
                LastEditedBy = r.GetInt32(28),
                ValidFrom = r.GetDateTime(29),
                ValidTo = r.GetDateTime(30),
            };
        }
        #endregion
    }
}
