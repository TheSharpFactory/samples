/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse
{
    public partial interface IColdRoomTemperatureRepository
    {
    }
}

************************************************/

using System.Collections.Generic;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a ColdRoomTemperature.
    /// </summary>
    public partial interface IColdRoomTemperatureRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database by Primary Key.
        /// </summary>
        /// <param name="coldroomtemperatureid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature</returns>
        ColdRoomTemperature ByPK(long coldroomtemperatureid);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature</returns>
        List<ColdRoomTemperature> Top(int topcount, Query<ColdRoomTemperatureProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature</returns>
        ColdRoomTemperature FirstOrDefault(Query<ColdRoomTemperatureProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature</returns>
        ColdRoomTemperature First(Query<ColdRoomTemperatureProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature</returns>
        ColdRoomTemperature SingleOrDefault(Query<ColdRoomTemperatureProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature</returns>
        ColdRoomTemperature Single(Query<ColdRoomTemperatureProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature</returns>
        List<ColdRoomTemperature> ToList(Query<ColdRoomTemperatureProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature</returns>
        List<ColdRoomTemperature> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature in the database.
        /// </summary>
        /// <param name="coldroomtemperature">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(ColdRoomTemperature coldroomtemperature);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the list in the database.
        /// </summary>
        /// <param name="coldroomtemperatures">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature to create.</param>
        /// <returns>void</returns>
        void Create(List<ColdRoomTemperature> coldroomtemperatures);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="coldroomtemperature">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(ColdRoomTemperature coldroomtemperature);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<ColdRoomTemperature> Update(Query<ColdRoomTemperatureProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(ColdRoomTemperature original, ColdRoomTemperature changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="coldroomtemperature">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(ColdRoomTemperature coldroomtemperature);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="coldroomtemperatures">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature to update.</param>
        /// <returns>void</returns>
        void Update(List<ColdRoomTemperature> coldroomtemperatures);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="coldroomtemperatures">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<ColdRoomTemperature> coldroomtemperatures);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database by Primary Key.
        /// </summary>
        /// <param name="coldroomtemperatureid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(long coldroomtemperatureid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature from the database.
        /// </summary>
        /// <param name="coldroomtemperature">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(ColdRoomTemperature coldroomtemperature);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<ColdRoomTemperatureProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature in the list from the database.
        /// </summary>
        /// <param name="coldroomtemperatures">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.ColdRoomTemperature to delete.</param>
        /// <returns>void</returns>
        void Delete(List<ColdRoomTemperature> coldroomtemperatures);
        #endregion
    }
}
