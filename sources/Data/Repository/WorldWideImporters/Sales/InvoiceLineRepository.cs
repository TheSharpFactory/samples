/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class InvoiceLineRepository
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
    /// This class represents the Repository for: InvoiceLine.
    /// </summary>
    public partial class InvoiceLineRepository:WritableRepositoryBase<InvoiceLine, InvoiceLineProperty, InvoiceLineNavProperty>, IInvoiceLineRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<InvoiceLineNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<InvoiceLineNavProperty, NavPropertyInfo>(4){ { InvoiceLineNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceLineProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { InvoiceLineNavProperty.Invoice, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceLineProperty.InvoiceID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.InvoiceID, },} } }, { InvoiceLineNavProperty.PackageType, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_PackageType, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceLineProperty.PackageTypeID, OtherPropId = (int)WorldWideImportersE.Warehouse.PackageTypeProperty.PackageTypeID, },} } }, { InvoiceLineNavProperty.StockItem, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItem, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceLineProperty.StockItemID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemProperty.StockItemID, },} } },};
        #endregion
        #region Constructors
        public InvoiceLineRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_InvoiceLine;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Sales_InvoiceLines) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<InvoiceLineProperty>(1){ SortFilter.New(InvoiceLineProperty.InvoiceLineID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database by Primary Key.
        /// </summary>
        /// <param name="invoicelineid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        public InvoiceLine ByPK(int invoicelineid)
        {
            var where = new QueryFilters<InvoiceLineProperty>(1){QueryFilter.New(InvoiceLineProperty.InvoiceLineID, FilterConditions.Equals, invoicelineid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="invoicelineid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine</returns>
        public InvoiceLine ByPK(int invoicelineid, NavProps<InvoiceLineNavProperty> navprops)
        {
            var where = new QueryFilters<InvoiceLineProperty>(1){QueryFilter.New(InvoiceLineProperty.InvoiceLineID, FilterConditions.Equals, invoicelineid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine from the database by Primary Key.
        /// </summary>
        /// <param name="invoicelineid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int invoicelineid)
        {
            var where = new QueryFilters<InvoiceLineProperty>(1){QueryFilter.New(InvoiceLineProperty.InvoiceLineID, FilterConditions.Equals, invoicelineid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<InvoiceLineProperty> ComposeKeys(InvoiceLine invoiceline)
        {
            return new QueryFilters<InvoiceLineProperty>{ QueryFilter.New(InvoiceLineProperty.InvoiceLineID, FilterConditions.Equals, invoiceline.InvoiceLineID) };
        }
        protected override QueryFilters<InvoiceLineProperty> GetChanges(InvoiceLine original, InvoiceLine changed)
        {
            return InvoiceLineUtils.GetChanges(original, changed);
        }
        protected override void Merge(InvoiceLine source, InvoiceLine target)
        {
            InvoiceLineUtils.Merge(source, target);
        }
        protected override QueryFilters<InvoiceLineProperty> ComposeInsertPredicate(InvoiceLine invoiceline)
        {
            return new QueryFilters<InvoiceLineProperty>{ QueryFilter.New(InvoiceLineProperty.InvoiceLineID, FilterConditions.Equals, invoiceline.InvoiceLineID), QueryFilter.New(InvoiceLineProperty.InvoiceID, FilterConditions.Equals, invoiceline.InvoiceID), QueryFilter.New(InvoiceLineProperty.StockItemID, FilterConditions.Equals, invoiceline.StockItemID), QueryFilter.New(InvoiceLineProperty.Description, FilterConditions.Equals, invoiceline.Description), QueryFilter.New(InvoiceLineProperty.PackageTypeID, FilterConditions.Equals, invoiceline.PackageTypeID), QueryFilter.New(InvoiceLineProperty.Quantity, FilterConditions.Equals, invoiceline.Quantity), QueryFilter.New(InvoiceLineProperty.UnitPrice, FilterConditions.Equals, invoiceline.UnitPrice), QueryFilter.New(InvoiceLineProperty.TaxRate, FilterConditions.Equals, invoiceline.TaxRate), QueryFilter.New(InvoiceLineProperty.TaxAmount, FilterConditions.Equals, invoiceline.TaxAmount), QueryFilter.New(InvoiceLineProperty.LineProfit, FilterConditions.Equals, invoiceline.LineProfit), QueryFilter.New(InvoiceLineProperty.ExtendedPrice, FilterConditions.Equals, invoiceline.ExtendedPrice), QueryFilter.New(InvoiceLineProperty.LastEditedBy, FilterConditions.Equals, invoiceline.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 13);
        }
        private static InvoiceLine MaterializeSingleEntity(SqlDataReader r)
        {
            return new InvoiceLine
            {
                InvoiceLineID = r.GetInt32(0),
                InvoiceID = r.GetInt32(1),
                StockItemID = r.GetInt32(2),
                Description = r.GetString(3),
                PackageTypeID = r.GetInt32(4),
                Quantity = r.GetInt32(5),
                UnitPrice = r.GetValue(6) as decimal?,
                TaxRate = r.GetDecimal(7),
                TaxAmount = r.GetDecimal(8),
                LineProfit = r.GetDecimal(9),
                ExtendedPrice = r.GetDecimal(10),
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
                var np = (InvoiceLineNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case InvoiceLineNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceLineNavProperty.Invoice:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceLineNavProperty.PackageType:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceLineNavProperty.StockItem:
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
                var np = (InvoiceLineNavProperty)p.Value;
                switch(np)
                {
                    case InvoiceLineNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceLineNavProperty.Invoice:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceLineNavProperty.PackageType:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceLineNavProperty.StockItem:
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
        protected override void BuildObjectGraph(List<InvoiceLine> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<InvoiceLine> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (InvoiceLineNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case InvoiceLineNavProperty.Person:
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
                    case InvoiceLineNavProperty.Invoice:
                    #region Invoice
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice>();
                            foreach(var p in list)
                                navByKey.Add(p.InvoiceID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.InvoiceID))
                                    c.Invoice = navByKey[c.InvoiceID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceLineNavProperty.PackageType:
                    #region PackageType
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.PackageType>();
                            foreach(var p in list)
                                navByKey.Add(p.PackageTypeID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.PackageTypeID))
                                    c.PackageType = navByKey[c.PackageTypeID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.PackageTypeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceLineNavProperty.StockItem:
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
