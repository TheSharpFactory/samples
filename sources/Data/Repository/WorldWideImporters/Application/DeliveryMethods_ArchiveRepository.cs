/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class DeliveryMethods_ArchiveRepository
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
    /// This class represents the Repository for: DeliveryMethods_Archive.
    /// </summary>
    public partial class DeliveryMethods_ArchiveRepository:WritableRepositoryBase<DeliveryMethods_Archive, DeliveryMethods_ArchiveProperty>, IDeliveryMethods_ArchiveRepository
    {
        #region Constructors
        public DeliveryMethods_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_DeliveryMethods_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<DeliveryMethods_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<DeliveryMethods_ArchiveProperty> ComposeKeys(DeliveryMethods_Archive deliverymethods_archive)
        {
            return new QueryFilters<DeliveryMethods_ArchiveProperty>{ QueryFilter.New(DeliveryMethods_ArchiveProperty.DeliveryMethodID, FilterConditions.Equals, deliverymethods_archive.DeliveryMethodID), QueryFilter.New(DeliveryMethods_ArchiveProperty.DeliveryMethodName, FilterConditions.Equals, deliverymethods_archive.DeliveryMethodName), QueryFilter.New(DeliveryMethods_ArchiveProperty.LastEditedBy, FilterConditions.Equals, deliverymethods_archive.LastEditedBy), QueryFilter.New(DeliveryMethods_ArchiveProperty.ValidFrom, FilterConditions.Equals, deliverymethods_archive.ValidFrom), QueryFilter.New(DeliveryMethods_ArchiveProperty.ValidTo, FilterConditions.Equals, deliverymethods_archive.ValidTo) };
        }
        protected override QueryFilters<DeliveryMethods_ArchiveProperty> GetChanges(DeliveryMethods_Archive original, DeliveryMethods_Archive changed)
        {
            return DeliveryMethods_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(DeliveryMethods_Archive source, DeliveryMethods_Archive target)
        {
            DeliveryMethods_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<DeliveryMethods_ArchiveProperty> ComposeInsertPredicate(DeliveryMethods_Archive deliverymethods_archive)
        {
            return new QueryFilters<DeliveryMethods_ArchiveProperty>{ QueryFilter.New(DeliveryMethods_ArchiveProperty.DeliveryMethodID, FilterConditions.Equals, deliverymethods_archive.DeliveryMethodID), QueryFilter.New(DeliveryMethods_ArchiveProperty.DeliveryMethodName, FilterConditions.Equals, deliverymethods_archive.DeliveryMethodName), QueryFilter.New(DeliveryMethods_ArchiveProperty.LastEditedBy, FilterConditions.Equals, deliverymethods_archive.LastEditedBy), QueryFilter.New(DeliveryMethods_ArchiveProperty.ValidFrom, FilterConditions.Equals, deliverymethods_archive.ValidFrom), QueryFilter.New(DeliveryMethods_ArchiveProperty.ValidTo, FilterConditions.Equals, deliverymethods_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static DeliveryMethods_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new DeliveryMethods_Archive
            {
                DeliveryMethodID = r.GetInt32(0),
                DeliveryMethodName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        #endregion
    }
}
