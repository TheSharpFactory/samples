/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class StateProvinceRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application;
using WorldWideImportersE = TheSharpFactory.Data.Entity.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{

    /// <summary>
    /// This class represents the Repository for: StateProvince.
    /// </summary>
    public partial class StateProvinceRepository:WritableRepositoryBase<StateProvince, StateProvinceProperty, StateProvinceNavProperty>, IStateProvinceRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<StateProvinceNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<StateProvinceNavProperty, NavPropertyInfo>(3){ { StateProvinceNavProperty.Cities, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_City, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.StateProvinceProperty.StateProvinceID, OtherPropId = (int)WorldWideImportersE.Application.CityProperty.StateProvinceID, },} } }, { StateProvinceNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.StateProvinceProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { StateProvinceNavProperty.Country, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Country, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.StateProvinceProperty.CountryID, OtherPropId = (int)WorldWideImportersE.Application.CountryProperty.CountryID, },} } },};
        #endregion
        #region Constructors
        public StateProvinceRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_StateProvince;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Application_StateProvinces) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<StateProvinceProperty>(1){ SortFilter.New(StateProvinceProperty.StateProvinceID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Application_StateProvinces_StateProvinceName) sorting.
        private static readonly SortFilters<StateProvinceProperty> _sortBy_UQ_Application_StateProvinces_StateProvinceName = new SortFilters<StateProvinceProperty>(1){ SortFilter.New(StateProvinceProperty.StateProvinceName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Primary Key.
        /// </summary>
        /// <param name="stateprovinceid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        public StateProvince ByPK(int stateprovinceid)
        {
            var where = new QueryFilters<StateProvinceProperty>(1){QueryFilter.New(StateProvinceProperty.StateProvinceID, FilterConditions.Equals, stateprovinceid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="stateprovinceid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        public StateProvince ByPK(int stateprovinceid, NavProps<StateProvinceNavProperty> navprops)
        {
            var where = new QueryFilters<StateProvinceProperty>(1){QueryFilter.New(StateProvinceProperty.StateProvinceID, FilterConditions.Equals, stateprovinceid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Unique Key named UQ_Application_StateProvinces_StateProvinceName.
        /// </summary>
        /// <param name="stateprovincename">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        public StateProvince ByUK(string stateprovincename)
        {
            //this method uses the UniqueKey UQ_Application_StateProvinces_StateProvinceName
            var where = new QueryFilters<StateProvinceProperty>(1){QueryFilter.New(StateProvinceProperty.StateProvinceName, FilterConditions.Equals, stateprovincename ), };
            return SelectSingle(where, _sortBy_UQ_Application_StateProvinces_StateProvinceName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Unique Key named UQ_Application_StateProvinces_StateProvinceName. Supports navigation properties.
        /// </summary>
        /// <param name="stateprovincename">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince</returns>
        public StateProvince ByUK(string stateprovincename, NavProps<StateProvinceNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Application_StateProvinces_StateProvinceName
            var where = new QueryFilters<StateProvinceProperty>(1){QueryFilter.New(StateProvinceProperty.StateProvinceName, FilterConditions.Equals, stateprovincename ), };
            return SelectSingle(where, _sortBy_UQ_Application_StateProvinces_StateProvinceName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Primary Key.
        /// </summary>
        /// <param name="stateprovinceid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int stateprovinceid)
        {
            var where = new QueryFilters<StateProvinceProperty>(1){QueryFilter.New(StateProvinceProperty.StateProvinceID, FilterConditions.Equals, stateprovinceid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince from the database by Unique Key named UQ_Application_StateProvinces_StateProvinceName
        /// </summary>
        /// <param name="stateprovincename">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string stateprovincename)
        {
            //this method uses the UniqueKey UQ_Application_StateProvinces_StateProvinceName
            var where = new QueryFilters<StateProvinceProperty>(1){QueryFilter.New(StateProvinceProperty.StateProvinceName, FilterConditions.Equals, stateprovincename), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<StateProvinceProperty> ComposeKeys(StateProvince stateprovince)
        {
            return new QueryFilters<StateProvinceProperty>{ QueryFilter.New(StateProvinceProperty.StateProvinceID, FilterConditions.Equals, stateprovince.StateProvinceID) };
        }
        protected override QueryFilters<StateProvinceProperty> GetChanges(StateProvince original, StateProvince changed)
        {
            return StateProvinceUtils.GetChanges(original, changed);
        }
        protected override void Merge(StateProvince source, StateProvince target)
        {
            StateProvinceUtils.Merge(source, target);
        }
        protected override QueryFilters<StateProvinceProperty> ComposeInsertPredicate(StateProvince stateprovince)
        {
            return new QueryFilters<StateProvinceProperty>{ QueryFilter.New(StateProvinceProperty.StateProvinceID, FilterConditions.Equals, stateprovince.StateProvinceID), QueryFilter.New(StateProvinceProperty.StateProvinceCode, FilterConditions.Equals, stateprovince.StateProvinceCode), QueryFilter.New(StateProvinceProperty.StateProvinceName, FilterConditions.Equals, stateprovince.StateProvinceName), QueryFilter.New(StateProvinceProperty.CountryID, FilterConditions.Equals, stateprovince.CountryID), QueryFilter.New(StateProvinceProperty.SalesTerritory, FilterConditions.Equals, stateprovince.SalesTerritory), QueryFilter.New(StateProvinceProperty.Border, FilterConditions.Equals, stateprovince.Border), QueryFilter.New(StateProvinceProperty.LatestRecordedPopulation, FilterConditions.Equals, stateprovince.LatestRecordedPopulation), QueryFilter.New(StateProvinceProperty.LastEditedBy, FilterConditions.Equals, stateprovince.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 10);
        }
        private static StateProvince MaterializeSingleEntity(SqlDataReader r)
        {
            return new StateProvince
            {
                StateProvinceID = r.GetInt32(0),
                StateProvinceCode = r.GetString(1),
                StateProvinceName = r.GetString(2),
                CountryID = r.GetInt32(3),
                SalesTerritory = r.GetString(4),
                Border = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(5)),
                LatestRecordedPopulation = r.GetValue(6) as long?,
                LastEditedBy = r.GetInt32(7),
                ValidFrom = r.GetDateTime(8),
                ValidTo = r.GetDateTime(9),
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
                var np = (StateProvinceNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case StateProvinceNavProperty.Cities:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StateProvinceNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case StateProvinceNavProperty.Country:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CountryRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (StateProvinceNavProperty)p.Value;
                switch(np)
                {
                    case StateProvinceNavProperty.Cities:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StateProvinceNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case StateProvinceNavProperty.Country:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CountryRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CountryRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<StateProvince> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, StateProvince> ComposeDictionaryByPK(List<StateProvince> entities, MultiKeyDictionary<int, StateProvince> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, StateProvince>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.StateProvinceID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<StateProvince> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, StateProvince>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (StateProvinceNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case StateProvinceNavProperty.Cities:
                    #region Cities
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.StateProvinceID];
                                p.Cities = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>(p.Cities, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case StateProvinceNavProperty.Person:
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
                    case StateProvinceNavProperty.Country:
                    #region Country
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country>();
                            foreach(var p in list)
                                navByKey.Add(p.CountryID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.CountryID))
                                    c.Country = navByKey[c.CountryID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CountryRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
