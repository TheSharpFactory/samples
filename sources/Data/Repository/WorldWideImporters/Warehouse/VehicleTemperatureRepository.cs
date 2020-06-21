/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class VehicleTemperatureRepository
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
    /// This class represents the Repository for: VehicleTemperature.
    /// </summary>
    public partial class VehicleTemperatureRepository:WritableRepositoryBase<VehicleTemperature, VehicleTemperatureProperty>, IVehicleTemperatureRepository
    {
        #region Constructors
        public VehicleTemperatureRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_VehicleTemperature;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Warehouse_VehicleTemperatures) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<VehicleTemperatureProperty>(1){ SortFilter.New(VehicleTemperatureProperty.VehicleTemperatureID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database by Primary Key.
        /// </summary>
        /// <param name="vehicletemperatureid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature</returns>
        public VehicleTemperature ByPK(long vehicletemperatureid)
        {
            var where = new QueryFilters<VehicleTemperatureProperty>(1){QueryFilter.New(VehicleTemperatureProperty.VehicleTemperatureID, FilterConditions.Equals, vehicletemperatureid ), };
            return SelectSingle(where, DefaultSort);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database by Primary Key.
        /// </summary>
        /// <param name="vehicletemperatureid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(long vehicletemperatureid)
        {
            var where = new QueryFilters<VehicleTemperatureProperty>(1){QueryFilter.New(VehicleTemperatureProperty.VehicleTemperatureID, FilterConditions.Equals, vehicletemperatureid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<VehicleTemperatureProperty> ComposeKeys(VehicleTemperature vehicletemperature)
        {
            return new QueryFilters<VehicleTemperatureProperty>{ QueryFilter.New(VehicleTemperatureProperty.VehicleTemperatureID, FilterConditions.Equals, vehicletemperature.VehicleTemperatureID) };
        }
        protected override QueryFilters<VehicleTemperatureProperty> GetChanges(VehicleTemperature original, VehicleTemperature changed)
        {
            return VehicleTemperatureUtils.GetChanges(original, changed);
        }
        protected override void Merge(VehicleTemperature source, VehicleTemperature target)
        {
            VehicleTemperatureUtils.Merge(source, target);
        }
        protected override QueryFilters<VehicleTemperatureProperty> ComposeInsertPredicate(VehicleTemperature vehicletemperature)
        {
            return new QueryFilters<VehicleTemperatureProperty>{ QueryFilter.New(VehicleTemperatureProperty.VehicleRegistration, FilterConditions.Equals, vehicletemperature.VehicleRegistration), QueryFilter.New(VehicleTemperatureProperty.ChillerSensorNumber, FilterConditions.Equals, vehicletemperature.ChillerSensorNumber), QueryFilter.New(VehicleTemperatureProperty.RecordedWhen, FilterConditions.Equals, vehicletemperature.RecordedWhen), QueryFilter.New(VehicleTemperatureProperty.Temperature, FilterConditions.Equals, vehicletemperature.Temperature), QueryFilter.New(VehicleTemperatureProperty.FullSensorData, FilterConditions.Equals, vehicletemperature.FullSensorData), QueryFilter.New(VehicleTemperatureProperty.IsCompressed, FilterConditions.Equals, vehicletemperature.IsCompressed), QueryFilter.New(VehicleTemperatureProperty.CompressedSensorData, FilterConditions.Equals, vehicletemperature.CompressedSensorData) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 8);
        }
        private static VehicleTemperature MaterializeSingleEntity(SqlDataReader r)
        {
            return new VehicleTemperature
            {
                VehicleTemperatureID = r.GetInt64(0),
                VehicleRegistration = r.GetString(1),
                ChillerSensorNumber = r.GetInt32(2),
                RecordedWhen = r.GetDateTime(3),
                Temperature = r.GetDecimal(4),
                FullSensorData = r.GetValue(5) as string,
                IsCompressed = r.GetBoolean(6),
                CompressedSensorData = r.GetValue(7) as byte[],
            };
        }
        #endregion
    }
}
