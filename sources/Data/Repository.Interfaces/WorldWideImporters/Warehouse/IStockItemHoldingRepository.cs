/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse
{
    public partial interface IStockItemHoldingRepository
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
    /// This interface represents the contract to exchange data with a Repository for a StockItemHolding.
    /// </summary>
    public partial interface IStockItemHoldingRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding ByPK(int stockitemid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding ByPK(int stockitemid, NavProps<StockItemHoldingNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        List<StockItemHolding> Top(int topcount, Query<StockItemHoldingProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        List<StockItemHolding> Top(int topcount, Query<StockItemHoldingProperty, StockItemHoldingNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding FirstOrDefault(Query<StockItemHoldingProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding FirstOrDefault(Query<StockItemHoldingProperty, StockItemHoldingNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding First(Query<StockItemHoldingProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding First(Query<StockItemHoldingProperty, StockItemHoldingNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding SingleOrDefault(Query<StockItemHoldingProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding SingleOrDefault(Query<StockItemHoldingProperty, StockItemHoldingNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding Single(Query<StockItemHoldingProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        StockItemHolding Single(Query<StockItemHoldingProperty, StockItemHoldingNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        List<StockItemHolding> ToList(Query<StockItemHoldingProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        List<StockItemHolding> ToList(Query<StockItemHoldingProperty, StockItemHoldingNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        List<StockItemHolding> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding in the database.
        /// </summary>
        /// <param name="stockitemholding">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(StockItemHolding stockitemholding);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the list in the database.
        /// </summary>
        /// <param name="stockitemholdings">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding to create.</param>
        /// <returns>void</returns>
        void Create(List<StockItemHolding> stockitemholdings);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemholding">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(StockItemHolding stockitemholding);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<StockItemHolding> Update(Query<StockItemHoldingProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(StockItemHolding original, StockItemHolding changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemholding">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(StockItemHolding stockitemholding);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemholdings">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding to update.</param>
        /// <returns>void</returns>
        void Update(List<StockItemHolding> stockitemholdings);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemholdings">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<StockItemHolding> stockitemholdings);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int stockitemid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database.
        /// </summary>
        /// <param name="stockitemholding">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(StockItemHolding stockitemholding);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<StockItemHoldingProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding in the list from the database.
        /// </summary>
        /// <param name="stockitemholdings">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding to delete.</param>
        /// <returns>void</returns>
        void Delete(List<StockItemHolding> stockitemholdings);
        #endregion
    }
}
