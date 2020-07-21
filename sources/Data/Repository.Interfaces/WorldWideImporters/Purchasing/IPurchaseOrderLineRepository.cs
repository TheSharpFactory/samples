/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing
{
    public partial interface IPurchaseOrderLineRepository
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
    /// This interface represents the contract to exchange data with a Repository for a PurchaseOrderLine.
    /// </summary>
    public partial interface IPurchaseOrderLineRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database by Primary Key.
        /// </summary>
        /// <param name="purchaseorderlineid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine ByPK(int purchaseorderlineid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="purchaseorderlineid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine ByPK(int purchaseorderlineid, NavProps<PurchaseOrderLineNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        List<PurchaseOrderLine> Top(int topcount, Query<PurchaseOrderLineProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        List<PurchaseOrderLine> Top(int topcount, Query<PurchaseOrderLineProperty, PurchaseOrderLineNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine FirstOrDefault(Query<PurchaseOrderLineProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine FirstOrDefault(Query<PurchaseOrderLineProperty, PurchaseOrderLineNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine First(Query<PurchaseOrderLineProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine First(Query<PurchaseOrderLineProperty, PurchaseOrderLineNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine SingleOrDefault(Query<PurchaseOrderLineProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine SingleOrDefault(Query<PurchaseOrderLineProperty, PurchaseOrderLineNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine Single(Query<PurchaseOrderLineProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        PurchaseOrderLine Single(Query<PurchaseOrderLineProperty, PurchaseOrderLineNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        List<PurchaseOrderLine> ToList(Query<PurchaseOrderLineProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        List<PurchaseOrderLine> ToList(Query<PurchaseOrderLineProperty, PurchaseOrderLineNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine</returns>
        List<PurchaseOrderLine> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine in the database.
        /// </summary>
        /// <param name="purchaseorderline">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(PurchaseOrderLine purchaseorderline);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the list in the database.
        /// </summary>
        /// <param name="purchaseorderlines">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine to create.</param>
        /// <returns>void</returns>
        void Create(List<PurchaseOrderLine> purchaseorderlines);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="purchaseorderline">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(PurchaseOrderLine purchaseorderline);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<PurchaseOrderLine> Update(Query<PurchaseOrderLineProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(PurchaseOrderLine original, PurchaseOrderLine changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="purchaseorderline">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(PurchaseOrderLine purchaseorderline);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="purchaseorderlines">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine to update.</param>
        /// <returns>void</returns>
        void Update(List<PurchaseOrderLine> purchaseorderlines);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="purchaseorderlines">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<PurchaseOrderLine> purchaseorderlines);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database by Primary Key.
        /// </summary>
        /// <param name="purchaseorderlineid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int purchaseorderlineid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine from the database.
        /// </summary>
        /// <param name="purchaseorderline">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(PurchaseOrderLine purchaseorderline);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<PurchaseOrderLineProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine in the list from the database.
        /// </summary>
        /// <param name="purchaseorderlines">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrderLine to delete.</param>
        /// <returns>void</returns>
        void Delete(List<PurchaseOrderLine> purchaseorderlines);
        #endregion
    }
}
