/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class Cities_ArchiveRepository
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
    /// This class represents the Repository for: Cities_Archive.
    /// </summary>
    public partial class Cities_ArchiveRepository:WritableRepositoryBase<Cities_Archive, Cities_ArchiveProperty>, ICities_ArchiveRepository
    {
        #region Constructors
        public Cities_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Cities_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<Cities_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<Cities_ArchiveProperty> ComposeKeys(Cities_Archive cities_archive)
        {
            return new QueryFilters<Cities_ArchiveProperty>{ QueryFilter.New(Cities_ArchiveProperty.CityID, FilterConditions.Equals, cities_archive.CityID), QueryFilter.New(Cities_ArchiveProperty.CityName, FilterConditions.Equals, cities_archive.CityName), QueryFilter.New(Cities_ArchiveProperty.StateProvinceID, FilterConditions.Equals, cities_archive.StateProvinceID), QueryFilter.New(Cities_ArchiveProperty.Location, FilterConditions.Equals, cities_archive.Location), QueryFilter.New(Cities_ArchiveProperty.LatestRecordedPopulation, FilterConditions.Equals, cities_archive.LatestRecordedPopulation), QueryFilter.New(Cities_ArchiveProperty.LastEditedBy, FilterConditions.Equals, cities_archive.LastEditedBy), QueryFilter.New(Cities_ArchiveProperty.ValidFrom, FilterConditions.Equals, cities_archive.ValidFrom), QueryFilter.New(Cities_ArchiveProperty.ValidTo, FilterConditions.Equals, cities_archive.ValidTo) };
        }
        protected override QueryFilters<Cities_ArchiveProperty> GetChanges(Cities_Archive original, Cities_Archive changed)
        {
            return Cities_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(Cities_Archive source, Cities_Archive target)
        {
            Cities_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<Cities_ArchiveProperty> ComposeInsertPredicate(Cities_Archive cities_archive)
        {
            return new QueryFilters<Cities_ArchiveProperty>{ QueryFilter.New(Cities_ArchiveProperty.CityID, FilterConditions.Equals, cities_archive.CityID), QueryFilter.New(Cities_ArchiveProperty.CityName, FilterConditions.Equals, cities_archive.CityName), QueryFilter.New(Cities_ArchiveProperty.StateProvinceID, FilterConditions.Equals, cities_archive.StateProvinceID), QueryFilter.New(Cities_ArchiveProperty.Location, FilterConditions.Equals, cities_archive.Location), QueryFilter.New(Cities_ArchiveProperty.LatestRecordedPopulation, FilterConditions.Equals, cities_archive.LatestRecordedPopulation), QueryFilter.New(Cities_ArchiveProperty.LastEditedBy, FilterConditions.Equals, cities_archive.LastEditedBy), QueryFilter.New(Cities_ArchiveProperty.ValidFrom, FilterConditions.Equals, cities_archive.ValidFrom), QueryFilter.New(Cities_ArchiveProperty.ValidTo, FilterConditions.Equals, cities_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 8);
        }
        private static Cities_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new Cities_Archive
            {
                CityID = r.GetInt32(0),
                CityName = r.GetString(1),
                StateProvinceID = r.GetInt32(2),
                Location = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(3)),
                LatestRecordedPopulation = r.GetValue(4) as long?,
                LastEditedBy = r.GetInt32(5),
                ValidFrom = r.GetDateTime(6),
                ValidTo = r.GetDateTime(7),
            };
        }
        #endregion
    }
}
