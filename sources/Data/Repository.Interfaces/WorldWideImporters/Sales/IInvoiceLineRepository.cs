/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales
{
    public partial interface IInvoiceLineRepository
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
    /// This interface represents the contract to exchange data with a Repository for a InvoiceLine.
    /// </summary>
    public partial interface IInvoiceLineRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database by Primary Key.
        /// </summary>
        /// <param name="invoicelineid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine ByPK(int invoicelineid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="invoicelineid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine ByPK(int invoicelineid, NavProps<InvoiceLineNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        List<InvoiceLine> Top(int topcount, Query<InvoiceLineProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        List<InvoiceLine> Top(int topcount, Query<InvoiceLineProperty, InvoiceLineNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine FirstOrDefault(Query<InvoiceLineProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine FirstOrDefault(Query<InvoiceLineProperty, InvoiceLineNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine First(Query<InvoiceLineProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine First(Query<InvoiceLineProperty, InvoiceLineNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine SingleOrDefault(Query<InvoiceLineProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine SingleOrDefault(Query<InvoiceLineProperty, InvoiceLineNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine Single(Query<InvoiceLineProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        InvoiceLine Single(Query<InvoiceLineProperty, InvoiceLineNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        List<InvoiceLine> ToList(Query<InvoiceLineProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        List<InvoiceLine> ToList(Query<InvoiceLineProperty, InvoiceLineNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        List<InvoiceLine> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine in the database.
        /// </summary>
        /// <param name="invoiceline">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(InvoiceLine invoiceline);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the list in the database.
        /// </summary>
        /// <param name="invoicelines">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine to create.</param>
        /// <returns>void</returns>
        void Create(List<InvoiceLine> invoicelines);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="invoiceline">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(InvoiceLine invoiceline);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<InvoiceLine> Update(Query<InvoiceLineProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(InvoiceLine original, InvoiceLine changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="invoiceline">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(InvoiceLine invoiceline);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="invoicelines">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine to update.</param>
        /// <returns>void</returns>
        void Update(List<InvoiceLine> invoicelines);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="invoicelines">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<InvoiceLine> invoicelines);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database by Primary Key.
        /// </summary>
        /// <param name="invoicelineid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int invoicelineid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database.
        /// </summary>
        /// <param name="invoiceline">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(InvoiceLine invoiceline);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<InvoiceLineProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine in the list from the database.
        /// </summary>
        /// <param name="invoicelines">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine to delete.</param>
        /// <returns>void</returns>
        void Delete(List<InvoiceLine> invoicelines);
        #endregion
    }
}
