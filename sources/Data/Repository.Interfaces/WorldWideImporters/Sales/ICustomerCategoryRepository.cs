/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales
{
    public partial interface ICustomerCategoryRepository
    {
    }
}

************************************************/

using System.Collections.Generic;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a CustomerCategory.
    /// </summary>
    public partial interface ICustomerCategoryRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Primary Key.
        /// </summary>
        /// <param name="customercategoryid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory ByPK(int customercategoryid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="customercategoryid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory ByPK(int customercategoryid, NavProps<CustomerCategoryNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Unique Key named UQ_Sales_CustomerCategories_CustomerCategoryName.
        /// </summary>
        /// <param name="customercategoryname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory ByUK(string customercategoryname);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Unique Key named UQ_Sales_CustomerCategories_CustomerCategoryName. Supports navigation properties.
        /// </summary>
        /// <param name="customercategoryname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory ByUK(string customercategoryname, NavProps<CustomerCategoryNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        List<CustomerCategory> Top(int topcount, Query<CustomerCategoryProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        List<CustomerCategory> Top(int topcount, Query<CustomerCategoryProperty, CustomerCategoryNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory FirstOrDefault(Query<CustomerCategoryProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory FirstOrDefault(Query<CustomerCategoryProperty, CustomerCategoryNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory First(Query<CustomerCategoryProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory First(Query<CustomerCategoryProperty, CustomerCategoryNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory SingleOrDefault(Query<CustomerCategoryProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory SingleOrDefault(Query<CustomerCategoryProperty, CustomerCategoryNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory Single(Query<CustomerCategoryProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        CustomerCategory Single(Query<CustomerCategoryProperty, CustomerCategoryNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        List<CustomerCategory> ToList(Query<CustomerCategoryProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        List<CustomerCategory> ToList(Query<CustomerCategoryProperty, CustomerCategoryNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        List<CustomerCategory> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory in the database.
        /// </summary>
        /// <param name="customercategory">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(CustomerCategory customercategory);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the list in the database.
        /// </summary>
        /// <param name="customercategories">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory to create.</param>
        /// <returns>void</returns>
        void Create(List<CustomerCategory> customercategories);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="customercategory">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(CustomerCategory customercategory);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<CustomerCategory> Update(Query<CustomerCategoryProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(CustomerCategory original, CustomerCategory changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="customercategory">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(CustomerCategory customercategory);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="customercategories">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory to update.</param>
        /// <returns>void</returns>
        void Update(List<CustomerCategory> customercategories);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="customercategories">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<CustomerCategory> customercategories);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Primary Key.
        /// </summary>
        /// <param name="customercategoryid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int customercategoryid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Unique Key named UQ_Sales_CustomerCategories_CustomerCategoryName
        /// </summary>
        /// <param name="customercategoryname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string customercategoryname);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database.
        /// </summary>
        /// <param name="customercategory">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(CustomerCategory customercategory);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<CustomerCategoryProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory in the list from the database.
        /// </summary>
        /// <param name="customercategories">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory to delete.</param>
        /// <returns>void</returns>
        void Delete(List<CustomerCategory> customercategories);
        #endregion
    }
}
