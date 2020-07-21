/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse
{
    public partial interface IPackageTypeRepository
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
    /// This interface represents the contract to exchange data with a Repository for a PackageType.
    /// </summary>
    public partial interface IPackageTypeRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Primary Key.
        /// </summary>
        /// <param name="packagetypeid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType ByPK(int packagetypeid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="packagetypeid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType ByPK(int packagetypeid, NavProps<PackageTypeNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Unique Key named UQ_Warehouse_PackageTypes_PackageTypeName.
        /// </summary>
        /// <param name="packagetypename">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType ByUK(string packagetypename);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Unique Key named UQ_Warehouse_PackageTypes_PackageTypeName. Supports navigation properties.
        /// </summary>
        /// <param name="packagetypename">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType ByUK(string packagetypename, NavProps<PackageTypeNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        List<PackageType> Top(int topcount, Query<PackageTypeProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        List<PackageType> Top(int topcount, Query<PackageTypeProperty, PackageTypeNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType FirstOrDefault(Query<PackageTypeProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType FirstOrDefault(Query<PackageTypeProperty, PackageTypeNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType First(Query<PackageTypeProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType First(Query<PackageTypeProperty, PackageTypeNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType SingleOrDefault(Query<PackageTypeProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType SingleOrDefault(Query<PackageTypeProperty, PackageTypeNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType Single(Query<PackageTypeProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        PackageType Single(Query<PackageTypeProperty, PackageTypeNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        List<PackageType> ToList(Query<PackageTypeProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        List<PackageType> ToList(Query<PackageTypeProperty, PackageTypeNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType</returns>
        List<PackageType> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType in the database.
        /// </summary>
        /// <param name="packagetype">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(PackageType packagetype);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the list in the database.
        /// </summary>
        /// <param name="packagetypes">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType to create.</param>
        /// <returns>void</returns>
        void Create(List<PackageType> packagetypes);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="packagetype">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(PackageType packagetype);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<PackageType> Update(Query<PackageTypeProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(PackageType original, PackageType changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="packagetype">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(PackageType packagetype);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="packagetypes">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType to update.</param>
        /// <returns>void</returns>
        void Update(List<PackageType> packagetypes);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="packagetypes">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<PackageType> packagetypes);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Primary Key.
        /// </summary>
        /// <param name="packagetypeid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int packagetypeid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database by Unique Key named UQ_Warehouse_PackageTypes_PackageTypeName
        /// </summary>
        /// <param name="packagetypename">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string packagetypename);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType from the database.
        /// </summary>
        /// <param name="packagetype">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(PackageType packagetype);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<PackageTypeProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType in the list from the database.
        /// </summary>
        /// <param name="packagetypes">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType to delete.</param>
        /// <returns>void</returns>
        void Delete(List<PackageType> packagetypes);
        #endregion
    }
}
