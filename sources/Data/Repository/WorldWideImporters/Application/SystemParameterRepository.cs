/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class SystemParameterRepository
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
    /// This class represents the Repository for: SystemParameter.
    /// </summary>
    public partial class SystemParameterRepository:WritableRepositoryBase<SystemParameter, SystemParameterProperty, SystemParameterNavProperty>, ISystemParameterRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<SystemParameterNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<SystemParameterNavProperty, NavPropertyInfo>(3){ { SystemParameterNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.SystemParameterProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { SystemParameterNavProperty.City, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_City, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.SystemParameterProperty.DeliveryCityID, OtherPropId = (int)WorldWideImportersE.Application.CityProperty.CityID, },} } }, { SystemParameterNavProperty.City1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_City, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.SystemParameterProperty.PostalCityID, OtherPropId = (int)WorldWideImportersE.Application.CityProperty.CityID, },} } },};
        #endregion
        #region Constructors
        public SystemParameterRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_SystemParameter;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Application_SystemParameters) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<SystemParameterProperty>(1){ SortFilter.New(SystemParameterProperty.SystemParameterID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database by Primary Key.
        /// </summary>
        /// <param name="systemparameterid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        public SystemParameter ByPK(int systemparameterid)
        {
            var where = new QueryFilters<SystemParameterProperty>(1){QueryFilter.New(SystemParameterProperty.SystemParameterID, FilterConditions.Equals, systemparameterid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="systemparameterid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter</returns>
        public SystemParameter ByPK(int systemparameterid, NavProps<SystemParameterNavProperty> navprops)
        {
            var where = new QueryFilters<SystemParameterProperty>(1){QueryFilter.New(SystemParameterProperty.SystemParameterID, FilterConditions.Equals, systemparameterid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter from the database by Primary Key.
        /// </summary>
        /// <param name="systemparameterid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int systemparameterid)
        {
            var where = new QueryFilters<SystemParameterProperty>(1){QueryFilter.New(SystemParameterProperty.SystemParameterID, FilterConditions.Equals, systemparameterid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<SystemParameterProperty> ComposeKeys(SystemParameter systemparameter)
        {
            return new QueryFilters<SystemParameterProperty>{ QueryFilter.New(SystemParameterProperty.SystemParameterID, FilterConditions.Equals, systemparameter.SystemParameterID) };
        }
        protected override QueryFilters<SystemParameterProperty> GetChanges(SystemParameter original, SystemParameter changed)
        {
            return SystemParameterUtils.GetChanges(original, changed);
        }
        protected override void Merge(SystemParameter source, SystemParameter target)
        {
            SystemParameterUtils.Merge(source, target);
        }
        protected override QueryFilters<SystemParameterProperty> ComposeInsertPredicate(SystemParameter systemparameter)
        {
            return new QueryFilters<SystemParameterProperty>{ QueryFilter.New(SystemParameterProperty.SystemParameterID, FilterConditions.Equals, systemparameter.SystemParameterID), QueryFilter.New(SystemParameterProperty.DeliveryAddressLine1, FilterConditions.Equals, systemparameter.DeliveryAddressLine1), QueryFilter.New(SystemParameterProperty.DeliveryAddressLine2, FilterConditions.Equals, systemparameter.DeliveryAddressLine2), QueryFilter.New(SystemParameterProperty.DeliveryCityID, FilterConditions.Equals, systemparameter.DeliveryCityID), QueryFilter.New(SystemParameterProperty.DeliveryPostalCode, FilterConditions.Equals, systemparameter.DeliveryPostalCode), QueryFilter.New(SystemParameterProperty.DeliveryLocation, FilterConditions.Equals, systemparameter.DeliveryLocation), QueryFilter.New(SystemParameterProperty.PostalAddressLine1, FilterConditions.Equals, systemparameter.PostalAddressLine1), QueryFilter.New(SystemParameterProperty.PostalAddressLine2, FilterConditions.Equals, systemparameter.PostalAddressLine2), QueryFilter.New(SystemParameterProperty.PostalCityID, FilterConditions.Equals, systemparameter.PostalCityID), QueryFilter.New(SystemParameterProperty.PostalPostalCode, FilterConditions.Equals, systemparameter.PostalPostalCode), QueryFilter.New(SystemParameterProperty.ApplicationSettings, FilterConditions.Equals, systemparameter.ApplicationSettings), QueryFilter.New(SystemParameterProperty.LastEditedBy, FilterConditions.Equals, systemparameter.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 13);
        }
        private static SystemParameter MaterializeSingleEntity(SqlDataReader r)
        {
            return new SystemParameter
            {
                SystemParameterID = r.GetInt32(0),
                DeliveryAddressLine1 = r.GetString(1),
                DeliveryAddressLine2 = r.GetValue(2) as string,
                DeliveryCityID = r.GetInt32(3),
                DeliveryPostalCode = r.GetString(4),
                DeliveryLocation = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(5)),
                PostalAddressLine1 = r.GetString(6),
                PostalAddressLine2 = r.GetValue(7) as string,
                PostalCityID = r.GetInt32(8),
                PostalPostalCode = r.GetString(9),
                ApplicationSettings = r.GetString(10),
                LastEditedBy = r.GetInt32(11),
                LastEditedWhen = r.GetDateTime(12),
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
                var np = (SystemParameterNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case SystemParameterNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SystemParameterNavProperty.City:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SystemParameterNavProperty.City1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (SystemParameterNavProperty)p.Value;
                switch(np)
                {
                    case SystemParameterNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SystemParameterNavProperty.City:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SystemParameterNavProperty.City1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<SystemParameter> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<SystemParameter> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (SystemParameterNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case SystemParameterNavProperty.Person:
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
                    case SystemParameterNavProperty.City:
                    #region City
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>();
                            foreach(var p in list)
                                navByKey.Add(p.CityID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.DeliveryCityID))
                                    c.City = navByKey[c.DeliveryCityID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SystemParameterNavProperty.City1:
                    #region City1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.City>();
                            foreach(var p in list)
                                navByKey.Add(p.CityID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.PostalCityID))
                                    c.City1 = navByKey[c.PostalCityID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.CityRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
