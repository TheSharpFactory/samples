/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application
{
    public partial interface ISystemParameterRepository
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
    /// This interface represents the contract to exchange data with a Repository for a SystemParameter.
    /// </summary>
    public partial interface ISystemParameterRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database by Primary Key.
        /// </summary>
        /// <param name="systemparameterid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter ByPK(int systemparameterid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="systemparameterid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter ByPK(int systemparameterid, NavProps<SystemParameterNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        List<SystemParameter> Top(int topcount, Query<SystemParameterProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        List<SystemParameter> Top(int topcount, Query<SystemParameterProperty, SystemParameterNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter FirstOrDefault(Query<SystemParameterProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter FirstOrDefault(Query<SystemParameterProperty, SystemParameterNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter First(Query<SystemParameterProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter First(Query<SystemParameterProperty, SystemParameterNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter SingleOrDefault(Query<SystemParameterProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter SingleOrDefault(Query<SystemParameterProperty, SystemParameterNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter Single(Query<SystemParameterProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        SystemParameter Single(Query<SystemParameterProperty, SystemParameterNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        List<SystemParameter> ToList(Query<SystemParameterProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        List<SystemParameter> ToList(Query<SystemParameterProperty, SystemParameterNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        List<SystemParameter> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter in the database.
        /// </summary>
        /// <param name="systemparameter">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(SystemParameter systemparameter);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the list in the database.
        /// </summary>
        /// <param name="systemparameters">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter to create.</param>
        /// <returns>void</returns>
        void Create(List<SystemParameter> systemparameters);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="systemparameter">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(SystemParameter systemparameter);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<SystemParameter> Update(Query<SystemParameterProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(SystemParameter original, SystemParameter changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="systemparameter">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(SystemParameter systemparameter);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="systemparameters">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter to update.</param>
        /// <returns>void</returns>
        void Update(List<SystemParameter> systemparameters);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="systemparameters">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<SystemParameter> systemparameters);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database by Primary Key.
        /// </summary>
        /// <param name="systemparameterid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int systemparameterid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database.
        /// </summary>
        /// <param name="systemparameter">The TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(SystemParameter systemparameter);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<SystemParameterProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter in the list from the database.
        /// </summary>
        /// <param name="systemparameters">List of TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter to delete.</param>
        /// <returns>void</returns>
        void Delete(List<SystemParameter> systemparameters);
        #endregion
    }
}
