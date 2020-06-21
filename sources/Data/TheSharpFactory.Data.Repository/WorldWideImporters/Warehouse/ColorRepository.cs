/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class ColorRepository
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
    /// This class represents the Repository for: Color.
    /// </summary>
    public partial class ColorRepository:WritableRepositoryBase<Color, ColorProperty, ColorNavProperty>, IColorRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<ColorNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<ColorNavProperty, NavPropertyInfo>(2){ { ColorNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.ColorProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { ColorNavProperty.StockItems, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Warehouse.ColorProperty.ColorID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.ColorID, },} } },};
        #endregion
        #region Constructors
        public ColorRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_Color;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Warehouse_Colors) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<ColorProperty>(1){ SortFilter.New(ColorProperty.ColorID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Warehouse_Colors_ColorName) sorting.
        private static readonly SortFilters<ColorProperty> _sortBy_UQ_Warehouse_Colors_ColorName = new SortFilters<ColorProperty>(1){ SortFilter.New(ColorProperty.ColorName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color from the database by Primary Key.
        /// </summary>
        /// <param name="colorid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color</returns>
        public Color ByPK(int colorid)
        {
            var where = new QueryFilters<ColorProperty>(1){QueryFilter.New(ColorProperty.ColorID, FilterConditions.Equals, colorid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="colorid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color</returns>
        public Color ByPK(int colorid, NavProps<ColorNavProperty> navprops)
        {
            var where = new QueryFilters<ColorProperty>(1){QueryFilter.New(ColorProperty.ColorID, FilterConditions.Equals, colorid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color from the database by Unique Key named UQ_Warehouse_Colors_ColorName.
        /// </summary>
        /// <param name="colorname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color</returns>
        public Color ByUK(string colorname)
        {
            //this method uses the UniqueKey UQ_Warehouse_Colors_ColorName
            var where = new QueryFilters<ColorProperty>(1){QueryFilter.New(ColorProperty.ColorName, FilterConditions.Equals, colorname ), };
            return SelectSingle(where, _sortBy_UQ_Warehouse_Colors_ColorName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color from the database by Unique Key named UQ_Warehouse_Colors_ColorName. Supports navigation properties.
        /// </summary>
        /// <param name="colorname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color</returns>
        public Color ByUK(string colorname, NavProps<ColorNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Warehouse_Colors_ColorName
            var where = new QueryFilters<ColorProperty>(1){QueryFilter.New(ColorProperty.ColorName, FilterConditions.Equals, colorname ), };
            return SelectSingle(where, _sortBy_UQ_Warehouse_Colors_ColorName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color from the database by Primary Key.
        /// </summary>
        /// <param name="colorid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int colorid)
        {
            var where = new QueryFilters<ColorProperty>(1){QueryFilter.New(ColorProperty.ColorID, FilterConditions.Equals, colorid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.Color from the database by Unique Key named UQ_Warehouse_Colors_ColorName
        /// </summary>
        /// <param name="colorname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string colorname)
        {
            //this method uses the UniqueKey UQ_Warehouse_Colors_ColorName
            var where = new QueryFilters<ColorProperty>(1){QueryFilter.New(ColorProperty.ColorName, FilterConditions.Equals, colorname), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<ColorProperty> ComposeKeys(Color color)
        {
            return new QueryFilters<ColorProperty>{ QueryFilter.New(ColorProperty.ColorID, FilterConditions.Equals, color.ColorID) };
        }
        protected override QueryFilters<ColorProperty> GetChanges(Color original, Color changed)
        {
            return ColorUtils.GetChanges(original, changed);
        }
        protected override void Merge(Color source, Color target)
        {
            ColorUtils.Merge(source, target);
        }
        protected override QueryFilters<ColorProperty> ComposeInsertPredicate(Color color)
        {
            return new QueryFilters<ColorProperty>{ QueryFilter.New(ColorProperty.ColorID, FilterConditions.Equals, color.ColorID), QueryFilter.New(ColorProperty.ColorName, FilterConditions.Equals, color.ColorName), QueryFilter.New(ColorProperty.LastEditedBy, FilterConditions.Equals, color.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static Color MaterializeSingleEntity(SqlDataReader r)
        {
            return new Color
            {
                ColorID = r.GetInt32(0),
                ColorName = r.GetString(1),
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
                var np = (ColorNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case ColorNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case ColorNavProperty.StockItems:
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
                var np = (ColorNavProperty)p.Value;
                switch(np)
                {
                    case ColorNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case ColorNavProperty.StockItems:
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
        protected override void BuildObjectGraph(List<Color> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Color> ComposeDictionaryByPK(List<Color> entities, MultiKeyDictionary<int, Color> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Color>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.ColorID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Color> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Color>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (ColorNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case ColorNavProperty.Person:
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
                    case ColorNavProperty.StockItems:
                    #region StockItems
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.ColorID.Value];
                                p.StockItems = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItem>(p.StockItems, c);
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
