/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class CountryRepository
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
    /// This class represents the Repository for: Country.
    /// </summary>
    public partial class CountryRepository:WritableRepositoryBase<Country, CountryProperty, CountryNavProperty>, ICountryRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<CountryNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<CountryNavProperty, NavPropertyInfo>(2){ { CountryNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CountryProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { CountryNavProperty.StateProvinces, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_StateProvince, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.CountryProperty.CountryID, OtherPropId = (int)WorldWideImportersE.Application.StateProvinceProperty.CountryID, },} } },};
        #endregion
        #region Constructors
        public CountryRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Country;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Application_Countries) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<CountryProperty>(1){ SortFilter.New(CountryProperty.CountryID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Application_Countries_CountryName) sorting.
        private static readonly SortFilters<CountryProperty> _sortBy_UQ_Application_Countries_CountryName = new SortFilters<CountryProperty>(1){ SortFilter.New(CountryProperty.CountryName),};
        //this is the UK(UQ_Application_Countries_FormalName) sorting.
        private static readonly SortFilters<CountryProperty> _sortBy_UQ_Application_Countries_FormalName = new SortFilters<CountryProperty>(1){ SortFilter.New(CountryProperty.FormalName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country from the database by Primary Key.
        /// </summary>
        /// <param name="countryid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country</returns>
        public Country ByPK(int countryid)
        {
            var where = new QueryFilters<CountryProperty>(1){QueryFilter.New(CountryProperty.CountryID, FilterConditions.Equals, countryid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="countryid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country</returns>
        public Country ByPK(int countryid, NavProps<CountryNavProperty> navprops)
        {
            var where = new QueryFilters<CountryProperty>(1){QueryFilter.New(CountryProperty.CountryID, FilterConditions.Equals, countryid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country from the database by Unique Key named UQ_Application_Countries_CountryName.
        /// </summary>
        /// <param name="countryname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country</returns>
        public Country ByUK1(string countryname)
        {
            //this method uses the UniqueKey UQ_Application_Countries_CountryName
            var where = new QueryFilters<CountryProperty>(1){QueryFilter.New(CountryProperty.CountryName, FilterConditions.Equals, countryname ), };
            return SelectSingle(where, _sortBy_UQ_Application_Countries_CountryName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country from the database by Unique Key named UQ_Application_Countries_CountryName. Supports navigation properties.
        /// </summary>
        /// <param name="countryname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country</returns>
        public Country ByUK1(string countryname, NavProps<CountryNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Application_Countries_CountryName
            var where = new QueryFilters<CountryProperty>(1){QueryFilter.New(CountryProperty.CountryName, FilterConditions.Equals, countryname ), };
            return SelectSingle(where, _sortBy_UQ_Application_Countries_CountryName, navprops);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country from the database by Unique Key named UQ_Application_Countries_FormalName.
        /// </summary>
        /// <param name="formalname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country</returns>
        public Country ByUK2(string formalname)
        {
            //this method uses the UniqueKey UQ_Application_Countries_FormalName
            var where = new QueryFilters<CountryProperty>(1){QueryFilter.New(CountryProperty.FormalName, FilterConditions.Equals, formalname ), };
            return SelectSingle(where, _sortBy_UQ_Application_Countries_FormalName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country from the database by Unique Key named UQ_Application_Countries_FormalName. Supports navigation properties.
        /// </summary>
        /// <param name="formalname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country</returns>
        public Country ByUK2(string formalname, NavProps<CountryNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Application_Countries_FormalName
            var where = new QueryFilters<CountryProperty>(1){QueryFilter.New(CountryProperty.FormalName, FilterConditions.Equals, formalname ), };
            return SelectSingle(where, _sortBy_UQ_Application_Countries_FormalName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country from the database by Primary Key.
        /// </summary>
        /// <param name="countryid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int countryid)
        {
            var where = new QueryFilters<CountryProperty>(1){QueryFilter.New(CountryProperty.CountryID, FilterConditions.Equals, countryid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country from the database by Unique Key named UQ_Application_Countries_CountryName
        /// </summary>
        /// <param name="countryname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK1(string countryname)
        {
            //this method uses the UniqueKey UQ_Application_Countries_CountryName
            var where = new QueryFilters<CountryProperty>(1){QueryFilter.New(CountryProperty.CountryName, FilterConditions.Equals, countryname), };
            return DeleteAny(where) > 0;
        }
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.Country from the database by Unique Key named UQ_Application_Countries_FormalName
        /// </summary>
        /// <param name="formalname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK2(string formalname)
        {
            //this method uses the UniqueKey UQ_Application_Countries_FormalName
            var where = new QueryFilters<CountryProperty>(1){QueryFilter.New(CountryProperty.FormalName, FilterConditions.Equals, formalname), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<CountryProperty> ComposeKeys(Country country)
        {
            return new QueryFilters<CountryProperty>{ QueryFilter.New(CountryProperty.CountryID, FilterConditions.Equals, country.CountryID) };
        }
        protected override QueryFilters<CountryProperty> GetChanges(Country original, Country changed)
        {
            return CountryUtils.GetChanges(original, changed);
        }
        protected override void Merge(Country source, Country target)
        {
            CountryUtils.Merge(source, target);
        }
        protected override QueryFilters<CountryProperty> ComposeInsertPredicate(Country country)
        {
            return new QueryFilters<CountryProperty>{ QueryFilter.New(CountryProperty.CountryID, FilterConditions.Equals, country.CountryID), QueryFilter.New(CountryProperty.CountryName, FilterConditions.Equals, country.CountryName), QueryFilter.New(CountryProperty.FormalName, FilterConditions.Equals, country.FormalName), QueryFilter.New(CountryProperty.IsoAlpha3Code, FilterConditions.Equals, country.IsoAlpha3Code), QueryFilter.New(CountryProperty.IsoNumericCode, FilterConditions.Equals, country.IsoNumericCode), QueryFilter.New(CountryProperty.CountryType, FilterConditions.Equals, country.CountryType), QueryFilter.New(CountryProperty.LatestRecordedPopulation, FilterConditions.Equals, country.LatestRecordedPopulation), QueryFilter.New(CountryProperty.Continent, FilterConditions.Equals, country.Continent), QueryFilter.New(CountryProperty.Region, FilterConditions.Equals, country.Region), QueryFilter.New(CountryProperty.Subregion, FilterConditions.Equals, country.Subregion), QueryFilter.New(CountryProperty.Border, FilterConditions.Equals, country.Border), QueryFilter.New(CountryProperty.LastEditedBy, FilterConditions.Equals, country.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 14);
        }
        private static Country MaterializeSingleEntity(SqlDataReader r)
        {
            return new Country
            {
                CountryID = r.GetInt32(0),
                CountryName = r.GetString(1),
                FormalName = r.GetString(2),
                IsoAlpha3Code = r.GetValue(3) as string,
                IsoNumericCode = r.GetValue(4) as int?,
                CountryType = r.GetValue(5) as string,
                LatestRecordedPopulation = r.GetValue(6) as long?,
                Continent = r.GetString(7),
                Region = r.GetString(8),
                Subregion = r.GetString(9),
                Border = Microsoft.SqlServer.Types.SqlGeography.Deserialize(r.GetSqlBytes(10)),
                LastEditedBy = r.GetInt32(11),
                ValidFrom = r.GetDateTime(12),
                ValidTo = r.GetDateTime(13),
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
                var np = (CountryNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case CountryNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CountryNavProperty.StateProvinces:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (CountryNavProperty)p.Value;
                switch(np)
                {
                    case CountryNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CountryNavProperty.StateProvinces:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<Country> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Country> ComposeDictionaryByPK(List<Country> entities, MultiKeyDictionary<int, Country> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Country>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.CountryID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Country> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Country>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (CountryNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case CountryNavProperty.Person:
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
                    case CountryNavProperty.StateProvinces:
                    #region StateProvinces
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.CountryID];
                                p.StateProvinces = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.StateProvince>(p.StateProvinces, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.StateProvinceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
