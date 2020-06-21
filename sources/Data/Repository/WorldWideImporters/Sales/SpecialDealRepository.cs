/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class SpecialDealRepository
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
    /// This class represents the Repository for: SpecialDeal.
    /// </summary>
    public partial class SpecialDealRepository:WritableRepositoryBase<SpecialDeal, SpecialDealProperty, SpecialDealNavProperty>, ISpecialDealRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<SpecialDealNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<SpecialDealNavProperty, NavPropertyInfo>(6){ { SpecialDealNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { SpecialDealNavProperty.BuyingGroup, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_BuyingGroup, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.BuyingGroupID, OtherPropId = (int)WorldWideImportersE.Sales.BuyingGroupProperty.BuyingGroupID, },} } }, { SpecialDealNavProperty.CustomerCategory, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerCategory, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.CustomerCategoryID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerCategoryProperty.CustomerCategoryID, },} } }, { SpecialDealNavProperty.Customer, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, },} } }, { SpecialDealNavProperty.StockGroup, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockGroup, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.StockGroupID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockGroupProperty.StockGroupID, },} } }, { SpecialDealNavProperty.StockItem, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.SpecialDealProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, },} } },};
        #endregion
        #region Constructors
        public SpecialDealRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_SpecialDeal;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Sales_SpecialDeals) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<SpecialDealProperty>(1){ SortFilter.New(SpecialDealProperty.SpecialDealID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database by Primary Key.
        /// </summary>
        /// <param name="specialdealid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        public SpecialDeal ByPK(int specialdealid)
        {
            var where = new QueryFilters<SpecialDealProperty>(1){QueryFilter.New(SpecialDealProperty.SpecialDealID, FilterConditions.Equals, specialdealid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="specialdealid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal</returns>
        public SpecialDeal ByPK(int specialdealid, NavProps<SpecialDealNavProperty> navprops)
        {
            var where = new QueryFilters<SpecialDealProperty>(1){QueryFilter.New(SpecialDealProperty.SpecialDealID, FilterConditions.Equals, specialdealid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal from the database by Primary Key.
        /// </summary>
        /// <param name="specialdealid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int specialdealid)
        {
            var where = new QueryFilters<SpecialDealProperty>(1){QueryFilter.New(SpecialDealProperty.SpecialDealID, FilterConditions.Equals, specialdealid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<SpecialDealProperty> ComposeKeys(SpecialDeal specialdeal)
        {
            return new QueryFilters<SpecialDealProperty>{ QueryFilter.New(SpecialDealProperty.SpecialDealID, FilterConditions.Equals, specialdeal.SpecialDealID) };
        }
        protected override QueryFilters<SpecialDealProperty> GetChanges(SpecialDeal original, SpecialDeal changed)
        {
            return SpecialDealUtils.GetChanges(original, changed);
        }
        protected override void Merge(SpecialDeal source, SpecialDeal target)
        {
            SpecialDealUtils.Merge(source, target);
        }
        protected override QueryFilters<SpecialDealProperty> ComposeInsertPredicate(SpecialDeal specialdeal)
        {
            return new QueryFilters<SpecialDealProperty>{ QueryFilter.New(SpecialDealProperty.SpecialDealID, FilterConditions.Equals, specialdeal.SpecialDealID), QueryFilter.New(SpecialDealProperty.StockItemID, FilterConditions.Equals, specialdeal.StockItemID), QueryFilter.New(SpecialDealProperty.CustomerID, FilterConditions.Equals, specialdeal.CustomerID), QueryFilter.New(SpecialDealProperty.BuyingGroupID, FilterConditions.Equals, specialdeal.BuyingGroupID), QueryFilter.New(SpecialDealProperty.CustomerCategoryID, FilterConditions.Equals, specialdeal.CustomerCategoryID), QueryFilter.New(SpecialDealProperty.StockGroupID, FilterConditions.Equals, specialdeal.StockGroupID), QueryFilter.New(SpecialDealProperty.DealDescription, FilterConditions.Equals, specialdeal.DealDescription), QueryFilter.New(SpecialDealProperty.StartDate, FilterConditions.Equals, specialdeal.StartDate), QueryFilter.New(SpecialDealProperty.EndDate, FilterConditions.Equals, specialdeal.EndDate), QueryFilter.New(SpecialDealProperty.DiscountAmount, FilterConditions.Equals, specialdeal.DiscountAmount), QueryFilter.New(SpecialDealProperty.DiscountPercentage, FilterConditions.Equals, specialdeal.DiscountPercentage), QueryFilter.New(SpecialDealProperty.UnitPrice, FilterConditions.Equals, specialdeal.UnitPrice), QueryFilter.New(SpecialDealProperty.LastEditedBy, FilterConditions.Equals, specialdeal.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 14);
        }
        private static SpecialDeal MaterializeSingleEntity(SqlDataReader r)
        {
            return new SpecialDeal
            {
                SpecialDealID = r.GetInt32(0),
                StockItemID = r.GetValue(1) as int?,
                CustomerID = r.GetValue(2) as int?,
                BuyingGroupID = r.GetValue(3) as int?,
                CustomerCategoryID = r.GetValue(4) as int?,
                StockGroupID = r.GetValue(5) as int?,
                DealDescription = r.GetString(6),
                StartDate = r.GetDateTime(7),
                EndDate = r.GetDateTime(8),
                DiscountAmount = r.GetValue(9) as decimal?,
                DiscountPercentage = r.GetValue(10) as decimal?,
                UnitPrice = r.GetValue(11) as decimal?,
                LastEditedBy = r.GetInt32(12),
                LastEditedWhen = r.GetDateTime(13),
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
                var np = (SpecialDealNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case SpecialDealNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SpecialDealNavProperty.BuyingGroup:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SpecialDealNavProperty.CustomerCategory:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SpecialDealNavProperty.Customer:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SpecialDealNavProperty.StockGroup:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SpecialDealNavProperty.StockItem:
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
                var np = (SpecialDealNavProperty)p.Value;
                switch(np)
                {
                    case SpecialDealNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SpecialDealNavProperty.BuyingGroup:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SpecialDealNavProperty.CustomerCategory:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SpecialDealNavProperty.Customer:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SpecialDealNavProperty.StockGroup:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SpecialDealNavProperty.StockItem:
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
        protected override void BuildObjectGraph(List<SpecialDeal> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<SpecialDeal> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (SpecialDealNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case SpecialDealNavProperty.Person:
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
                    case SpecialDealNavProperty.BuyingGroup:
                    #region BuyingGroup
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.BuyingGroup>();
                            foreach(var p in list)
                                navByKey.Add(p.BuyingGroupID, p);
                            foreach(var c in entities)
                            {
                                if(!c.BuyingGroupID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.BuyingGroupID.Value))
                                    c.BuyingGroup = navByKey[c.BuyingGroupID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.BuyingGroupRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SpecialDealNavProperty.CustomerCategory:
                    #region CustomerCategory
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerCategory>();
                            foreach(var p in list)
                                navByKey.Add(p.CustomerCategoryID, p);
                            foreach(var c in entities)
                            {
                                if(!c.CustomerCategoryID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.CustomerCategoryID.Value))
                                    c.CustomerCategory = navByKey[c.CustomerCategoryID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerCategoryRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SpecialDealNavProperty.Customer:
                    #region Customer
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>();
                            foreach(var p in list)
                                navByKey.Add(p.CustomerID, p);
                            foreach(var c in entities)
                            {
                                if(!c.CustomerID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.CustomerID.Value))
                                    c.Customer = navByKey[c.CustomerID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SpecialDealNavProperty.StockGroup:
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
                                if(!c.StockGroupID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.StockGroupID.Value))
                                    c.StockGroup = navByKey[c.StockGroupID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockGroupRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SpecialDealNavProperty.StockItem:
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
                                if(!c.StockItemID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.StockItemID.Value))
                                    c.StockItem = navByKey[c.StockItemID.Value];
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
