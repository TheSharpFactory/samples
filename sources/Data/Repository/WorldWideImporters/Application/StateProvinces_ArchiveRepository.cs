/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class StateProvinces_ArchiveRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{

    /// <summary>
    /// This class represents the Repository for: StateProvinces_Archive.
    /// </summary>
    public partial class StateProvinces_ArchiveRepository:WritableRepositoryBase<StateProvinces_Archive, StateProvinces_ArchiveProperty>, IStateProvinces_ArchiveRepository
    {
        #region Constructors
        public StateProvinces_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_StateProvinces_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<StateProvinces_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<StateProvinces_ArchiveProperty> ComposeKeys(StateProvinces_Archive stateprovinces_archive)
        {
            return new QueryFilters<StateProvinces_ArchiveProperty>{ QueryFilter.New(StateProvinces_ArchiveProperty.StateProvinceID, FilterConditions.Equals, stateprovinces_archive.StateProvinceID), QueryFilter.New(StateProvinces_ArchiveProperty.StateProvinceCode, FilterConditions.Equals, stateprovinces_archive.StateProvinceCode), QueryFilter.New(StateProvinces_ArchiveProperty.StateProvinceName, FilterConditions.Equals, stateprovinces_archive.StateProvinceName), QueryFilter.New(StateProvinces_ArchiveProperty.CountryID, FilterConditions.Equals, stateprovinces_archive.CountryID), QueryFilter.New(StateProvinces_ArchiveProperty.SalesTerritory, FilterConditions.Equals, stateprovinces_archive.SalesTerritory), QueryFilter.New(StateProvinces_ArchiveProperty.Border, FilterConditions.Equals, stateprovinces_archive.Border), QueryFilter.New(StateProvinces_ArchiveProperty.LatestRecordedPopulation, FilterConditions.Equals, stateprovinces_archive.LatestRecordedPopulation), QueryFilter.New(StateProvinces_ArchiveProperty.LastEditedBy, FilterConditions.Equals, stateprovinces_archive.LastEditedBy), QueryFilter.New(StateProvinces_ArchiveProperty.ValidFrom, FilterConditions.Equals, stateprovinces_archive.ValidFrom), QueryFilter.New(StateProvinces_ArchiveProperty.ValidTo, FilterConditions.Equals, stateprovinces_archive.ValidTo) };
        }
        protected override QueryFilters<StateProvinces_ArchiveProperty> GetChanges(StateProvinces_Archive original, StateProvinces_Archive changed)
        {
            return StateProvinces_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(StateProvinces_Archive source, StateProvinces_Archive target)
        {
            StateProvinces_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<StateProvinces_ArchiveProperty> ComposeInsertPredicate(StateProvinces_Archive stateprovinces_archive)
        {
            return new QueryFilters<StateProvinces_ArchiveProperty>{ QueryFilter.New(StateProvinces_ArchiveProperty.StateProvinceID, FilterConditions.Equals, stateprovinces_archive.StateProvinceID), QueryFilter.New(StateProvinces_ArchiveProperty.StateProvinceCode, FilterConditions.Equals, stateprovinces_archive.StateProvinceCode), QueryFilter.New(StateProvinces_ArchiveProperty.StateProvinceName, FilterConditions.Equals, stateprovinces_archive.StateProvinceName), QueryFilter.New(StateProvinces_ArchiveProperty.CountryID, FilterConditions.Equals, stateprovinces_archive.CountryID), QueryFilter.New(StateProvinces_ArchiveProperty.SalesTerritory, FilterConditions.Equals, stateprovinces_archive.SalesTerritory), QueryFilter.New(StateProvinces_ArchiveProperty.Border, FilterConditions.Equals, stateprovinces_archive.Border), QueryFilter.New(StateProvinces_ArchiveProperty.LatestRecordedPopulation, FilterConditions.Equals, stateprovinces_archive.LatestRecordedPopulation), QueryFilter.New(StateProvinces_ArchiveProperty.LastEditedBy, FilterConditions.Equals, stateprovinces_archive.LastEditedBy), QueryFilter.New(StateProvinces_ArchiveProperty.ValidFrom, FilterConditions.Equals, stateprovinces_archive.ValidFrom), QueryFilter.New(StateProvinces_ArchiveProperty.ValidTo, FilterConditions.Equals, stateprovinces_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 10);
        }
        private static StateProvinces_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new StateProvinces_Archive
            {
                StateProvinceID = r.GetInt32(0),
                StateProvinceCode = r.GetString(1),
                StateProvinceName = r.GetString(2),
                CountryID = r.GetInt32(3),
                SalesTerritory = r.GetString(4),
                Border = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(5)),
                LatestRecordedPopulation = r.GetValue(6) as long?,
                LastEditedBy = r.GetInt32(7),
                ValidFrom = r.GetDateTime(8),
                ValidTo = r.GetDateTime(9),
            };
        }
        #endregion
    }
}
