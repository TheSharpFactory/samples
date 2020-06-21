/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales
{
    public partial interface IBuyingGroupRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a BuyingGroup.
    /// </summary>
    public partial interface IBuyingGroupRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database by Primary Key.
        /// </summary>
        /// <param name="buyinggroupid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup ByPK(int buyinggroupid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="buyinggroupid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup ByPK(int buyinggroupid, NavProps<BuyingGroupNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database by Unique Key named UQ_Sales_BuyingGroups_BuyingGroupName.
        /// </summary>
        /// <param name="buyinggroupname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup ByUK(string buyinggroupname);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database by Unique Key named UQ_Sales_BuyingGroups_BuyingGroupName. Supports navigation properties.
        /// </summary>
        /// <param name="buyinggroupname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup ByUK(string buyinggroupname, NavProps<BuyingGroupNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        List<BuyingGroup> Top(int topcount, Query<BuyingGroupProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        List<BuyingGroup> Top(int topcount, Query<BuyingGroupProperty, BuyingGroupNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup FirstOrDefault(Query<BuyingGroupProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup FirstOrDefault(Query<BuyingGroupProperty, BuyingGroupNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup First(Query<BuyingGroupProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup First(Query<BuyingGroupProperty, BuyingGroupNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup SingleOrDefault(Query<BuyingGroupProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup SingleOrDefault(Query<BuyingGroupProperty, BuyingGroupNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup Single(Query<BuyingGroupProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        BuyingGroup Single(Query<BuyingGroupProperty, BuyingGroupNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        List<BuyingGroup> ToList(Query<BuyingGroupProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        List<BuyingGroup> ToList(Query<BuyingGroupProperty, BuyingGroupNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup</returns>
        List<BuyingGroup> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup in the database.
        /// </summary>
        /// <param name="buyinggroup">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(BuyingGroup buyinggroup);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the list in the database.
        /// </summary>
        /// <param name="buyinggroups">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup to create.</param>
        /// <returns>void</returns>
        void Create(List<BuyingGroup> buyinggroups);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="buyinggroup">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(BuyingGroup buyinggroup);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<BuyingGroup> Update(Query<BuyingGroupProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(BuyingGroup original, BuyingGroup changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="buyinggroup">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(BuyingGroup buyinggroup);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="buyinggroups">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup to update.</param>
        /// <returns>void</returns>
        void Update(List<BuyingGroup> buyinggroups);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="buyinggroups">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<BuyingGroup> buyinggroups);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database by Primary Key.
        /// </summary>
        /// <param name="buyinggroupid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int buyinggroupid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database by Unique Key named UQ_Sales_BuyingGroups_BuyingGroupName
        /// </summary>
        /// <param name="buyinggroupname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string buyinggroupname);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup from the database.
        /// </summary>
        /// <param name="buyinggroup">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(BuyingGroup buyinggroup);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<BuyingGroupProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup in the list from the database.
        /// </summary>
        /// <param name="buyinggroups">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup to delete.</param>
        /// <returns>void</returns>
        void Delete(List<BuyingGroup> buyinggroups);
        #endregion
    }
}
