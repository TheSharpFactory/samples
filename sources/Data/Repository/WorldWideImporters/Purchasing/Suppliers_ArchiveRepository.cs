/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{
    public partial class Suppliers_ArchiveRepository
    {
    }
}

************************************************/

using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class represents the Repository for: Suppliers_Archive.
    /// </summary>
    public partial class Suppliers_ArchiveRepository:WritableRepositoryBase<Suppliers_Archive, Suppliers_ArchiveProperty>, ISuppliers_ArchiveRepository
    {
        #region Constructors
        public Suppliers_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Suppliers_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<Suppliers_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<Suppliers_ArchiveProperty> ComposeKeys(Suppliers_Archive suppliers_archive)
        {
            return new QueryFilters<Suppliers_ArchiveProperty>{ QueryFilter.New(Suppliers_ArchiveProperty.SupplierID, FilterConditions.Equals, suppliers_archive.SupplierID), QueryFilter.New(Suppliers_ArchiveProperty.SupplierName, FilterConditions.Equals, suppliers_archive.SupplierName), QueryFilter.New(Suppliers_ArchiveProperty.SupplierCategoryID, FilterConditions.Equals, suppliers_archive.SupplierCategoryID), QueryFilter.New(Suppliers_ArchiveProperty.PrimaryContactPersonID, FilterConditions.Equals, suppliers_archive.PrimaryContactPersonID), QueryFilter.New(Suppliers_ArchiveProperty.AlternateContactPersonID, FilterConditions.Equals, suppliers_archive.AlternateContactPersonID), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryMethodID, FilterConditions.Equals, suppliers_archive.DeliveryMethodID), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryCityID, FilterConditions.Equals, suppliers_archive.DeliveryCityID), QueryFilter.New(Suppliers_ArchiveProperty.PostalCityID, FilterConditions.Equals, suppliers_archive.PostalCityID), QueryFilter.New(Suppliers_ArchiveProperty.SupplierReference, FilterConditions.Equals, suppliers_archive.SupplierReference), QueryFilter.New(Suppliers_ArchiveProperty.BankAccountName, FilterConditions.Equals, suppliers_archive.BankAccountName), QueryFilter.New(Suppliers_ArchiveProperty.BankAccountBranch, FilterConditions.Equals, suppliers_archive.BankAccountBranch), QueryFilter.New(Suppliers_ArchiveProperty.BankAccountCode, FilterConditions.Equals, suppliers_archive.BankAccountCode), QueryFilter.New(Suppliers_ArchiveProperty.BankAccountNumber, FilterConditions.Equals, suppliers_archive.BankAccountNumber), QueryFilter.New(Suppliers_ArchiveProperty.BankInternationalCode, FilterConditions.Equals, suppliers_archive.BankInternationalCode), QueryFilter.New(Suppliers_ArchiveProperty.PaymentDays, FilterConditions.Equals, suppliers_archive.PaymentDays), QueryFilter.New(Suppliers_ArchiveProperty.InternalComments, FilterConditions.Equals, suppliers_archive.InternalComments), QueryFilter.New(Suppliers_ArchiveProperty.PhoneNumber, FilterConditions.Equals, suppliers_archive.PhoneNumber), QueryFilter.New(Suppliers_ArchiveProperty.FaxNumber, FilterConditions.Equals, suppliers_archive.FaxNumber), QueryFilter.New(Suppliers_ArchiveProperty.WebsiteURL, FilterConditions.Equals, suppliers_archive.WebsiteURL), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryAddressLine1, FilterConditions.Equals, suppliers_archive.DeliveryAddressLine1), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryAddressLine2, FilterConditions.Equals, suppliers_archive.DeliveryAddressLine2), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryPostalCode, FilterConditions.Equals, suppliers_archive.DeliveryPostalCode), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryLocation, FilterConditions.Equals, suppliers_archive.DeliveryLocation), QueryFilter.New(Suppliers_ArchiveProperty.PostalAddressLine1, FilterConditions.Equals, suppliers_archive.PostalAddressLine1), QueryFilter.New(Suppliers_ArchiveProperty.PostalAddressLine2, FilterConditions.Equals, suppliers_archive.PostalAddressLine2), QueryFilter.New(Suppliers_ArchiveProperty.PostalPostalCode, FilterConditions.Equals, suppliers_archive.PostalPostalCode), QueryFilter.New(Suppliers_ArchiveProperty.LastEditedBy, FilterConditions.Equals, suppliers_archive.LastEditedBy), QueryFilter.New(Suppliers_ArchiveProperty.ValidFrom, FilterConditions.Equals, suppliers_archive.ValidFrom), QueryFilter.New(Suppliers_ArchiveProperty.ValidTo, FilterConditions.Equals, suppliers_archive.ValidTo) };
        }
        protected override QueryFilters<Suppliers_ArchiveProperty> GetChanges(Suppliers_Archive original, Suppliers_Archive changed)
        {
            return Suppliers_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(Suppliers_Archive source, Suppliers_Archive target)
        {
            Suppliers_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<Suppliers_ArchiveProperty> ComposeInsertPredicate(Suppliers_Archive suppliers_archive)
        {
            return new QueryFilters<Suppliers_ArchiveProperty>{ QueryFilter.New(Suppliers_ArchiveProperty.SupplierID, FilterConditions.Equals, suppliers_archive.SupplierID), QueryFilter.New(Suppliers_ArchiveProperty.SupplierName, FilterConditions.Equals, suppliers_archive.SupplierName), QueryFilter.New(Suppliers_ArchiveProperty.SupplierCategoryID, FilterConditions.Equals, suppliers_archive.SupplierCategoryID), QueryFilter.New(Suppliers_ArchiveProperty.PrimaryContactPersonID, FilterConditions.Equals, suppliers_archive.PrimaryContactPersonID), QueryFilter.New(Suppliers_ArchiveProperty.AlternateContactPersonID, FilterConditions.Equals, suppliers_archive.AlternateContactPersonID), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryMethodID, FilterConditions.Equals, suppliers_archive.DeliveryMethodID), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryCityID, FilterConditions.Equals, suppliers_archive.DeliveryCityID), QueryFilter.New(Suppliers_ArchiveProperty.PostalCityID, FilterConditions.Equals, suppliers_archive.PostalCityID), QueryFilter.New(Suppliers_ArchiveProperty.SupplierReference, FilterConditions.Equals, suppliers_archive.SupplierReference), QueryFilter.New(Suppliers_ArchiveProperty.BankAccountName, FilterConditions.Equals, suppliers_archive.BankAccountName), QueryFilter.New(Suppliers_ArchiveProperty.BankAccountBranch, FilterConditions.Equals, suppliers_archive.BankAccountBranch), QueryFilter.New(Suppliers_ArchiveProperty.BankAccountCode, FilterConditions.Equals, suppliers_archive.BankAccountCode), QueryFilter.New(Suppliers_ArchiveProperty.BankAccountNumber, FilterConditions.Equals, suppliers_archive.BankAccountNumber), QueryFilter.New(Suppliers_ArchiveProperty.BankInternationalCode, FilterConditions.Equals, suppliers_archive.BankInternationalCode), QueryFilter.New(Suppliers_ArchiveProperty.PaymentDays, FilterConditions.Equals, suppliers_archive.PaymentDays), QueryFilter.New(Suppliers_ArchiveProperty.InternalComments, FilterConditions.Equals, suppliers_archive.InternalComments), QueryFilter.New(Suppliers_ArchiveProperty.PhoneNumber, FilterConditions.Equals, suppliers_archive.PhoneNumber), QueryFilter.New(Suppliers_ArchiveProperty.FaxNumber, FilterConditions.Equals, suppliers_archive.FaxNumber), QueryFilter.New(Suppliers_ArchiveProperty.WebsiteURL, FilterConditions.Equals, suppliers_archive.WebsiteURL), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryAddressLine1, FilterConditions.Equals, suppliers_archive.DeliveryAddressLine1), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryAddressLine2, FilterConditions.Equals, suppliers_archive.DeliveryAddressLine2), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryPostalCode, FilterConditions.Equals, suppliers_archive.DeliveryPostalCode), QueryFilter.New(Suppliers_ArchiveProperty.DeliveryLocation, FilterConditions.Equals, suppliers_archive.DeliveryLocation), QueryFilter.New(Suppliers_ArchiveProperty.PostalAddressLine1, FilterConditions.Equals, suppliers_archive.PostalAddressLine1), QueryFilter.New(Suppliers_ArchiveProperty.PostalAddressLine2, FilterConditions.Equals, suppliers_archive.PostalAddressLine2), QueryFilter.New(Suppliers_ArchiveProperty.PostalPostalCode, FilterConditions.Equals, suppliers_archive.PostalPostalCode), QueryFilter.New(Suppliers_ArchiveProperty.LastEditedBy, FilterConditions.Equals, suppliers_archive.LastEditedBy), QueryFilter.New(Suppliers_ArchiveProperty.ValidFrom, FilterConditions.Equals, suppliers_archive.ValidFrom), QueryFilter.New(Suppliers_ArchiveProperty.ValidTo, FilterConditions.Equals, suppliers_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 29);
        }
        private static Suppliers_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new Suppliers_Archive
            {
                SupplierID = r.GetInt32(0),
                SupplierName = r.GetString(1),
                SupplierCategoryID = r.GetInt32(2),
                PrimaryContactPersonID = r.GetInt32(3),
                AlternateContactPersonID = r.GetInt32(4),
                DeliveryMethodID = r.GetValue(5) as int?,
                DeliveryCityID = r.GetInt32(6),
                PostalCityID = r.GetInt32(7),
                SupplierReference = r.GetValue(8) as string,
                BankAccountName = r.GetValue(9) as string,
                BankAccountBranch = r.GetValue(10) as string,
                BankAccountCode = r.GetValue(11) as string,
                BankAccountNumber = r.GetValue(12) as string,
                BankInternationalCode = r.GetValue(13) as string,
                PaymentDays = r.GetInt32(14),
                InternalComments = r.GetValue(15) as string,
                PhoneNumber = r.GetString(16),
                FaxNumber = r.GetString(17),
                WebsiteURL = r.GetString(18),
                DeliveryAddressLine1 = r.GetString(19),
                DeliveryAddressLine2 = r.GetValue(20) as string,
                DeliveryPostalCode = r.GetString(21),
                DeliveryLocation = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(22)),
                PostalAddressLine1 = r.GetString(23),
                PostalAddressLine2 = r.GetValue(24) as string,
                PostalPostalCode = r.GetString(25),
                LastEditedBy = r.GetInt32(26),
                ValidFrom = r.GetDateTime(27),
                ValidTo = r.GetDateTime(28),
            };
        }
        #endregion
    }
}
