/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class StockItemHoldingRepository
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
    /// This class represents the Repository for: StockItemHolding.
    /// </summary>
    public partial class StockItemHoldingRepository:WritableRepositoryBase<StockItemHolding, StockItemHoldingProperty, StockItemHoldingNavProperty>, IStockItemHoldingRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<StockItemHoldingNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<StockItemHoldingNavProperty, NavPropertyInfo>(2){ { StockItemHoldingNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemHoldingProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { StockItemHoldingNavProperty.StockItem, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.StockItemHoldingProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, },} } },};
        #endregion
        #region Constructors
        public StockItemHoldingRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemHolding;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Warehouse_StockItemHoldings) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<StockItemHoldingProperty>(1){ SortFilter.New(StockItemHoldingProperty.StockItemID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        public StockItemHolding ByPK(int stockitemid)
        {
            var where = new QueryFilters<StockItemHoldingProperty>(1){QueryFilter.New(StockItemHoldingProperty.StockItemID, FilterConditions.Equals, stockitemid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stockitemid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding</returns>
        public StockItemHolding ByPK(int stockitemid, NavProps<StockItemHoldingNavProperty> navprops)
        {
            var where = new QueryFilters<StockItemHoldingProperty>(1){QueryFilter.New(StockItemHoldingProperty.StockItemID, FilterConditions.Equals, stockitemid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemHolding from the database by Primary Key.
        /// </summary>
        /// <param name="stockitemid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int stockitemid)
        {
            var where = new QueryFilters<StockItemHoldingProperty>(1){QueryFilter.New(StockItemHoldingProperty.StockItemID, FilterConditions.Equals, stockitemid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<StockItemHoldingProperty> ComposeKeys(StockItemHolding stockitemholding)
        {
            return new QueryFilters<StockItemHoldingProperty>{ QueryFilter.New(StockItemHoldingProperty.StockItemID, FilterConditions.Equals, stockitemholding.StockItemID) };
        }
        protected override QueryFilters<StockItemHoldingProperty> GetChanges(StockItemHolding original, StockItemHolding changed)
        {
            return StockItemHoldingUtils.GetChanges(original, changed);
        }
        protected override void Merge(StockItemHolding source, StockItemHolding target)
        {
            StockItemHoldingUtils.Merge(source, target);
        }
        protected override QueryFilters<StockItemHoldingProperty> ComposeInsertPredicate(StockItemHolding stockitemholding)
        {
            return new QueryFilters<StockItemHoldingProperty>{ QueryFilter.New(StockItemHoldingProperty.StockItemID, FilterConditions.Equals, stockitemholding.StockItemID), QueryFilter.New(StockItemHoldingProperty.QuantityOnHand, FilterConditions.Equals, stockitemholding.QuantityOnHand), QueryFilter.New(StockItemHoldingProperty.BinLocation, FilterConditions.Equals, stockitemholding.BinLocation), QueryFilter.New(StockItemHoldingProperty.LastStocktakeQuantity, FilterConditions.Equals, stockitemholding.LastStocktakeQuantity), QueryFilter.New(StockItemHoldingProperty.LastCostPrice, FilterConditions.Equals, stockitemholding.LastCostPrice), QueryFilter.New(StockItemHoldingProperty.ReorderLevel, FilterConditions.Equals, stockitemholding.ReorderLevel), QueryFilter.New(StockItemHoldingProperty.TargetStockLevel, FilterConditions.Equals, stockitemholding.TargetStockLevel), QueryFilter.New(StockItemHoldingProperty.LastEditedBy, FilterConditions.Equals, stockitemholding.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 9);
        }
        private static StockItemHolding MaterializeSingleEntity(SqlDataReader r)
        {
            return new StockItemHolding
            {
                StockItemID = r.GetInt32(0),
                QuantityOnHand = r.GetInt32(1),
                BinLocation = r.GetString(2),
                LastStocktakeQuantity = r.GetInt32(3),
                LastCostPrice = r.GetDecimal(4),
                ReorderLevel = r.GetInt32(5),
                TargetStockLevel = r.GetInt32(6),
                LastEditedBy = r.GetInt32(7),
                LastEditedWhen = r.GetDateTime(8),
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
                var np = (StockItemHoldingNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case StockItemHoldingNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StockItemHoldingNavProperty.StockItem:
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
                var np = (StockItemHoldingNavProperty)p.Value;
                switch(np)
                {
                    case StockItemHoldingNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StockItemHoldingNavProperty.StockItem:
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
        protected override void BuildObjectGraph(List<StockItemHolding> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<StockItemHolding> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (StockItemHoldingNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case StockItemHoldingNavProperty.Person:
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
                    case StockItemHoldingNavProperty.StockItem:
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
