/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class Countries_ArchiveRepository
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
    /// This class represents the Repository for: Countries_Archive.
    /// </summary>
    public partial class Countries_ArchiveRepository:WritableRepositoryBase<Countries_Archive, Countries_ArchiveProperty>, ICountries_ArchiveRepository
    {
        #region Constructors
        public Countries_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Countries_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<Countries_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<Countries_ArchiveProperty> ComposeKeys(Countries_Archive countries_archive)
        {
            return new QueryFilters<Countries_ArchiveProperty>{ QueryFilter.New(Countries_ArchiveProperty.CountryID, FilterConditions.Equals, countries_archive.CountryID), QueryFilter.New(Countries_ArchiveProperty.CountryName, FilterConditions.Equals, countries_archive.CountryName), QueryFilter.New(Countries_ArchiveProperty.FormalName, FilterConditions.Equals, countries_archive.FormalName), QueryFilter.New(Countries_ArchiveProperty.IsoAlpha3Code, FilterConditions.Equals, countries_archive.IsoAlpha3Code), QueryFilter.New(Countries_ArchiveProperty.IsoNumericCode, FilterConditions.Equals, countries_archive.IsoNumericCode), QueryFilter.New(Countries_ArchiveProperty.CountryType, FilterConditions.Equals, countries_archive.CountryType), QueryFilter.New(Countries_ArchiveProperty.LatestRecordedPopulation, FilterConditions.Equals, countries_archive.LatestRecordedPopulation), QueryFilter.New(Countries_ArchiveProperty.Continent, FilterConditions.Equals, countries_archive.Continent), QueryFilter.New(Countries_ArchiveProperty.Region, FilterConditions.Equals, countries_archive.Region), QueryFilter.New(Countries_ArchiveProperty.Subregion, FilterConditions.Equals, countries_archive.Subregion), QueryFilter.New(Countries_ArchiveProperty.Border, FilterConditions.Equals, countries_archive.Border), QueryFilter.New(Countries_ArchiveProperty.LastEditedBy, FilterConditions.Equals, countries_archive.LastEditedBy), QueryFilter.New(Countries_ArchiveProperty.ValidFrom, FilterConditions.Equals, countries_archive.ValidFrom), QueryFilter.New(Countries_ArchiveProperty.ValidTo, FilterConditions.Equals, countries_archive.ValidTo) };
        }
        protected override QueryFilters<Countries_ArchiveProperty> GetChanges(Countries_Archive original, Countries_Archive changed)
        {
            return Countries_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(Countries_Archive source, Countries_Archive target)
        {
            Countries_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<Countries_ArchiveProperty> ComposeInsertPredicate(Countries_Archive countries_archive)
        {
            return new QueryFilters<Countries_ArchiveProperty>{ QueryFilter.New(Countries_ArchiveProperty.CountryID, FilterConditions.Equals, countries_archive.CountryID), QueryFilter.New(Countries_ArchiveProperty.CountryName, FilterConditions.Equals, countries_archive.CountryName), QueryFilter.New(Countries_ArchiveProperty.FormalName, FilterConditions.Equals, countries_archive.FormalName), QueryFilter.New(Countries_ArchiveProperty.IsoAlpha3Code, FilterConditions.Equals, countries_archive.IsoAlpha3Code), QueryFilter.New(Countries_ArchiveProperty.IsoNumericCode, FilterConditions.Equals, countries_archive.IsoNumericCode), QueryFilter.New(Countries_ArchiveProperty.CountryType, FilterConditions.Equals, countries_archive.CountryType), QueryFilter.New(Countries_ArchiveProperty.LatestRecordedPopulation, FilterConditions.Equals, countries_archive.LatestRecordedPopulation), QueryFilter.New(Countries_ArchiveProperty.Continent, FilterConditions.Equals, countries_archive.Continent), QueryFilter.New(Countries_ArchiveProperty.Region, FilterConditions.Equals, countries_archive.Region), QueryFilter.New(Countries_ArchiveProperty.Subregion, FilterConditions.Equals, countries_archive.Subregion), QueryFilter.New(Countries_ArchiveProperty.Border, FilterConditions.Equals, countries_archive.Border), QueryFilter.New(Countries_ArchiveProperty.LastEditedBy, FilterConditions.Equals, countries_archive.LastEditedBy), QueryFilter.New(Countries_ArchiveProperty.ValidFrom, FilterConditions.Equals, countries_archive.ValidFrom), QueryFilter.New(Countries_ArchiveProperty.ValidTo, FilterConditions.Equals, countries_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 14);
        }
        private static Countries_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new Countries_Archive
            {
                CountryID = r.GetInt32(0),
                CountryName = r.GetString(1),
                FormalName = r.GetString(2),
                IsoAlpha3Code = r.GetValue(3) as string,
                IsoNumericCode = r.GetValue(4) as int?,
                CountryType = r.GetValue(5) as string,
                LatestRecordedPopulation = r.GetValue(6) as long?,
                Continent = r.GetString(7),
                Region = r.GetString(8),
                Subregion = r.GetString(9),
                Border = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(10)),
                LastEditedBy = r.GetInt32(11),
                ValidFrom = r.GetDateTime(12),
                ValidTo = r.GetDateTime(13),
            };
        }
        #endregion
    }
}
