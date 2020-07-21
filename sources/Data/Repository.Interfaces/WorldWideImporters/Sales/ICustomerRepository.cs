/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales
{
    public partial interface ICustomerRepository
    {
    }
}

************************************************/

using System.Collections.Generic;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a Customer.
    /// </summary>
    public partial interface ICustomerRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Primary Key.
        /// </summary>
        /// <param name="customerid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer ByPK(int customerid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="customerid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer ByPK(int customerid, NavProps<CustomerNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Unique Key named UQ_Sales_Customers_CustomerName.
        /// </summary>
        /// <param name="customername">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer ByUK(string customername);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Unique Key named UQ_Sales_Customers_CustomerName. Supports navigation properties.
        /// </summary>
        /// <param name="customername">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer ByUK(string customername, NavProps<CustomerNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        List<Customer> Top(int topcount, Query<CustomerProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        List<Customer> Top(int topcount, Query<CustomerProperty, CustomerNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer FirstOrDefault(Query<CustomerProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer FirstOrDefault(Query<CustomerProperty, CustomerNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer First(Query<CustomerProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer First(Query<CustomerProperty, CustomerNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer SingleOrDefault(Query<CustomerProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer SingleOrDefault(Query<CustomerProperty, CustomerNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer Single(Query<CustomerProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        Customer Single(Query<CustomerProperty, CustomerNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        List<Customer> ToList(Query<CustomerProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        List<Customer> ToList(Query<CustomerProperty, CustomerNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer</returns>
        List<Customer> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer in the database.
        /// </summary>
        /// <param name="customer">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(Customer customer);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the list in the database.
        /// </summary>
        /// <param name="customers">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer to create.</param>
        /// <returns>void</returns>
        void Create(List<Customer> customers);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="customer">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(Customer customer);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<Customer> Update(Query<CustomerProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(Customer original, Customer changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="customer">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(Customer customer);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="customers">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer to update.</param>
        /// <returns>void</returns>
        void Update(List<Customer> customers);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="customers">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<Customer> customers);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Primary Key.
        /// </summary>
        /// <param name="customerid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int customerid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database by Unique Key named UQ_Sales_Customers_CustomerName
        /// </summary>
        /// <param name="customername">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string customername);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer from the database.
        /// </summary>
        /// <param name="customer">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(Customer customer);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<CustomerProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer in the list from the database.
        /// </summary>
        /// <param name="customers">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer to delete.</param>
        /// <returns>void</returns>
        void Delete(List<Customer> customers);
        #endregion
    }
}
