/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse
{
    public partial interface IColors_ArchiveRepository
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
    /// This interface represents the contract to exchange data with a Repository for a Colors_Archive.
    /// </summary>
    public partial interface IColors_ArchiveRepository
    {
        #region Get
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive</returns>
        List<Colors_Archive> Top(int topcount, Query<Colors_ArchiveProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive</returns>
        Colors_Archive FirstOrDefault(Query<Colors_ArchiveProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive</returns>
        Colors_Archive First(Query<Colors_ArchiveProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive</returns>
        Colors_Archive SingleOrDefault(Query<Colors_ArchiveProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive</returns>
        Colors_Archive Single(Query<Colors_ArchiveProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive</returns>
        List<Colors_Archive> ToList(Query<Colors_ArchiveProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive</returns>
        List<Colors_Archive> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive in the database.
        /// </summary>
        /// <param name="colors_archive">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(Colors_Archive colors_archive);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the list in the database.
        /// </summary>
        /// <param name="colors_archives">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive to create.</param>
        /// <returns>void</returns>
        void Create(List<Colors_Archive> colors_archives);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="colors_archive">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(Colors_Archive colors_archive);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<Colors_Archive> Update(Query<Colors_ArchiveProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(Colors_Archive original, Colors_Archive changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="colors_archive">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(Colors_Archive colors_archive);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="colors_archives">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive to update.</param>
        /// <returns>void</returns>
        void Update(List<Colors_Archive> colors_archives);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="colors_archives">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<Colors_Archive> colors_archives);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive from the database.
        /// </summary>
        /// <param name="colors_archive">The TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(Colors_Archive colors_archive);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<Colors_ArchiveProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive in the list from the database.
        /// </summary>
        /// <param name="colors_archives">List of TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Colors_Archive to delete.</param>
        /// <returns>void</returns>
        void Delete(List<Colors_Archive> colors_archives);
        #endregion
    }
}
