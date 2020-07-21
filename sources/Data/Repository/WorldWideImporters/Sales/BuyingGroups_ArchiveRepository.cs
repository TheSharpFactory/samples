/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class BuyingGroups_ArchiveRepository
    {
    }
}

************************************************/

using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{

    /// <summary>
    /// This class represents the Repository for: BuyingGroups_Archive.
    /// </summary>
    public partial class BuyingGroups_ArchiveRepository:WritableRepositoryBase<BuyingGroups_Archive, BuyingGroups_ArchiveProperty>, IBuyingGroups_ArchiveRepository
    {
        #region Constructors
        public BuyingGroups_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_BuyingGroups_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<BuyingGroups_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<BuyingGroups_ArchiveProperty> ComposeKeys(BuyingGroups_Archive buyinggroups_archive)
        {
            return new QueryFilters<BuyingGroups_ArchiveProperty>{ QueryFilter.New(BuyingGroups_ArchiveProperty.BuyingGroupID, FilterConditions.Equals, buyinggroups_archive.BuyingGroupID), QueryFilter.New(BuyingGroups_ArchiveProperty.BuyingGroupName, FilterConditions.Equals, buyinggroups_archive.BuyingGroupName), QueryFilter.New(BuyingGroups_ArchiveProperty.LastEditedBy, FilterConditions.Equals, buyinggroups_archive.LastEditedBy), QueryFilter.New(BuyingGroups_ArchiveProperty.ValidFrom, FilterConditions.Equals, buyinggroups_archive.ValidFrom), QueryFilter.New(BuyingGroups_ArchiveProperty.ValidTo, FilterConditions.Equals, buyinggroups_archive.ValidTo) };
        }
        protected override QueryFilters<BuyingGroups_ArchiveProperty> GetChanges(BuyingGroups_Archive original, BuyingGroups_Archive changed)
        {
            return BuyingGroups_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(BuyingGroups_Archive source, BuyingGroups_Archive target)
        {
            BuyingGroups_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<BuyingGroups_ArchiveProperty> ComposeInsertPredicate(BuyingGroups_Archive buyinggroups_archive)
        {
            return new QueryFilters<BuyingGroups_ArchiveProperty>{ QueryFilter.New(BuyingGroups_ArchiveProperty.BuyingGroupID, FilterConditions.Equals, buyinggroups_archive.BuyingGroupID), QueryFilter.New(BuyingGroups_ArchiveProperty.BuyingGroupName, FilterConditions.Equals, buyinggroups_archive.BuyingGroupName), QueryFilter.New(BuyingGroups_ArchiveProperty.LastEditedBy, FilterConditions.Equals, buyinggroups_archive.LastEditedBy), QueryFilter.New(BuyingGroups_ArchiveProperty.ValidFrom, FilterConditions.Equals, buyinggroups_archive.ValidFrom), QueryFilter.New(BuyingGroups_ArchiveProperty.ValidTo, FilterConditions.Equals, buyinggroups_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static BuyingGroups_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new BuyingGroups_Archive
            {
                BuyingGroupID = r.GetInt32(0),
                BuyingGroupName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        #endregion
    }
}
