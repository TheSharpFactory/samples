/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class CityRepository
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
    /// This class represents the Repository for: City.
    /// </summary>
    public partial class CityRepository:WritableRepositoryBase<City, CityProperty, CityNavProperty>, ICityRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<CityNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<CityNavProperty, NavPropertyInfo>(8){ { CityNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CityProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { CityNavProperty.StateProvince, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_StateProvince, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CityProperty.StateProvinceID, OtherPropId = (int)WorldWideImportersE.Application.StateProvinceProperty.StateProvinceID, },} } }, { CityNavProperty.SystemParameters, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_SystemParameter, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CityProperty.CityID, OtherPropId = (int)WorldWideImportersE.Application.SystemParameterProperty.DeliveryCityID, },} } }, { CityNavProperty.SystemParameters1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_SystemParameter, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CityProperty.CityID, OtherPropId = (int)WorldWideImportersE.Application.SystemParameterProperty.PostalCityID, },} } }, { CityNavProperty.Suppliers, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CityProperty.CityID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.DeliveryCityID, },} } }, { CityNavProperty.Suppliers1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CityProperty.CityID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.PostalCityID, },} } }, { CityNavProperty.Customers, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CityProperty.CityID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.DeliveryCityID, },} } }, { CityNavProperty.Customers1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CityProperty.CityID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.PostalCityID, },} } },};
        #endregion
        #region Constructors
        public CityRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_City;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Application_Cities) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<CityProperty>(1){ SortFilter.New(CityProperty.CityID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.City from the database by Primary Key.
        /// </summary>
        /// <param name="cityid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.City</returns>
        public City ByPK(int cityid)
        {
            var where = new QueryFilters<CityProperty>(1){QueryFilter.New(CityProperty.CityID, FilterConditions.Equals, cityid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.City from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="cityid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.City</returns>
        public City ByPK(int cityid, NavProps<CityNavProperty> navprops)
        {
            var where = new QueryFilters<CityProperty>(1){QueryFilter.New(CityProperty.CityID, FilterConditions.Equals, cityid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.City from the database by Primary Key.
        /// </summary>
        /// <param name="cityid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int cityid)
        {
            var where = new QueryFilters<CityProperty>(1){QueryFilter.New(CityProperty.CityID, FilterConditions.Equals, cityid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<CityProperty> ComposeKeys(City city)
        {
            return new QueryFilters<CityProperty>{ QueryFilter.New(CityProperty.CityID, FilterConditions.Equals, city.CityID) };
        }
        protected override QueryFilters<CityProperty> GetChanges(City original, City changed)
        {
            return CityUtils.GetChanges(original, changed);
        }
        protected override void Merge(City source, City target)
        {
            CityUtils.Merge(source, target);
        }
        protected override QueryFilters<CityProperty> ComposeInsertPredicate(City city)
        {
            return new QueryFilters<CityProperty>{ QueryFilter.New(CityProperty.CityID, FilterConditions.Equals, city.CityID), QueryFilter.New(CityProperty.CityName, FilterConditions.Equals, city.CityName), QueryFilter.New(CityProperty.StateProvinceID, FilterConditions.Equals, city.StateProvinceID), QueryFilter.New(CityProperty.Location, FilterConditions.Equals, city.Location), QueryFilter.New(CityProperty.LatestRecordedPopulation, FilterConditions.Equals, city.LatestRecordedPopulation), QueryFilter.New(CityProperty.LastEditedBy, FilterConditions.Equals, city.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 8);
        }
        private static City MaterializeSingleEntity(SqlDataReader r)
        {
            return new City
            {
                CityID = r.GetInt32(0),
                CityName = r.GetString(1),
                StateProvinceID = r.GetInt32(2),
                Location = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(3)),
                LatestRecordedPopulation = r.GetValue(4) as long?,
                LastEditedBy = r.GetInt32(5),
                ValidFrom = r.GetDateTime(6),
                ValidTo = r.GetDateTime(7),
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
                var np = (CityNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case CityNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CityNavProperty.StateProvince:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CityNavProperty.SystemParameters:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CityNavProperty.SystemParameters1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CityNavProperty.Suppliers:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CityNavProperty.Suppliers1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CityNavProperty.Customers:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CityNavProperty.Customers1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (CityNavProperty)p.Value;
                switch(np)
                {
                    case CityNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CityNavProperty.StateProvince:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CityNavProperty.SystemParameters:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CityNavProperty.SystemParameters1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CityNavProperty.Suppliers:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CityNavProperty.Suppliers1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CityNavProperty.Customers:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CityNavProperty.Customers1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<City> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, City> ComposeDictionaryByPK(List<City> entities, MultiKeyDictionary<int, City> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, City>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.CityID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<City> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, City>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (CityNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case CityNavProperty.Person:
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
                    case CityNavProperty.StateProvince:
                    #region StateProvince
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince>();
                            foreach(var p in list)
                                navByKey.Add(p.StateProvinceID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.StateProvinceID))
                                    c.StateProvince = navByKey[c.StateProvinceID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CityNavProperty.SystemParameters:
                    #region SystemParameters
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.DeliveryCityID];
                                p.SystemParameters = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter>(p.SystemParameters, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CityNavProperty.SystemParameters1:
                    #region SystemParameters1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PostalCityID];
                                p.SystemParameters1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.SystemParameter>(p.SystemParameters1, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.SystemParameterRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CityNavProperty.Suppliers:
                    #region Suppliers
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.DeliveryCityID];
                                p.Suppliers = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(p.Suppliers, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CityNavProperty.Suppliers1:
                    #region Suppliers1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PostalCityID];
                                p.Suppliers1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(p.Suppliers1, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CityNavProperty.Customers:
                    #region Customers
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.DeliveryCityID];
                                p.Customers = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(p.Customers, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CityNavProperty.Customers1:
                    #region Customers1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PostalCityID];
                                p.Customers1 = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer>(p.Customers1, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
