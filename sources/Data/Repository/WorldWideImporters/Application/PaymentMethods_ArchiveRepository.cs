/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class PaymentMethods_ArchiveRepository
    {
    }
}

************************************************/

using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{

    /// <summary>
    /// This class represents the Repository for: PaymentMethods_Archive.
    /// </summary>
    public partial class PaymentMethods_ArchiveRepository:WritableRepositoryBase<PaymentMethods_Archive, PaymentMethods_ArchiveProperty>, IPaymentMethods_ArchiveRepository
    {
        #region Constructors
        public PaymentMethods_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_PaymentMethods_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<PaymentMethods_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<PaymentMethods_ArchiveProperty> ComposeKeys(PaymentMethods_Archive paymentmethods_archive)
        {
            return new QueryFilters<PaymentMethods_ArchiveProperty>{ QueryFilter.New(PaymentMethods_ArchiveProperty.PaymentMethodID, FilterConditions.Equals, paymentmethods_archive.PaymentMethodID), QueryFilter.New(PaymentMethods_ArchiveProperty.PaymentMethodName, FilterConditions.Equals, paymentmethods_archive.PaymentMethodName), QueryFilter.New(PaymentMethods_ArchiveProperty.LastEditedBy, FilterConditions.Equals, paymentmethods_archive.LastEditedBy), QueryFilter.New(PaymentMethods_ArchiveProperty.ValidFrom, FilterConditions.Equals, paymentmethods_archive.ValidFrom), QueryFilter.New(PaymentMethods_ArchiveProperty.ValidTo, FilterConditions.Equals, paymentmethods_archive.ValidTo) };
        }
        protected override QueryFilters<PaymentMethods_ArchiveProperty> GetChanges(PaymentMethods_Archive original, PaymentMethods_Archive changed)
        {
            return PaymentMethods_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(PaymentMethods_Archive source, PaymentMethods_Archive target)
        {
            PaymentMethods_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<PaymentMethods_ArchiveProperty> ComposeInsertPredicate(PaymentMethods_Archive paymentmethods_archive)
        {
            return new QueryFilters<PaymentMethods_ArchiveProperty>{ QueryFilter.New(PaymentMethods_ArchiveProperty.PaymentMethodID, FilterConditions.Equals, paymentmethods_archive.PaymentMethodID), QueryFilter.New(PaymentMethods_ArchiveProperty.PaymentMethodName, FilterConditions.Equals, paymentmethods_archive.PaymentMethodName), QueryFilter.New(PaymentMethods_ArchiveProperty.LastEditedBy, FilterConditions.Equals, paymentmethods_archive.LastEditedBy), QueryFilter.New(PaymentMethods_ArchiveProperty.ValidFrom, FilterConditions.Equals, paymentmethods_archive.ValidFrom), QueryFilter.New(PaymentMethods_ArchiveProperty.ValidTo, FilterConditions.Equals, paymentmethods_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static PaymentMethods_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new PaymentMethods_Archive
            {
                PaymentMethodID = r.GetInt32(0),
                PaymentMethodName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        #endregion
    }
}
