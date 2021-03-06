/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse
{
    public partial interface IStockItemTransactionRepository
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
    /// This interface represents the contract to exchange data with a Repository for a StockItemTransaction.
    /// </summary>
    public partial interface IStockItemTransactionRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemtransactionid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction ByPK(int stockitemtransactionid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemtransactionid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction ByPK(int stockitemtransactionid, NavProps<StockItemTransactionNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        List<StockItemTransaction> Top(int topcount, Query<StockItemTransactionProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        List<StockItemTransaction> Top(int topcount, Query<StockItemTransactionProperty, StockItemTransactionNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction FirstOrDefault(Query<StockItemTransactionProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction FirstOrDefault(Query<StockItemTransactionProperty, StockItemTransactionNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction First(Query<StockItemTransactionProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction First(Query<StockItemTransactionProperty, StockItemTransactionNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction SingleOrDefault(Query<StockItemTransactionProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction SingleOrDefault(Query<StockItemTransactionProperty, StockItemTransactionNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction Single(Query<StockItemTransactionProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        StockItemTransaction Single(Query<StockItemTransactionProperty, StockItemTransactionNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        List<StockItemTransaction> ToList(Query<StockItemTransactionProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        List<StockItemTransaction> ToList(Query<StockItemTransactionProperty, StockItemTransactionNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction</returns>
        List<StockItemTransaction> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction in the database.
        /// </summary>
        /// <param name="stockitemtransaction">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(StockItemTransaction stockitemtransaction);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the list in the database.
        /// </summary>
        /// <param name="stockitemtransactions">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction to create.</param>
        /// <returns>void</returns>
        void Create(List<StockItemTransaction> stockitemtransactions);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemtransaction">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(StockItemTransaction stockitemtransaction);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<StockItemTransaction> Update(Query<StockItemTransactionProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(StockItemTransaction original, StockItemTransaction changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemtransaction">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(StockItemTransaction stockitemtransaction);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemtransactions">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction to update.</param>
        /// <returns>void</returns>
        void Update(List<StockItemTransaction> stockitemtransactions);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stockitemtransactions">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<StockItemTransaction> stockitemtransactions);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemtransactionid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int stockitemtransactionid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction from the database.
        /// </summary>
        /// <param name="stockitemtransaction">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(StockItemTransaction stockitemtransaction);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<StockItemTransactionProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction in the list from the database.
        /// </summary>
        /// <param name="stockitemtransactions">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction to delete.</param>
        /// <returns>void</returns>
        void Delete(List<StockItemTransaction> stockitemtransactions);
        #endregion
    }
}
