/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{
    public partial class SupplierTransactionRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing;
using WorldWideImportersE = TheSharpFactory.Data.Entity.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class represents the Repository for: SupplierTransaction.
    /// </summary>
    public partial class SupplierTransactionRepository:WritableRepositoryBase<SupplierTransaction, SupplierTransactionProperty, SupplierTransactionNavProperty>, ISupplierTransactionRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<SupplierTransactionNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<SupplierTransactionNavProperty, NavPropertyInfo>(5){ { SupplierTransactionNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { SupplierTransactionNavProperty.PaymentMethod, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_PaymentMethod, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.PaymentMethodID, OtherPropId = (int)WorldWideImportersE.Application.PaymentMethodProperty.PaymentMethodID, },} } }, { SupplierTransactionNavProperty.PurchaseOrder, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_PurchaseOrder, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.PurchaseOrderID, OtherPropId = (int)WorldWideImportersE.Purchasing.PurchaseOrderProperty.PurchaseOrderID, },} } }, { SupplierTransactionNavProperty.Supplier, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_Supplier, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.SupplierID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierProperty.SupplierID, },} } }, { SupplierTransactionNavProperty.TransactionType, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_TransactionType, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.TransactionTypeID, OtherPropId = (int)WorldWideImportersE.Application.TransactionTypeProperty.TransactionTypeID, },} } },};
        #endregion
        #region Constructors
        public SupplierTransactionRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierTransaction;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Purchasing_SupplierTransactions) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<SupplierTransactionProperty>(1){ SortFilter.New(SupplierTransactionProperty.SupplierTransactionID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="suppliertransactionid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        public SupplierTransaction ByPK(int suppliertransactionid)
        {
            var where = new QueryFilters<SupplierTransactionProperty>(1){QueryFilter.New(SupplierTransactionProperty.SupplierTransactionID, FilterConditions.Equals, suppliertransactionid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="suppliertransactionid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction</returns>
        public SupplierTransaction ByPK(int suppliertransactionid, NavProps<SupplierTransactionNavProperty> navprops)
        {
            var where = new QueryFilters<SupplierTransactionProperty>(1){QueryFilter.New(SupplierTransactionProperty.SupplierTransactionID, FilterConditions.Equals, suppliertransactionid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="suppliertransactionid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int suppliertransactionid)
        {
            var where = new QueryFilters<SupplierTransactionProperty>(1){QueryFilter.New(SupplierTransactionProperty.SupplierTransactionID, FilterConditions.Equals, suppliertransactionid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<SupplierTransactionProperty> ComposeKeys(SupplierTransaction suppliertransaction)
        {
            return new QueryFilters<SupplierTransactionProperty>{ QueryFilter.New(SupplierTransactionProperty.SupplierTransactionID, FilterConditions.Equals, suppliertransaction.SupplierTransactionID) };
        }
        protected override QueryFilters<SupplierTransactionProperty> GetChanges(SupplierTransaction original, SupplierTransaction changed)
        {
            return SupplierTransactionUtils.GetChanges(original, changed);
        }
        protected override void Merge(SupplierTransaction source, SupplierTransaction target)
        {
            SupplierTransactionUtils.Merge(source, target);
        }
        protected override QueryFilters<SupplierTransactionProperty> ComposeInsertPredicate(SupplierTransaction suppliertransaction)
        {
            return new QueryFilters<SupplierTransactionProperty>{ QueryFilter.New(SupplierTransactionProperty.SupplierTransactionID, FilterConditions.Equals, suppliertransaction.SupplierTransactionID), QueryFilter.New(SupplierTransactionProperty.SupplierID, FilterConditions.Equals, suppliertransaction.SupplierID), QueryFilter.New(SupplierTransactionProperty.TransactionTypeID, FilterConditions.Equals, suppliertransaction.TransactionTypeID), QueryFilter.New(SupplierTransactionProperty.PurchaseOrderID, FilterConditions.Equals, suppliertransaction.PurchaseOrderID), QueryFilter.New(SupplierTransactionProperty.PaymentMethodID, FilterConditions.Equals, suppliertransaction.PaymentMethodID), QueryFilter.New(SupplierTransactionProperty.SupplierInvoiceNumber, FilterConditions.Equals, suppliertransaction.SupplierInvoiceNumber), QueryFilter.New(SupplierTransactionProperty.TransactionDate, FilterConditions.Equals, suppliertransaction.TransactionDate), QueryFilter.New(SupplierTransactionProperty.AmountExcludingTax, FilterConditions.Equals, suppliertransaction.AmountExcludingTax), QueryFilter.New(SupplierTransactionProperty.TaxAmount, FilterConditions.Equals, suppliertransaction.TaxAmount), QueryFilter.New(SupplierTransactionProperty.TransactionAmount, FilterConditions.Equals, suppliertransaction.TransactionAmount), QueryFilter.New(SupplierTransactionProperty.OutstandingBalance, FilterConditions.Equals, suppliertransaction.OutstandingBalance), QueryFilter.New(SupplierTransactionProperty.FinalizationDate, FilterConditions.Equals, suppliertransaction.FinalizationDate), QueryFilter.New(SupplierTransactionProperty.LastEditedBy, FilterConditions.Equals, suppliertransaction.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 15);
        }
        private static SupplierTransaction MaterializeSingleEntity(SqlDataReader r)
        {
            return new SupplierTransaction
            {
                SupplierTransactionID = r.GetInt32(0),
                SupplierID = r.GetInt32(1),
                TransactionTypeID = r.GetInt32(2),
                PurchaseOrderID = r.GetValue(3) as int?,
                PaymentMethodID = r.GetValue(4) as int?,
                SupplierInvoiceNumber = r.GetValue(5) as string,
                TransactionDate = r.GetDateTime(6),
                AmountExcludingTax = r.GetDecimal(7),
                TaxAmount = r.GetDecimal(8),
                TransactionAmount = r.GetDecimal(9),
                OutstandingBalance = r.GetDecimal(10),
                FinalizationDate = r.GetValue(11) as DateTime?,
                IsFinalized = r.GetValue(12) as bool?,
                LastEditedBy = r.GetInt32(13),
                LastEditedWhen = r.GetDateTime(14),
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
                var np = (SupplierTransactionNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case SupplierTransactionNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierTransactionNavProperty.PaymentMethod:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierTransactionNavProperty.PurchaseOrder:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierTransactionNavProperty.Supplier:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case SupplierTransactionNavProperty.TransactionType:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (SupplierTransactionNavProperty)p.Value;
                switch(np)
                {
                    case SupplierTransactionNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierTransactionNavProperty.PaymentMethod:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierTransactionNavProperty.PurchaseOrder:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierTransactionNavProperty.Supplier:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case SupplierTransactionNavProperty.TransactionType:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<SupplierTransaction> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<SupplierTransaction> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (SupplierTransactionNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case SupplierTransactionNavProperty.Person:
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
                    case SupplierTransactionNavProperty.PaymentMethod:
                    #region PaymentMethod
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod>();
                            foreach(var p in list)
                                navByKey.Add(p.PaymentMethodID, p);
                            foreach(var c in entities)
                            {
                                if(!c.PaymentMethodID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.PaymentMethodID.Value))
                                    c.PaymentMethod = navByKey[c.PaymentMethodID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierTransactionNavProperty.PurchaseOrder:
                    #region PurchaseOrder
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder>();
                            foreach(var p in list)
                                navByKey.Add(p.PurchaseOrderID, p);
                            foreach(var c in entities)
                            {
                                if(!c.PurchaseOrderID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.PurchaseOrderID.Value))
                                    c.PurchaseOrder = navByKey[c.PurchaseOrderID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.PurchaseOrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierTransactionNavProperty.Supplier:
                    #region Supplier
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.Supplier>();
                            foreach(var p in list)
                                navByKey.Add(p.SupplierID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.SupplierID))
                                    c.Supplier = navByKey[c.SupplierID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case SupplierTransactionNavProperty.TransactionType:
                    #region TransactionType
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.TransactionType>();
                            foreach(var p in list)
                                navByKey.Add(p.TransactionTypeID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.TransactionTypeID))
                                    c.TransactionType = navByKey[c.TransactionTypeID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.TransactionTypeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
