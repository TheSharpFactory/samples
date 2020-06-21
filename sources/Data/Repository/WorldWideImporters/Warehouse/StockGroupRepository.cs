/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class StockGroupRepository
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
    /// This class represents the Repository for: StockGroup.
    /// </summary>
    public partial class StockGroupRepository:WritableRepositoryBase<StockGroup, StockGroupProperty, StockGroupNavProperty>, IStockGroupRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<StockGroupNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<StockGroupNavProperty, NavPropertyInfo>(3){ { StockGroupNavProperty.SpecialDeals, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_SpecialDeal, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockGroupProperty.StockGroupID, OtherPropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.StockGroupID, },} } }, { StockGroupNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockGroupProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { StockGroupNavProperty.StockItemStockGroups, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemStockGroup, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockGroupProperty.StockGroupID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemStockGroupProperty.StockGroupID, },} } },};
        #endregion
        #region Constructors
        public StockGroupRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockGroup;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Warehouse_StockGroups) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<StockGroupProperty>(1){ SortFilter.New(StockGroupProperty.StockGroupID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Warehouse_StockGroups_StockGroupName) sorting.
        private static readonly SortFilters<StockGroupProperty> _sortBy_UQ_Warehouse_StockGroups_StockGroupName = new SortFilters<StockGroupProperty>(1){ SortFilter.New(StockGroupProperty.StockGroupName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup from the database by Primary Key.
        /// </summary>
        /// <param name="stockgroupid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup</returns>
        public StockGroup ByPK(int stockgroupid)
        {
            var where = new QueryFilters<StockGroupProperty>(1){QueryFilter.New(StockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroupid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stockgroupid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup</returns>
        public StockGroup ByPK(int stockgroupid, NavProps<StockGroupNavProperty> navprops)
        {
            var where = new QueryFilters<StockGroupProperty>(1){QueryFilter.New(StockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroupid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup from the database by Unique Key named UQ_Warehouse_StockGroups_StockGroupName.
        /// </summary>
        /// <param name="stockgroupname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup</returns>
        public StockGroup ByUK(string stockgroupname)
        {
            //this method uses the UniqueKey UQ_Warehouse_StockGroups_StockGroupName
            var where = new QueryFilters<StockGroupProperty>(1){QueryFilter.New(StockGroupProperty.StockGroupName, FilterConditions.Equals, stockgroupname ), };
            return SelectSingle(where, _sortBy_UQ_Warehouse_StockGroups_StockGroupName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup from the database by Unique Key named UQ_Warehouse_StockGroups_StockGroupName. Supports navigation properties.
        /// </summary>
        /// <param name="stockgroupname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup</returns>
        public StockGroup ByUK(string stockgroupname, NavProps<StockGroupNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Warehouse_StockGroups_StockGroupName
            var where = new QueryFilters<StockGroupProperty>(1){QueryFilter.New(StockGroupProperty.StockGroupName, FilterConditions.Equals, stockgroupname ), };
            return SelectSingle(where, _sortBy_UQ_Warehouse_StockGroups_StockGroupName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup from the database by Primary Key.
        /// </summary>
        /// <param name="stockgroupid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int stockgroupid)
        {
            var where = new QueryFilters<StockGroupProperty>(1){QueryFilter.New(StockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroupid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockGroup from the database by Unique Key named UQ_Warehouse_StockGroups_StockGroupName
        /// </summary>
        /// <param name="stockgroupname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string stockgroupname)
        {
            //this method uses the UniqueKey UQ_Warehouse_StockGroups_StockGroupName
            var where = new QueryFilters<StockGroupProperty>(1){QueryFilter.New(StockGroupProperty.StockGroupName, FilterConditions.Equals, stockgroupname), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<StockGroupProperty> ComposeKeys(StockGroup stockgroup)
        {
            return new QueryFilters<StockGroupProperty>{ QueryFilter.New(StockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroup.StockGroupID) };
        }
        protected override QueryFilters<StockGroupProperty> GetChanges(StockGroup original, StockGroup changed)
        {
            return StockGroupUtils.GetChanges(original, changed);
        }
        protected override void Merge(StockGroup source, StockGroup target)
        {
            StockGroupUtils.Merge(source, target);
        }
        protected override QueryFilters<StockGroupProperty> ComposeInsertPredicate(StockGroup stockgroup)
        {
            return new QueryFilters<StockGroupProperty>{ QueryFilter.New(StockGroupProperty.StockGroupID, FilterConditions.Equals, stockgroup.StockGroupID), QueryFilter.New(StockGroupProperty.StockGroupName, FilterConditions.Equals, stockgroup.StockGroupName), QueryFilter.New(StockGroupProperty.LastEditedBy, FilterConditions.Equals, stockgroup.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static StockGroup MaterializeSingleEntity(SqlDataReader r)
        {
            return new StockGroup
            {
                StockGroupID = r.GetInt32(0),
                StockGroupName = r.GetString(1),
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
                var np = (StockGroupNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case StockGroupNavProperty.SpecialDeals:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockGroupNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockGroupNavProperty.StockItemStockGroups:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (StockGroupNavProperty)p.Value;
                switch(np)
                {
                    case StockGroupNavProperty.SpecialDeals:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockGroupNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockGroupNavProperty.StockItemStockGroups:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<StockGroup> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, StockGroup> ComposeDictionaryByPK(List<StockGroup> entities, MultiKeyDictionary<int, StockGroup> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, StockGroup>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.StockGroupID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<StockGroup> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, StockGroup>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (StockGroupNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case StockGroupNavProperty.SpecialDeals:
                    #region SpecialDeals
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StockGroupID.Value];
                                p.SpecialDeals = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal>(p.SpecialDeals, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.SpecialDealRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StockGroupNavProperty.Person:
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
                    case StockGroupNavProperty.StockItemStockGroups:
                    #region StockItemStockGroups
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StockGroupID];
                                p.StockItemStockGroups = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemStockGroup>(p.StockItemStockGroups, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemStockGroupRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
