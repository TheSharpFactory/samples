/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing
{
    public partial interface IPurchaseOrderRepository
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
    /// This interface represents the contract to exchange data with a Repository for a PurchaseOrder.
    /// </summary>
    public partial interface IPurchaseOrderRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database by Primary Key.
        /// </summary>
        /// <param name="purchaseorderid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder ByPK(int purchaseorderid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="purchaseorderid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder ByPK(int purchaseorderid, NavProps<PurchaseOrderNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        List<PurchaseOrder> Top(int topcount, Query<PurchaseOrderProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        List<PurchaseOrder> Top(int topcount, Query<PurchaseOrderProperty, PurchaseOrderNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder FirstOrDefault(Query<PurchaseOrderProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder FirstOrDefault(Query<PurchaseOrderProperty, PurchaseOrderNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder First(Query<PurchaseOrderProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder First(Query<PurchaseOrderProperty, PurchaseOrderNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder SingleOrDefault(Query<PurchaseOrderProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder SingleOrDefault(Query<PurchaseOrderProperty, PurchaseOrderNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder Single(Query<PurchaseOrderProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        PurchaseOrder Single(Query<PurchaseOrderProperty, PurchaseOrderNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        List<PurchaseOrder> ToList(Query<PurchaseOrderProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        List<PurchaseOrder> ToList(Query<PurchaseOrderProperty, PurchaseOrderNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder</returns>
        List<PurchaseOrder> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder in the database.
        /// </summary>
        /// <param name="purchaseorder">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(PurchaseOrder purchaseorder);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the list in the database.
        /// </summary>
        /// <param name="purchaseorders">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder to create.</param>
        /// <returns>void</returns>
        void Create(List<PurchaseOrder> purchaseorders);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="purchaseorder">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(PurchaseOrder purchaseorder);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<PurchaseOrder> Update(Query<PurchaseOrderProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(PurchaseOrder original, PurchaseOrder changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="purchaseorder">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(PurchaseOrder purchaseorder);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="purchaseorders">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder to update.</param>
        /// <returns>void</returns>
        void Update(List<PurchaseOrder> purchaseorders);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="purchaseorders">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<PurchaseOrder> purchaseorders);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database by Primary Key.
        /// </summary>
        /// <param name="purchaseorderid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int purchaseorderid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder from the database.
        /// </summary>
        /// <param name="purchaseorder">The TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(PurchaseOrder purchaseorder);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<PurchaseOrderProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder in the list from the database.
        /// </summary>
        /// <param name="purchaseorders">List of TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder to delete.</param>
        /// <returns>void</returns>
        void Delete(List<PurchaseOrder> purchaseorders);
        #endregion
    }
}
