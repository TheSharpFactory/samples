/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse
{
    public partial interface IStockItemStockGroupRepository
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
    /// This interface represents the contract to exchange data with a Repository for a StockItemStockGroup.
    /// </summary>
    public partial interface IStockItemStockGroupRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemstockgroupid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup ByPK(int stockitemstockgroupid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemstockgroupid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup ByPK(int stockitemstockgroupid, NavProps<StockItemStockGroupNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockGroupID_Lookup.
        /// </summary>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup ByUK1(int stockgroupid, int stockitemid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockGroupID_Lookup. Supports navigation properties.
        /// </summary>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup ByUK1(int stockgroupid, int stockitemid, NavProps<StockItemStockGroupNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockItemID_Lookup.
        /// </summary>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup ByUK2(int stockitemid, int stockgroupid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockItemID_Lookup. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup ByUK2(int stockitemid, int stockgroupid, NavProps<StockItemStockGroupNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        List<StockItemStockGroup> Top(int topcount, Query<StockItemStockGroupProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        List<StockItemStockGroup> Top(int topcount, Query<StockItemStockGroupProperty, StockItemStockGroupNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup FirstOrDefault(Query<StockItemStockGroupProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup FirstOrDefault(Query<StockItemStockGroupProperty, StockItemStockGroupNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup First(Query<StockItemStockGroupProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup First(Query<StockItemStockGroupProperty, StockItemStockGroupNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup SingleOrDefault(Query<StockItemStockGroupProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup SingleOrDefault(Query<StockItemStockGroupProperty, StockItemStockGroupNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup Single(Query<StockItemStockGroupProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        StockItemStockGroup Single(Query<StockItemStockGroupProperty, StockItemStockGroupNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        List<StockItemStockGroup> ToList(Query<StockItemStockGroupProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        List<StockItemStockGroup> ToList(Query<StockItemStockGroupProperty, StockItemStockGroupNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        List<StockItemStockGroup> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup in the database.
        /// </summary>
        /// <param name="stockitemstockgroup">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(StockItemStockGroup stockitemstockgroup);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the list in the database.
        /// </summary>
        /// <param name="stockitemstockgroups">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup to create.</param>
        /// <returns>void</returns>
        void Create(List<StockItemStockGroup> stockitemstockgroups);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemstockgroup">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(StockItemStockGroup stockitemstockgroup);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<StockItemStockGroup> Update(Query<StockItemStockGroupProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(StockItemStockGroup original, StockItemStockGroup changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemstockgroup">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(StockItemStockGroup stockitemstockgroup);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemstockgroups">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup to update.</param>
        /// <returns>void</returns>
        void Update(List<StockItemStockGroup> stockitemstockgroups);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemstockgroups">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<StockItemStockGroup> stockitemstockgroups);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemstockgroupid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int stockitemstockgroupid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockGroupID_Lookup
        /// </summary>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK1(int stockgroupid, int stockitemid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockItemID_Lookup
        /// </summary>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK2(int stockitemid, int stockgroupid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database.
        /// </summary>
        /// <param name="stockitemstockgroup">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(StockItemStockGroup stockitemstockgroup);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<StockItemStockGroupProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup in the list from the database.
        /// </summary>
        /// <param name="stockitemstockgroups">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup to delete.</param>
        /// <returns>void</returns>
        void Delete(List<StockItemStockGroup> stockitemstockgroups);
        #endregion
    }
}
