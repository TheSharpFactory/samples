/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application
{
    public partial interface IStateProvinceRepository
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
    /// This interface represents the contract to exchange data with a Repository for a StateProvince.
    /// </summary>
    public partial interface IStateProvinceRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Primary Key.
        /// </summary>
        /// <param name="stateprovinceid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince ByPK(int stateprovinceid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stateprovinceid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince ByPK(int stateprovinceid, NavProps<StateProvinceNavProperty> navprops);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Unique Key named UQ_Application_StateProvinces_StateProvinceName.
        /// </summary>
        /// <param name="stateprovincename">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince ByUK(string stateprovincename);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Unique Key named UQ_Application_StateProvinces_StateProvinceName. Supports navigation properties.
        /// </summary>
        /// <param name="stateprovincename">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince ByUK(string stateprovincename, NavProps<StateProvinceNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        List<StateProvince> Top(int topcount, Query<StateProvinceProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        List<StateProvince> Top(int topcount, Query<StateProvinceProperty, StateProvinceNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince FirstOrDefault(Query<StateProvinceProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince FirstOrDefault(Query<StateProvinceProperty, StateProvinceNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince First(Query<StateProvinceProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince First(Query<StateProvinceProperty, StateProvinceNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince SingleOrDefault(Query<StateProvinceProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince SingleOrDefault(Query<StateProvinceProperty, StateProvinceNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince Single(Query<StateProvinceProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        StateProvince Single(Query<StateProvinceProperty, StateProvinceNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        List<StateProvince> ToList(Query<StateProvinceProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        List<StateProvince> ToList(Query<StateProvinceProperty, StateProvinceNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        List<StateProvince> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince in the database.
        /// </summary>
        /// <param name="stateprovince">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(StateProvince stateprovince);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the list in the database.
        /// </summary>
        /// <param name="stateprovinces">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince to create.</param>
        /// <returns>void</returns>
        void Create(List<StateProvince> stateprovinces);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stateprovince">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(StateProvince stateprovince);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<StateProvince> Update(Query<StateProvinceProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(StateProvince original, StateProvince changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stateprovince">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(StateProvince stateprovince);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stateprovinces">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince to update.</param>
        /// <returns>void</returns>
        void Update(List<StateProvince> stateprovinces);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="stateprovinces">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<StateProvince> stateprovinces);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Primary Key.
        /// </summary>
        /// <param name="stateprovinceid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int stateprovinceid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Unique Key named UQ_Application_StateProvinces_StateProvinceName
        /// </summary>
        /// <param name="stateprovincename">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string stateprovincename);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database.
        /// </summary>
        /// <param name="stateprovince">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(StateProvince stateprovince);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<StateProvinceProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince in the list from the database.
        /// </summary>
        /// <param name="stateprovinces">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince to delete.</param>
        /// <returns>void</returns>
        void Delete(List<StateProvince> stateprovinces);
        #endregion
    }
}
