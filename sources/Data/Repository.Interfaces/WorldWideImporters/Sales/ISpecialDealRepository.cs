/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales
{
    public partial interface ISpecialDealRepository
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
    /// This interface represents the contract to exchange data with a Repository for a SpecialDeal.
    /// </summary>
    public partial interface ISpecialDealRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database by Primary Key.
        /// </summary>
        /// <param name="specialdealid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal ByPK(int specialdealid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="specialdealid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal ByPK(int specialdealid, NavProps<SpecialDealNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        List<SpecialDeal> Top(int topcount, Query<SpecialDealProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        List<SpecialDeal> Top(int topcount, Query<SpecialDealProperty, SpecialDealNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal FirstOrDefault(Query<SpecialDealProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal FirstOrDefault(Query<SpecialDealProperty, SpecialDealNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal First(Query<SpecialDealProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal First(Query<SpecialDealProperty, SpecialDealNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal SingleOrDefault(Query<SpecialDealProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal SingleOrDefault(Query<SpecialDealProperty, SpecialDealNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal Single(Query<SpecialDealProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        SpecialDeal Single(Query<SpecialDealProperty, SpecialDealNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        List<SpecialDeal> ToList(Query<SpecialDealProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        List<SpecialDeal> ToList(Query<SpecialDealProperty, SpecialDealNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        List<SpecialDeal> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal in the database.
        /// </summary>
        /// <param name="specialdeal">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(SpecialDeal specialdeal);
        /// <summary>
        /// Creates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the list in the database.
        /// </summary>
        /// <param name="specialdeals">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal to create.</param>
        /// <returns>void</returns>
        void Create(List<SpecialDeal> specialdeals);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="specialdeal">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(SpecialDeal specialdeal);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<SpecialDeal> Update(Query<SpecialDealProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(SpecialDeal original, SpecialDeal changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="specialdeal">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(SpecialDeal specialdeal);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="specialdeals">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal to update.</param>
        /// <returns>void</returns>
        void Update(List<SpecialDeal> specialdeals);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="specialdeals">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<SpecialDeal> specialdeals);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database by Primary Key.
        /// </summary>
        /// <param name="specialdealid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int specialdealid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database.
        /// </summary>
        /// <param name="specialdeal">The TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(SpecialDeal specialdeal);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<SpecialDealProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal in the list from the database.
        /// </summary>
        /// <param name="specialdeals">List of TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal to delete.</param>
        /// <returns>void</returns>
        void Delete(List<SpecialDeal> specialdeals);
        #endregion
    }
}
