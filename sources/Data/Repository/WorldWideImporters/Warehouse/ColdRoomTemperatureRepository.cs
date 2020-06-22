/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class ColdRoomTemperatureRepository
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
    /// This class represents the Repository for: ColdRoomTemperature.
    /// </summary>
    public partial class ColdRoomTemperatureRepository:WritableRepositoryBase<ColdRoomTemperature, ColdRoomTemperatureProperty>, IColdRoomTemperatureRepository
    {
        #region Constructors
        public ColdRoomTemperatureRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_ColdRoomTemperature;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Warehouse_ColdRoomTemperatures) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<ColdRoomTemperatureProperty>(1){ SortFilter.New(ColdRoomTemperatureProperty.ColdRoomTemperatureID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database by Primary Key.
        /// </summary>
        /// <param name="coldroomtemperatureid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature</returns>
        public ColdRoomTemperature ByPK(long coldroomtemperatureid)
        {
            var where = new QueryFilters<ColdRoomTemperatureProperty>(1){QueryFilter.New(ColdRoomTemperatureProperty.ColdRoomTemperatureID, FilterConditions.Equals, coldroomtemperatureid ), };
            return SelectSingle(where, DefaultSort);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database by Primary Key.
        /// </summary>
        /// <param name="coldroomtemperatureid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(long coldroomtemperatureid)
        {
            var where = new QueryFilters<ColdRoomTemperatureProperty>(1){QueryFilter.New(ColdRoomTemperatureProperty.ColdRoomTemperatureID, FilterConditions.Equals, coldroomtemperatureid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<ColdRoomTemperatureProperty> ComposeKeys(ColdRoomTemperature coldroomtemperature)
        {
            return new QueryFilters<ColdRoomTemperatureProperty>{ QueryFilter.New(ColdRoomTemperatureProperty.ColdRoomTemperatureID, FilterConditions.Equals, coldroomtemperature.ColdRoomTemperatureID) };
        }
        protected override QueryFilters<ColdRoomTemperatureProperty> GetChanges(ColdRoomTemperature original, ColdRoomTemperature changed)
        {
            return ColdRoomTemperatureUtils.GetChanges(original, changed);
        }
        protected override void Merge(ColdRoomTemperature source, ColdRoomTemperature target)
        {
            ColdRoomTemperatureUtils.Merge(source, target);
        }
        protected override QueryFilters<ColdRoomTemperatureProperty> ComposeInsertPredicate(ColdRoomTemperature coldroomtemperature)
        {
            return new QueryFilters<ColdRoomTemperatureProperty>{ QueryFilter.New(ColdRoomTemperatureProperty.ColdRoomSensorNumber, FilterConditions.Equals, coldroomtemperature.ColdRoomSensorNumber), QueryFilter.New(ColdRoomTemperatureProperty.RecordedWhen, FilterConditions.Equals, coldroomtemperature.RecordedWhen), QueryFilter.New(ColdRoomTemperatureProperty.Temperature, FilterConditions.Equals, coldroomtemperature.Temperature) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 6);
        }
        private static ColdRoomTemperature MaterializeSingleEntity(SqlDataReader r)
        {
            return new ColdRoomTemperature
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
