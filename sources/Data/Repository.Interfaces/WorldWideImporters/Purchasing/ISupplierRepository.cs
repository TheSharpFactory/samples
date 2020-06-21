/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing
{
    public partial interface ISupplierRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a Supplier.
    /// </summary>
    public partial interface ISupplierRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Primary Key.
        /// </summary>
        /// <param name="supplierid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier ByPK(int supplierid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="supplierid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier ByPK(int supplierid, NavProps<SupplierNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Unique Key named UQ_Purchasing_Suppliers_SupplierName.
        /// </summary>
        /// <param name="suppliername">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier ByUK(string suppliername);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Unique Key named UQ_Purchasing_Suppliers_SupplierName. Supports navigation properties.
        /// </summary>
        /// <param name="suppliername">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier ByUK(string suppliername, NavProps<SupplierNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        List<Supplier> Top(int topcount, Query<SupplierProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        List<Supplier> Top(int topcount, Query<SupplierProperty, SupplierNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier FirstOrDefault(Query<SupplierProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier FirstOrDefault(Query<SupplierProperty, SupplierNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier First(Query<SupplierProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier First(Query<SupplierProperty, SupplierNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier SingleOrDefault(Query<SupplierProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier SingleOrDefault(Query<SupplierProperty, SupplierNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier Single(Query<SupplierProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        Supplier Single(Query<SupplierProperty, SupplierNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        List<Supplier> ToList(Query<SupplierProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        List<Supplier> ToList(Query<SupplierProperty, SupplierNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier</returns>
        List<Supplier> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier in the database.
        /// </summary>
        /// <param name="supplier">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(Supplier supplier);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the list in the database.
        /// </summary>
        /// <param name="suppliers">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier to create.</param>
        /// <returns>void</returns>
        void Create(List<Supplier> suppliers);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="supplier">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(Supplier supplier);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<Supplier> Update(Query<SupplierProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(Supplier original, Supplier changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="supplier">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(Supplier supplier);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliers">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier to update.</param>
        /// <returns>void</returns>
        void Update(List<Supplier> suppliers);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliers">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<Supplier> suppliers);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Primary Key.
        /// </summary>
        /// <param name="supplierid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int supplierid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database by Unique Key named UQ_Purchasing_Suppliers_SupplierName
        /// </summary>
        /// <param name="suppliername">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string suppliername);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier from the database.
        /// </summary>
        /// <param name="supplier">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(Supplier supplier);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<SupplierProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier in the list from the database.
        /// </summary>
        /// <param name="suppliers">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier to delete.</param>
        /// <returns>void</returns>
        void Delete(List<Supplier> suppliers);
        #endregion
    }
}
