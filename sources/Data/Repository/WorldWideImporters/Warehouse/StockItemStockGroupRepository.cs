/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class StockItemStockGroupRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse;
using WorldWideImportersE = TheSharpFactory.Data.Entity.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class represents the Repository for: StockItemStockGroup.
    /// </summary>
    public partial class StockItemStockGroupRepository:WritableRepositoryBase<StockItemStockGroup, StockItemStockGroupProperty, StockItemStockGroupNavProperty>, IStockItemStockGroupRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<StockItemStockGroupNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<StockItemStockGroupNavProperty, NavPropertyInfo>(3){ { StockItemStockGroupNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemStockGroupProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { StockItemStockGroupNavProperty.StockGroup, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockGroup, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemStockGroupProperty.StockGroupID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockGroupProperty.StockGroupID, },} } }, { StockItemStockGroupNavProperty.StockItem, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemStockGroupProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, },} } },};
        #endregion
        #region Constructors
        public StockItemStockGroupRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemStockGroup;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Warehouse_StockItemStockGroups) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<StockItemStockGroupProperty>(1){ SortFilter.New(StockItemStockGroupProperty.StockItemStockGroupID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_StockItemStockGroups_StockGroupID_Lookup) sorting.
        private static readonly SortFilters<StockItemStockGroupProperty> _sortBy_UQ_StockItemStockGroups_StockGroupID_Lookup = new SortFilters<StockItemStockGroupProperty>(2){ SortFilter.New(StockItemStockGroupProperty.StockGroupID), SortFilter.New(StockItemStockGroupProperty.StockItemID),};
        //this is the UK(UQ_StockItemStockGroups_StockItemID_Lookup) sorting.
        private static readonly SortFilters<StockItemStockGroupProperty> _sortBy_UQ_StockItemStockGroups_StockItemID_Lookup = new SortFilters<StockItemStockGroupProperty>(2){ SortFilter.New(StockItemStockGroupProperty.StockItemID), SortFilter.New(StockItemStockGroupProperty.StockGroupID),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemstockgroupid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        public StockItemStockGroup ByPK(int stockitemstockgroupid)
        {
            var where = new QueryFilters<StockItemStockGroupProperty>(1){QueryFilter.New(StockItemStockGroupProperty.StockItemStockGroupID, FilterConditions.Equals, stockitemstockgroupid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemstockgroupid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        public StockItemStockGroup ByPK(int stockitemstockgroupid, NavProps<StockItemStockGroupNavProperty> navprops)
        {
            var where = new QueryFilters<StockItemStockGroupProperty>(1){QueryFilter.New(StockItemStockGroupProperty.StockItemStockGroupID, FilterConditions.Equals, stockitemstockgroupid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockGroupID_Lookup.
        /// </summary>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        public StockItemStockGroup ByUK1(int stockgroupid, int stockitemid)
        {
            //this method uses the UniqueKey UQ_StockItemStockGroups_StockGroupID_Lookup
            var where = new QueryFilters<StockItemStockGroupProperty>(2){QueryFilter.New(StockItemStockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroupid ), QueryFilter.New(StockItemStockGroupProperty.StockItemID, FilterConditions.Equals, stockitemid ), };
            return SelectSingle(where, _sortBy_UQ_StockItemStockGroups_StockGroupID_Lookup);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockGroupID_Lookup. Supports navigation properties.
        /// </summary>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        public StockItemStockGroup ByUK1(int stockgroupid, int stockitemid, NavProps<StockItemStockGroupNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_StockItemStockGroups_StockGroupID_Lookup
            var where = new QueryFilters<StockItemStockGroupProperty>(2){QueryFilter.New(StockItemStockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroupid ), QueryFilter.New(StockItemStockGroupProperty.StockItemID, FilterConditions.Equals, stockitemid ), };
            return SelectSingle(where, _sortBy_UQ_StockItemStockGroups_StockGroupID_Lookup, navprops);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockItemID_Lookup.
        /// </summary>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        public StockItemStockGroup ByUK2(int stockitemid, int stockgroupid)
        {
            //this method uses the UniqueKey UQ_StockItemStockGroups_StockItemID_Lookup
            var where = new QueryFilters<StockItemStockGroupProperty>(2){QueryFilter.New(StockItemStockGroupProperty.StockItemID, FilterConditions.Equals, stockitemid ), QueryFilter.New(StockItemStockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroupid ), };
            return SelectSingle(where, _sortBy_UQ_StockItemStockGroups_StockItemID_Lookup);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockItemID_Lookup. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup</returns>
        public StockItemStockGroup ByUK2(int stockitemid, int stockgroupid, NavProps<StockItemStockGroupNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_StockItemStockGroups_StockItemID_Lookup
            var where = new QueryFilters<StockItemStockGroupProperty>(2){QueryFilter.New(StockItemStockGroupProperty.StockItemID, FilterConditions.Equals, stockitemid ), QueryFilter.New(StockItemStockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroupid ), };
            return SelectSingle(where, _sortBy_UQ_StockItemStockGroups_StockItemID_Lookup, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemstockgroupid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int stockitemstockgroupid)
        {
            var where = new QueryFilters<StockItemStockGroupProperty>(1){QueryFilter.New(StockItemStockGroupProperty.StockItemStockGroupID, FilterConditions.Equals, stockitemstockgroupid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockGroupID_Lookup
        /// </summary>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK1(int stockgroupid, int stockitemid)
        {
            //this method uses the UniqueKey UQ_StockItemStockGroups_StockGroupID_Lookup
            var where = new QueryFilters<StockItemStockGroupProperty>(2){QueryFilter.New(StockItemStockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroupid), QueryFilter.New(StockItemStockGroupProperty.StockItemID, FilterConditions.Equals, stockitemid), };
            return DeleteAny(where) > 0;
        }
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup from the database by Unique Key named UQ_StockItemStockGroups_StockItemID_Lookup
        /// </summary>
        /// <param name="stockitemid">Unique Key Field.</param>
        /// <param name="stockgroupid">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK2(int stockitemid, int stockgroupid)
        {
            //this method uses the UniqueKey UQ_StockItemStockGroups_StockItemID_Lookup
            var where = new QueryFilters<StockItemStockGroupProperty>(2){QueryFilter.New(StockItemStockGroupProperty.StockItemID, FilterConditions.Equals, stockitemid), QueryFilter.New(StockItemStockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroupid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<StockItemStockGroupProperty> ComposeKeys(StockItemStockGroup stockitemstockgroup)
        {
            return new QueryFilters<StockItemStockGroupProperty>{ QueryFilter.New(StockItemStockGroupProperty.StockItemStockGroupID, FilterConditions.Equals, stockitemstockgroup.StockItemStockGroupID) };
        }
        protected override QueryFilters<StockItemStockGroupProperty> GetChanges(StockItemStockGroup original, StockItemStockGroup changed)
        {
            return StockItemStockGroupUtils.GetChanges(original, changed);
        }
        protected override void Merge(StockItemStockGroup source, StockItemStockGroup target)
        {
            StockItemStockGroupUtils.Merge(source, target);
        }
        protected override QueryFilters<StockItemStockGroupProperty> ComposeInsertPredicate(StockItemStockGroup stockitemstockgroup)
        {
            return new QueryFilters<StockItemStockGroupProperty>{ QueryFilter.New(StockItemStockGroupProperty.StockItemStockGroupID, FilterConditions.Equals, stockitemstockgroup.StockItemStockGroupID), QueryFilter.New(StockItemStockGroupProperty.StockItemID, FilterConditions.Equals, stockitemstockgroup.StockItemID), QueryFilter.New(StockItemStockGroupProperty.StockGroupID, FilterConditions.Equals, stockitemstockgroup.StockGroupID), QueryFilter.New(StockItemStockGroupProperty.LastEditedBy, FilterConditions.Equals, stockitemstockgroup.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static StockItemStockGroup MaterializeSingleEntity(SqlDataReader r)
        {
            return new StockItemStockGroup
            {
                StockItemStockGroupID = r.GetInt32(0),
                StockItemID = r.GetInt32(1),
                StockGroupID = r.GetInt32(2),
                LastEditedBy = r.GetInt32(3),
                LastEditedWhen = r.GetDateTime(4),
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
                var np = (StockItemStockGroupNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case StockItemStockGroupNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemStockGroupNavProperty.StockGroup:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemStockGroupNavProperty.StockItem:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (StockItemStockGroupNavProperty)p.Value;
                switch(np)
                {
                    case StockItemStockGroupNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemStockGroupNavProperty.StockGroup:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemStockGroupNavProperty.StockItem:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<StockItemStockGroup> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<StockItemStockGroup> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (StockItemStockGroupNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case StockItemStockGroupNavProperty.Person:
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
                    case StockItemStockGroupNavProperty.StockGroup:
                    #region StockGroup
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup>();
                            foreach(var p in list)
                                navByKey.Add(p.StockGroupID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.StockGroupID))
                                    c.StockGroup = navByKey[c.StockGroupID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockItemStockGroupNavProperty.StockItem:
                    #region StockItem
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>();
                            foreach(var p in list)
                                navByKey.Add(p.StockItemID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.StockItemID))
                                    c.StockItem = navByKey[c.StockItemID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
