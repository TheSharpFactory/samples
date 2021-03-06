/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing
{
    public partial interface ISupplierCategoryRepository
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
    /// This interface represents the contract to exchange data with a Repository for a SupplierCategory.
    /// </summary>
    public partial interface ISupplierCategoryRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Primary Key.
        /// </summary>
        /// <param name="suppliercategoryid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory ByPK(int suppliercategoryid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="suppliercategoryid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory ByPK(int suppliercategoryid, NavProps<SupplierCategoryNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Unique Key named UQ_Purchasing_SupplierCategories_SupplierCategoryName.
        /// </summary>
        /// <param name="suppliercategoryname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory ByUK(string suppliercategoryname);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Unique Key named UQ_Purchasing_SupplierCategories_SupplierCategoryName. Supports navigation properties.
        /// </summary>
        /// <param name="suppliercategoryname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory ByUK(string suppliercategoryname, NavProps<SupplierCategoryNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        List<SupplierCategory> Top(int topcount, Query<SupplierCategoryProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        List<SupplierCategory> Top(int topcount, Query<SupplierCategoryProperty, SupplierCategoryNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory FirstOrDefault(Query<SupplierCategoryProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory FirstOrDefault(Query<SupplierCategoryProperty, SupplierCategoryNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory First(Query<SupplierCategoryProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory First(Query<SupplierCategoryProperty, SupplierCategoryNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory SingleOrDefault(Query<SupplierCategoryProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory SingleOrDefault(Query<SupplierCategoryProperty, SupplierCategoryNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory Single(Query<SupplierCategoryProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        SupplierCategory Single(Query<SupplierCategoryProperty, SupplierCategoryNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        List<SupplierCategory> ToList(Query<SupplierCategoryProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        List<SupplierCategory> ToList(Query<SupplierCategoryProperty, SupplierCategoryNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        List<SupplierCategory> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory in the database.
        /// </summary>
        /// <param name="suppliercategory">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(SupplierCategory suppliercategory);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the list in the database.
        /// </summary>
        /// <param name="suppliercategories">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory to create.</param>
        /// <returns>void</returns>
        void Create(List<SupplierCategory> suppliercategories);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliercategory">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(SupplierCategory suppliercategory);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<SupplierCategory> Update(Query<SupplierCategoryProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(SupplierCategory original, SupplierCategory changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliercategory">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(SupplierCategory suppliercategory);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliercategories">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory to update.</param>
        /// <returns>void</returns>
        void Update(List<SupplierCategory> suppliercategories);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliercategories">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<SupplierCategory> suppliercategories);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Primary Key.
        /// </summary>
        /// <param name="suppliercategoryid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int suppliercategoryid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Unique Key named UQ_Purchasing_SupplierCategories_SupplierCategoryName
        /// </summary>
        /// <param name="suppliercategoryname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string suppliercategoryname);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database.
        /// </summary>
        /// <param name="suppliercategory">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(SupplierCategory suppliercategory);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<SupplierCategoryProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory in the list from the database.
        /// </summary>
        /// <param name="suppliercategories">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory to delete.</param>
        /// <returns>void</returns>
        void Delete(List<SupplierCategory> suppliercategories);
        #endregion
    }
}
