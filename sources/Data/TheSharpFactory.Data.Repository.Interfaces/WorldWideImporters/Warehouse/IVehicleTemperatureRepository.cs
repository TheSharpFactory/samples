/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse
{
    public partial interface IVehicleTemperatureRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a VehicleTemperature.
    /// </summary>
    public partial interface IVehicleTemperatureRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database by Primary Key.
        /// </summary>
        /// <param name="vehicletemperatureid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature</returns>
        VehicleTemperature ByPK(long vehicletemperatureid);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature</returns>
        List<VehicleTemperature> Top(int topcount, Query<VehicleTemperatureProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature</returns>
        VehicleTemperature FirstOrDefault(Query<VehicleTemperatureProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature</returns>
        VehicleTemperature First(Query<VehicleTemperatureProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature</returns>
        VehicleTemperature SingleOrDefault(Query<VehicleTemperatureProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature</returns>
        VehicleTemperature Single(Query<VehicleTemperatureProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature</returns>
        List<VehicleTemperature> ToList(Query<VehicleTemperatureProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature</returns>
        List<VehicleTemperature> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature in the database.
        /// </summary>
        /// <param name="vehicletemperature">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(VehicleTemperature vehicletemperature);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the list in the database.
        /// </summary>
        /// <param name="vehicletemperatures">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature to create.</param>
        /// <returns>void</returns>
        void Create(List<VehicleTemperature> vehicletemperatures);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="vehicletemperature">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(VehicleTemperature vehicletemperature);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<VehicleTemperature> Update(Query<VehicleTemperatureProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(VehicleTemperature original, VehicleTemperature changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="vehicletemperature">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(VehicleTemperature vehicletemperature);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="vehicletemperatures">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature to update.</param>
        /// <returns>void</returns>
        void Update(List<VehicleTemperature> vehicletemperatures);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="vehicletemperatures">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<VehicleTemperature> vehicletemperatures);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database by Primary Key.
        /// </summary>
        /// <param name="vehicletemperatureid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(long vehicletemperatureid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature from the database.
        /// </summary>
        /// <param name="vehicletemperature">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(VehicleTemperature vehicletemperature);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<VehicleTemperatureProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature in the list from the database.
        /// </summary>
        /// <param name="vehicletemperatures">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.VehicleTemperature to delete.</param>
        /// <returns>void</returns>
        void Delete(List<VehicleTemperature> vehicletemperatures);
        #endregion
    }
}
