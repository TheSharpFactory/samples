/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class StockGroups_ArchiveRepository
    {
    }
}

************************************************/

using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class represents the Repository for: StockGroups_Archive.
    /// </summary>
    public partial class StockGroups_ArchiveRepository:WritableRepositoryBase<StockGroups_Archive, StockGroups_ArchiveProperty>, IStockGroups_ArchiveRepository
    {
        #region Constructors
        public StockGroups_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockGroups_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<StockGroups_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<StockGroups_ArchiveProperty> ComposeKeys(StockGroups_Archive stockgroups_archive)
        {
            return new QueryFilters<StockGroups_ArchiveProperty>{ QueryFilter.New(StockGroups_ArchiveProperty.StockGroupID, FilterConditions.Equals, stockgroups_archive.StockGroupID), QueryFilter.New(StockGroups_ArchiveProperty.StockGroupName, FilterConditions.Equals, stockgroups_archive.StockGroupName), QueryFilter.New(StockGroups_ArchiveProperty.LastEditedBy, FilterConditions.Equals, stockgroups_archive.LastEditedBy), QueryFilter.New(StockGroups_ArchiveProperty.ValidFrom, FilterConditions.Equals, stockgroups_archive.ValidFrom), QueryFilter.New(StockGroups_ArchiveProperty.ValidTo, FilterConditions.Equals, stockgroups_archive.ValidTo) };
        }
        protected override QueryFilters<StockGroups_ArchiveProperty> GetChanges(StockGroups_Archive original, StockGroups_Archive changed)
        {
            return StockGroups_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(StockGroups_Archive source, StockGroups_Archive target)
        {
            StockGroups_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<StockGroups_ArchiveProperty> ComposeInsertPredicate(StockGroups_Archive stockgroups_archive)
        {
            return new QueryFilters<StockGroups_ArchiveProperty>{ QueryFilter.New(StockGroups_ArchiveProperty.StockGroupID, FilterConditions.Equals, stockgroups_archive.StockGroupID), QueryFilter.New(StockGroups_ArchiveProperty.StockGroupName, FilterConditions.Equals, stockgroups_archive.StockGroupName), QueryFilter.New(StockGroups_ArchiveProperty.LastEditedBy, FilterConditions.Equals, stockgroups_archive.LastEditedBy), QueryFilter.New(StockGroups_ArchiveProperty.ValidFrom, FilterConditions.Equals, stockgroups_archive.ValidFrom), QueryFilter.New(StockGroups_ArchiveProperty.ValidTo, FilterConditions.Equals, stockgroups_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static StockGroups_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new StockGroups_Archive
            {
                StockGroupID = r.GetInt32(0),
                StockGroupName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        #endregion
    }
}
