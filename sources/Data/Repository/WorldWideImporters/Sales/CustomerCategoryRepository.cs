/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class CustomerCategoryRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales;
using WorldWideImportersE = TheSharpFactory.Data.Entity.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{

    /// <summary>
    /// This class represents the Repository for: CustomerCategory.
    /// </summary>
    public partial class CustomerCategoryRepository:WritableRepositoryBase<CustomerCategory, CustomerCategoryProperty, CustomerCategoryNavProperty>, ICustomerCategoryRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<CustomerCategoryNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<CustomerCategoryNavProperty, NavPropertyInfo>(3){ { CustomerCategoryNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerCategoryProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { CustomerCategoryNavProperty.Customers, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerCategoryProperty.CustomerCategoryID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerCategoryID, },} } }, { CustomerCategoryNavProperty.SpecialDeals, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_SpecialDeal, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerCategoryProperty.CustomerCategoryID, OtherPropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.CustomerCategoryID, },} } },};
        #endregion
        #region Constructors
        public CustomerCategoryRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerCategory;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Sales_CustomerCategories) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<CustomerCategoryProperty>(1){ SortFilter.New(CustomerCategoryProperty.CustomerCategoryID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Sales_CustomerCategories_CustomerCategoryName) sorting.
        private static readonly SortFilters<CustomerCategoryProperty> _sortBy_UQ_Sales_CustomerCategories_CustomerCategoryName = new SortFilters<CustomerCategoryProperty>(1){ SortFilter.New(CustomerCategoryProperty.CustomerCategoryName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Primary Key.
        /// </summary>
        /// <param name="customercategoryid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        public CustomerCategory ByPK(int customercategoryid)
        {
            var where = new QueryFilters<CustomerCategoryProperty>(1){QueryFilter.New(CustomerCategoryProperty.CustomerCategoryID, FilterConditions.Equals, customercategoryid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="customercategoryid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        public CustomerCategory ByPK(int customercategoryid, NavProps<CustomerCategoryNavProperty> navprops)
        {
            var where = new QueryFilters<CustomerCategoryProperty>(1){QueryFilter.New(CustomerCategoryProperty.CustomerCategoryID, FilterConditions.Equals, customercategoryid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Unique Key named UQ_Sales_CustomerCategories_CustomerCategoryName.
        /// </summary>
        /// <param name="customercategoryname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        public CustomerCategory ByUK(string customercategoryname)
        {
            //this method uses the UniqueKey UQ_Sales_CustomerCategories_CustomerCategoryName
            var where = new QueryFilters<CustomerCategoryProperty>(1){QueryFilter.New(CustomerCategoryProperty.CustomerCategoryName, FilterConditions.Equals, customercategoryname ), };
            return SelectSingle(where, _sortBy_UQ_Sales_CustomerCategories_CustomerCategoryName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Unique Key named UQ_Sales_CustomerCategories_CustomerCategoryName. Supports navigation properties.
        /// </summary>
        /// <param name="customercategoryname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory</returns>
        public CustomerCategory ByUK(string customercategoryname, NavProps<CustomerCategoryNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Sales_CustomerCategories_CustomerCategoryName
            var where = new QueryFilters<CustomerCategoryProperty>(1){QueryFilter.New(CustomerCategoryProperty.CustomerCategoryName, FilterConditions.Equals, customercategoryname ), };
            return SelectSingle(where, _sortBy_UQ_Sales_CustomerCategories_CustomerCategoryName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Primary Key.
        /// </summary>
        /// <param name="customercategoryid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int customercategoryid)
        {
            var where = new QueryFilters<CustomerCategoryProperty>(1){QueryFilter.New(CustomerCategoryProperty.CustomerCategoryID, FilterConditions.Equals, customercategoryid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory from the database by Unique Key named UQ_Sales_CustomerCategories_CustomerCategoryName
        /// </summary>
        /// <param name="customercategoryname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string customercategoryname)
        {
            //this method uses the UniqueKey UQ_Sales_CustomerCategories_CustomerCategoryName
            var where = new QueryFilters<CustomerCategoryProperty>(1){QueryFilter.New(CustomerCategoryProperty.CustomerCategoryName, FilterConditions.Equals, customercategoryname), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<CustomerCategoryProperty> ComposeKeys(CustomerCategory customercategory)
        {
            return new QueryFilters<CustomerCategoryProperty>{ QueryFilter.New(CustomerCategoryProperty.CustomerCategoryID, FilterConditions.Equals, customercategory.CustomerCategoryID) };
        }
        protected override QueryFilters<CustomerCategoryProperty> GetChanges(CustomerCategory original, CustomerCategory changed)
        {
            return CustomerCategoryUtils.GetChanges(original, changed);
        }
        protected override void Merge(CustomerCategory source, CustomerCategory target)
        {
            CustomerCategoryUtils.Merge(source, target);
        }
        protected override QueryFilters<CustomerCategoryProperty> ComposeInsertPredicate(CustomerCategory customercategory)
        {
            return new QueryFilters<CustomerCategoryProperty>{ QueryFilter.New(CustomerCategoryProperty.CustomerCategoryID, FilterConditions.Equals, customercategory.CustomerCategoryID), QueryFilter.New(CustomerCategoryProperty.CustomerCategoryName, FilterConditions.Equals, customercategory.CustomerCategoryName), QueryFilter.New(CustomerCategoryProperty.LastEditedBy, FilterConditions.Equals, customercategory.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static CustomerCategory MaterializeSingleEntity(SqlDataReader r)
        {
            return new CustomerCategory
            {
                CustomerCategoryID = r.GetInt32(0),
                CustomerCategoryName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class.
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        protected override List<NavPropertyInfo> BuildNavPropInfoTree(NavProps navprops) 
        {
            return BuildNavPropInfos(navprops);
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        internal static List<NavPropertyInfo> BuildNavPropInfos(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                    return null;
            var result = new List<NavPropertyInfo>(navprops.Count);
            foreach(var p in navprops)
            {
                var np = (CustomerCategoryNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case CustomerCategoryNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerCategoryNavProperty.Customers:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerCategoryNavProperty.SpecialDeals:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Composes the Navigation Property tree materializers.
        /// </summary>
        /// <returns>
        /// List of Func of SqlDataReader, object
        /// </returns>
        protected override List<Func<SqlDataReader, object>> GetNavPropMaterializers(NavProps navprops) 
        {
            return ComposeNavPropMaterializers(navprops);
        }
        internal static List<Func<SqlDataReader, object>> ComposeNavPropMaterializers(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                return new List<Func<SqlDataReader, object>>(0);
            var result = new List<Func<SqlDataReader, object>>(navprops.TotalCount);
            foreach(var p in navprops)
            {
                var np = (CustomerCategoryNavProperty)p.Value;
                switch(np)
                {
                    case CustomerCategoryNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerCategoryNavProperty.Customers:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerCategoryNavProperty.SpecialDeals:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Populates the object graph with the materialized results.
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        protected override void BuildObjectGraph(List<CustomerCategory> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, CustomerCategory> ComposeDictionaryByPK(List<CustomerCategory> entities, MultiKeyDictionary<int, CustomerCategory> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, CustomerCategory>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.CustomerCategoryID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<CustomerCategory> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, CustomerCategory>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (CustomerCategoryNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case CustomerCategoryNavProperty.Person:
                    #region Person
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>();
                            foreach(var p in list)
                                navByKey.Add(p.PersonID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.LastEditedBy))
                                    c.Person = navByKey[c.LastEditedBy];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerCategoryNavProperty.Customers:
                    #region Customers
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.CustomerCategoryID];
                                p.Customers = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(p.Customers, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerCategoryNavProperty.SpecialDeals:
                    #region SpecialDeals
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.CustomerCategoryID.Value];
                                p.SpecialDeals = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(p.SpecialDeals, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return resultsetindex;
        }
        #endregion
    }
}
