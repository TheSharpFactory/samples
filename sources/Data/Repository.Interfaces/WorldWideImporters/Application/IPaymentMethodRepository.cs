/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application
{
    public partial interface IPaymentMethodRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Application;

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a PaymentMethod.
    /// </summary>
    public partial interface IPaymentMethodRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Primary Key.
        /// </summary>
        /// <param name="paymentmethodid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod ByPK(int paymentmethodid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="paymentmethodid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod ByPK(int paymentmethodid, NavProps<PaymentMethodNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Unique Key named UQ_Application_PaymentMethods_PaymentMethodName.
        /// </summary>
        /// <param name="paymentmethodname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod ByUK(string paymentmethodname);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Unique Key named UQ_Application_PaymentMethods_PaymentMethodName. Supports navigation properties.
        /// </summary>
        /// <param name="paymentmethodname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod ByUK(string paymentmethodname, NavProps<PaymentMethodNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        List<PaymentMethod> Top(int topcount, Query<PaymentMethodProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        List<PaymentMethod> Top(int topcount, Query<PaymentMethodProperty, PaymentMethodNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod FirstOrDefault(Query<PaymentMethodProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod FirstOrDefault(Query<PaymentMethodProperty, PaymentMethodNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod First(Query<PaymentMethodProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod First(Query<PaymentMethodProperty, PaymentMethodNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod SingleOrDefault(Query<PaymentMethodProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod SingleOrDefault(Query<PaymentMethodProperty, PaymentMethodNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod Single(Query<PaymentMethodProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        PaymentMethod Single(Query<PaymentMethodProperty, PaymentMethodNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        List<PaymentMethod> ToList(Query<PaymentMethodProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        List<PaymentMethod> ToList(Query<PaymentMethodProperty, PaymentMethodNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        List<PaymentMethod> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod in the database.
        /// </summary>
        /// <param name="paymentmethod">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(PaymentMethod paymentmethod);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the list in the database.
        /// </summary>
        /// <param name="paymentmethods">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod to create.</param>
        /// <returns>void</returns>
        void Create(List<PaymentMethod> paymentmethods);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="paymentmethod">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(PaymentMethod paymentmethod);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<PaymentMethod> Update(Query<PaymentMethodProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(PaymentMethod original, PaymentMethod changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="paymentmethod">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(PaymentMethod paymentmethod);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="paymentmethods">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod to update.</param>
        /// <returns>void</returns>
        void Update(List<PaymentMethod> paymentmethods);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="paymentmethods">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<PaymentMethod> paymentmethods);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Primary Key.
        /// </summary>
        /// <param name="paymentmethodid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int paymentmethodid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Unique Key named UQ_Application_PaymentMethods_PaymentMethodName
        /// </summary>
        /// <param name="paymentmethodname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string paymentmethodname);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database.
        /// </summary>
        /// <param name="paymentmethod">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(PaymentMethod paymentmethod);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<PaymentMethodProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod in the list from the database.
        /// </summary>
        /// <param name="paymentmethods">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod to delete.</param>
        /// <returns>void</returns>
        void Delete(List<PaymentMethod> paymentmethods);
        #endregion
    }
}
