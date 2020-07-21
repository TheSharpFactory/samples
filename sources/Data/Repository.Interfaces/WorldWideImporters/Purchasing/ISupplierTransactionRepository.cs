/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing
{
    public partial interface ISupplierTransactionRepository
    {
    }
}

************************************************/

using System.Collections.Generic;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a SupplierTransaction.
    /// </summary>
    public partial interface ISupplierTransactionRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="suppliertransactionid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction ByPK(int suppliertransactionid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="suppliertransactionid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction ByPK(int suppliertransactionid, NavProps<SupplierTransactionNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        List<SupplierTransaction> Top(int topcount, Query<SupplierTransactionProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        List<SupplierTransaction> Top(int topcount, Query<SupplierTransactionProperty, SupplierTransactionNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction FirstOrDefault(Query<SupplierTransactionProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction FirstOrDefault(Query<SupplierTransactionProperty, SupplierTransactionNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction First(Query<SupplierTransactionProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction First(Query<SupplierTransactionProperty, SupplierTransactionNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction SingleOrDefault(Query<SupplierTransactionProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction SingleOrDefault(Query<SupplierTransactionProperty, SupplierTransactionNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction Single(Query<SupplierTransactionProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        SupplierTransaction Single(Query<SupplierTransactionProperty, SupplierTransactionNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        List<SupplierTransaction> ToList(Query<SupplierTransactionProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        List<SupplierTransaction> ToList(Query<SupplierTransactionProperty, SupplierTransactionNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        List<SupplierTransaction> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction in the database.
        /// </summary>
        /// <param name="suppliertransaction">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(SupplierTransaction suppliertransaction);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the list in the database.
        /// </summary>
        /// <param name="suppliertransactions">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction to create.</param>
        /// <returns>void</returns>
        void Create(List<SupplierTransaction> suppliertransactions);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliertransaction">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(SupplierTransaction suppliertransaction);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<SupplierTransaction> Update(Query<SupplierTransactionProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(SupplierTransaction original, SupplierTransaction changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliertransaction">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(SupplierTransaction suppliertransaction);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliertransactions">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction to update.</param>
        /// <returns>void</returns>
        void Update(List<SupplierTransaction> suppliertransactions);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="suppliertransactions">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<SupplierTransaction> suppliertransactions);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="suppliertransactionid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int suppliertransactionid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database.
        /// </summary>
        /// <param name="suppliertransaction">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(SupplierTransaction suppliertransaction);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<SupplierTransactionProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction in the list from the database.
        /// </summary>
        /// <param name="suppliertransactions">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction to delete.</param>
        /// <returns>void</returns>
        void Delete(List<SupplierTransaction> suppliertransactions);
        #endregion
    }
}
