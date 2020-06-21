/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{
    public partial class SupplierCategoryRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing;
using WorldWideImportersE = TheSharpFactory.Data.Entity.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class represents the Repository for: SupplierCategory.
    /// </summary>
    public partial class SupplierCategoryRepository:WritableRepositoryBase<SupplierCategory, SupplierCategoryProperty, SupplierCategoryNavProperty>, ISupplierCategoryRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<SupplierCategoryNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<SupplierCategoryNavProperty, NavPropertyInfo>(2){ { SupplierCategoryNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierCategoryProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { SupplierCategoryNavProperty.Suppliers, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierCategoryProperty.SupplierCategoryID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierCategoryID, },} } },};
        #endregion
        #region Constructors
        public SupplierCategoryRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierCategory;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Purchasing_SupplierCategories) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<SupplierCategoryProperty>(1){ SortFilter.New(SupplierCategoryProperty.SupplierCategoryID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Purchasing_SupplierCategories_SupplierCategoryName) sorting.
        private static readonly SortFilters<SupplierCategoryProperty> _sortBy_UQ_Purchasing_SupplierCategories_SupplierCategoryName = new SortFilters<SupplierCategoryProperty>(1){ SortFilter.New(SupplierCategoryProperty.SupplierCategoryName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Primary Key.
        /// </summary>
        /// <param name="suppliercategoryid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        public SupplierCategory ByPK(int suppliercategoryid)
        {
            var where = new QueryFilters<SupplierCategoryProperty>(1){QueryFilter.New(SupplierCategoryProperty.SupplierCategoryID, FilterConditions.Equals, suppliercategoryid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="suppliercategoryid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        public SupplierCategory ByPK(int suppliercategoryid, NavProps<SupplierCategoryNavProperty> navprops)
        {
            var where = new QueryFilters<SupplierCategoryProperty>(1){QueryFilter.New(SupplierCategoryProperty.SupplierCategoryID, FilterConditions.Equals, suppliercategoryid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Unique Key named UQ_Purchasing_SupplierCategories_SupplierCategoryName.
        /// </summary>
        /// <param name="suppliercategoryname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        public SupplierCategory ByUK(string suppliercategoryname)
        {
            //this method uses the UniqueKey UQ_Purchasing_SupplierCategories_SupplierCategoryName
            var where = new QueryFilters<SupplierCategoryProperty>(1){QueryFilter.New(SupplierCategoryProperty.SupplierCategoryName, FilterConditions.Equals, suppliercategoryname ), };
            return SelectSingle(where, _sortBy_UQ_Purchasing_SupplierCategories_SupplierCategoryName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Unique Key named UQ_Purchasing_SupplierCategories_SupplierCategoryName. Supports navigation properties.
        /// </summary>
        /// <param name="suppliercategoryname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory</returns>
        public SupplierCategory ByUK(string suppliercategoryname, NavProps<SupplierCategoryNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Purchasing_SupplierCategories_SupplierCategoryName
            var where = new QueryFilters<SupplierCategoryProperty>(1){QueryFilter.New(SupplierCategoryProperty.SupplierCategoryName, FilterConditions.Equals, suppliercategoryname ), };
            return SelectSingle(where, _sortBy_UQ_Purchasing_SupplierCategories_SupplierCategoryName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Primary Key.
        /// </summary>
        /// <param name="suppliercategoryid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int suppliercategoryid)
        {
            var where = new QueryFilters<SupplierCategoryProperty>(1){QueryFilter.New(SupplierCategoryProperty.SupplierCategoryID, FilterConditions.Equals, suppliercategoryid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierCategory from the database by Unique Key named UQ_Purchasing_SupplierCategories_SupplierCategoryName
        /// </summary>
        /// <param name="suppliercategoryname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string suppliercategoryname)
        {
            //this method uses the UniqueKey UQ_Purchasing_SupplierCategories_SupplierCategoryName
            var where = new QueryFilters<SupplierCategoryProperty>(1){QueryFilter.New(SupplierCategoryProperty.SupplierCategoryName, FilterConditions.Equals, suppliercategoryname), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<SupplierCategoryProperty> ComposeKeys(SupplierCategory suppliercategory)
        {
            return new QueryFilters<SupplierCategoryProperty>{ QueryFilter.New(SupplierCategoryProperty.SupplierCategoryID, FilterConditions.Equals, suppliercategory.SupplierCategoryID) };
        }
        protected override QueryFilters<SupplierCategoryProperty> GetChanges(SupplierCategory original, SupplierCategory changed)
        {
            return SupplierCategoryUtils.GetChanges(original, changed);
        }
        protected override void Merge(SupplierCategory source, SupplierCategory target)
        {
            SupplierCategoryUtils.Merge(source, target);
        }
        protected override QueryFilters<SupplierCategoryProperty> ComposeInsertPredicate(SupplierCategory suppliercategory)
        {
            return new QueryFilters<SupplierCategoryProperty>{ QueryFilter.New(SupplierCategoryProperty.SupplierCategoryID, FilterConditions.Equals, suppliercategory.SupplierCategoryID), QueryFilter.New(SupplierCategoryProperty.SupplierCategoryName, FilterConditions.Equals, suppliercategory.SupplierCategoryName), QueryFilter.New(SupplierCategoryProperty.LastEditedBy, FilterConditions.Equals, suppliercategory.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static SupplierCategory MaterializeSingleEntity(SqlDataReader r)
        {
            return new SupplierCategory
            {
                SupplierCategoryID = r.GetInt32(0),
                SupplierCategoryName = r.GetString(1),
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
                var np = (SupplierCategoryNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case SupplierCategoryNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierCategoryNavProperty.Suppliers:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (SupplierCategoryNavProperty)p.Value;
                switch(np)
                {
                    case SupplierCategoryNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierCategoryNavProperty.Suppliers:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<SupplierCategory> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, SupplierCategory> ComposeDictionaryByPK(List<SupplierCategory> entities, MultiKeyDictionary<int, SupplierCategory> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, SupplierCategory>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.SupplierCategoryID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<SupplierCategory> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, SupplierCategory>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (SupplierCategoryNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case SupplierCategoryNavProperty.Person:
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
                    case SupplierCategoryNavProperty.Suppliers:
                    #region Suppliers
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.SupplierCategoryID];
                                p.Suppliers = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(p.Suppliers, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
