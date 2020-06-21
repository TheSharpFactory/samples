/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class ColdRoomTemperatures_ArchiveRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class represents the Repository for: ColdRoomTemperatures_Archive.
    /// </summary>
    public partial class ColdRoomTemperatures_ArchiveRepository:WritableRepositoryBase<ColdRoomTemperatures_Archive, ColdRoomTemperatures_ArchiveProperty>, IColdRoomTemperatures_ArchiveRepository
    {
        #region Constructors
        public ColdRoomTemperatures_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_ColdRoomTemperatures_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<ColdRoomTemperatures_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<ColdRoomTemperatures_ArchiveProperty> ComposeKeys(ColdRoomTemperatures_Archive coldroomtemperatures_archive)
        {
            return new QueryFilters<ColdRoomTemperatures_ArchiveProperty>{ QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.ColdRoomTemperatureID, FilterConditions.Equals, coldroomtemperatures_archive.ColdRoomTemperatureID), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.ColdRoomSensorNumber, FilterConditions.Equals, coldroomtemperatures_archive.ColdRoomSensorNumber), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.RecordedWhen, FilterConditions.Equals, coldroomtemperatures_archive.RecordedWhen), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.Temperature, FilterConditions.Equals, coldroomtemperatures_archive.Temperature), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.ValidFrom, FilterConditions.Equals, coldroomtemperatures_archive.ValidFrom), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.ValidTo, FilterConditions.Equals, coldroomtemperatures_archive.ValidTo) };
        }
        protected override QueryFilters<ColdRoomTemperatures_ArchiveProperty> GetChanges(ColdRoomTemperatures_Archive original, ColdRoomTemperatures_Archive changed)
        {
            return ColdRoomTemperatures_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(ColdRoomTemperatures_Archive source, ColdRoomTemperatures_Archive target)
        {
            ColdRoomTemperatures_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<ColdRoomTemperatures_ArchiveProperty> ComposeInsertPredicate(ColdRoomTemperatures_Archive coldroomtemperatures_archive)
        {
            return new QueryFilters<ColdRoomTemperatures_ArchiveProperty>{ QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.ColdRoomTemperatureID, FilterConditions.Equals, coldroomtemperatures_archive.ColdRoomTemperatureID), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.ColdRoomSensorNumber, FilterConditions.Equals, coldroomtemperatures_archive.ColdRoomSensorNumber), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.RecordedWhen, FilterConditions.Equals, coldroomtemperatures_archive.RecordedWhen), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.Temperature, FilterConditions.Equals, coldroomtemperatures_archive.Temperature), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.ValidFrom, FilterConditions.Equals, coldroomtemperatures_archive.ValidFrom), QueryFilter.New(ColdRoomTemperatures_ArchiveProperty.ValidTo, FilterConditions.Equals, coldroomtemperatures_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 6);
        }
        private static ColdRoomTemperatures_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new ColdRoomTemperatures_Archive
            {
                ColdRoomTemperatureID = r.GetInt64(0),
                ColdRoomSensorNumber = r.GetInt32(1),
                RecordedWhen = r.GetDateTime(2),
                Temperature = r.GetDecimal(3),
                ValidFrom = r.GetDateTime(4),
                ValidTo = r.GetDateTime(5),
            };
        }
        #endregion
    }
}
