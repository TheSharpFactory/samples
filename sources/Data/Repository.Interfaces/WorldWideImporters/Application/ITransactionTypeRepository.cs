/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application
{
    public partial interface ITransactionTypeRepository
    {
    }
}

************************************************/

using System.Collections.Generic;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Application;

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a TransactionType.
    /// </summary>
    public partial interface ITransactionTypeRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Primary Key.
        /// </summary>
        /// <param name="transactiontypeid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType ByPK(int transactiontypeid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="transactiontypeid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType ByPK(int transactiontypeid, NavProps<TransactionTypeNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Unique Key named UQ_Application_TransactionTypes_TransactionTypeName.
        /// </summary>
        /// <param name="transactiontypename">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType ByUK(string transactiontypename);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Unique Key named UQ_Application_TransactionTypes_TransactionTypeName. Supports navigation properties.
        /// </summary>
        /// <param name="transactiontypename">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType ByUK(string transactiontypename, NavProps<TransactionTypeNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        List<TransactionType> Top(int topcount, Query<TransactionTypeProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        List<TransactionType> Top(int topcount, Query<TransactionTypeProperty, TransactionTypeNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType FirstOrDefault(Query<TransactionTypeProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType FirstOrDefault(Query<TransactionTypeProperty, TransactionTypeNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType First(Query<TransactionTypeProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType First(Query<TransactionTypeProperty, TransactionTypeNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType SingleOrDefault(Query<TransactionTypeProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType SingleOrDefault(Query<TransactionTypeProperty, TransactionTypeNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType Single(Query<TransactionTypeProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        TransactionType Single(Query<TransactionTypeProperty, TransactionTypeNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        List<TransactionType> ToList(Query<TransactionTypeProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        List<TransactionType> ToList(Query<TransactionTypeProperty, TransactionTypeNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType</returns>
        List<TransactionType> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType in the database.
        /// </summary>
        /// <param name="transactiontype">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(TransactionType transactiontype);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the list in the database.
        /// </summary>
        /// <param name="transactiontypes">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType to create.</param>
        /// <returns>void</returns>
        void Create(List<TransactionType> transactiontypes);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="transactiontype">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(TransactionType transactiontype);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<TransactionType> Update(Query<TransactionTypeProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(TransactionType original, TransactionType changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="transactiontype">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(TransactionType transactiontype);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="transactiontypes">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType to update.</param>
        /// <returns>void</returns>
        void Update(List<TransactionType> transactiontypes);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="transactiontypes">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<TransactionType> transactiontypes);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Primary Key.
        /// </summary>
        /// <param name="transactiontypeid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int transactiontypeid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database by Unique Key named UQ_Application_TransactionTypes_TransactionTypeName
        /// </summary>
        /// <param name="transactiontypename">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string transactiontypename);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType from the database.
        /// </summary>
        /// <param name="transactiontype">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(TransactionType transactiontype);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<TransactionTypeProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType in the list from the database.
        /// </summary>
        /// <param name="transactiontypes">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType to delete.</param>
        /// <returns>void</returns>
        void Delete(List<TransactionType> transactiontypes);
        #endregion
    }
}
