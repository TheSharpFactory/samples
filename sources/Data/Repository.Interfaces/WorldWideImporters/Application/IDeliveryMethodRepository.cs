/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application
{
    public partial interface IDeliveryMethodRepository
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
    /// This interface represents the contract to exchange data with a Repository for a DeliveryMethod.
    /// </summary>
    public partial interface IDeliveryMethodRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Primary Key.
        /// </summary>
        /// <param name="deliverymethodid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod ByPK(int deliverymethodid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="deliverymethodid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod ByPK(int deliverymethodid, NavProps<DeliveryMethodNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Unique Key named UQ_Application_DeliveryMethods_DeliveryMethodName.
        /// </summary>
        /// <param name="deliverymethodname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod ByUK(string deliverymethodname);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Unique Key named UQ_Application_DeliveryMethods_DeliveryMethodName. Supports navigation properties.
        /// </summary>
        /// <param name="deliverymethodname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod ByUK(string deliverymethodname, NavProps<DeliveryMethodNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        List<DeliveryMethod> Top(int topcount, Query<DeliveryMethodProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        List<DeliveryMethod> Top(int topcount, Query<DeliveryMethodProperty, DeliveryMethodNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod FirstOrDefault(Query<DeliveryMethodProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod FirstOrDefault(Query<DeliveryMethodProperty, DeliveryMethodNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod First(Query<DeliveryMethodProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod First(Query<DeliveryMethodProperty, DeliveryMethodNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod SingleOrDefault(Query<DeliveryMethodProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod SingleOrDefault(Query<DeliveryMethodProperty, DeliveryMethodNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod Single(Query<DeliveryMethodProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        DeliveryMethod Single(Query<DeliveryMethodProperty, DeliveryMethodNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        List<DeliveryMethod> ToList(Query<DeliveryMethodProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        List<DeliveryMethod> ToList(Query<DeliveryMethodProperty, DeliveryMethodNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod</returns>
        List<DeliveryMethod> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod in the database.
        /// </summary>
        /// <param name="deliverymethod">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(DeliveryMethod deliverymethod);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the list in the database.
        /// </summary>
        /// <param name="deliverymethods">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod to create.</param>
        /// <returns>void</returns>
        void Create(List<DeliveryMethod> deliverymethods);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="deliverymethod">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(DeliveryMethod deliverymethod);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<DeliveryMethod> Update(Query<DeliveryMethodProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(DeliveryMethod original, DeliveryMethod changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="deliverymethod">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(DeliveryMethod deliverymethod);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="deliverymethods">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod to update.</param>
        /// <returns>void</returns>
        void Update(List<DeliveryMethod> deliverymethods);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="deliverymethods">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<DeliveryMethod> deliverymethods);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Primary Key.
        /// </summary>
        /// <param name="deliverymethodid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int deliverymethodid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database by Unique Key named UQ_Application_DeliveryMethods_DeliveryMethodName
        /// </summary>
        /// <param name="deliverymethodname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string deliverymethodname);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod from the database.
        /// </summary>
        /// <param name="deliverymethod">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(DeliveryMethod deliverymethod);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<DeliveryMethodProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod in the list from the database.
        /// </summary>
        /// <param name="deliverymethods">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod to delete.</param>
        /// <returns>void</returns>
        void Delete(List<DeliveryMethod> deliverymethods);
        #endregion
    }
}
