/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class CustomerTransactionRepository
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
    /// This class represents the Repository for: CustomerTransaction.
    /// </summary>
    public partial class CustomerTransactionRepository:WritableRepositoryBase<CustomerTransaction, CustomerTransactionProperty, CustomerTransactionNavProperty>, ICustomerTransactionRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<CustomerTransactionNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<CustomerTransactionNavProperty, NavPropertyInfo>(5){ { CustomerTransactionNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { CustomerTransactionNavProperty.Customer, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, },} } }, { CustomerTransactionNavProperty.Invoice, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.InvoiceID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceProperty.InvoiceID, },} } }, { CustomerTransactionNavProperty.PaymentMethod, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_PaymentMethod, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.PaymentMethodID, OtherPropId = (int)WorldWideImportersE.Application.PaymentMethodProperty.PaymentMethodID, },} } }, { CustomerTransactionNavProperty.TransactionType, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_TransactionType, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.TransactionTypeID, OtherPropId = (int)WorldWideImportersE.Application.TransactionTypeProperty.TransactionTypeID, },} } },};
        #endregion
        #region Constructors
        public CustomerTransactionRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerTransaction;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Sales_CustomerTransactions) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<CustomerTransactionProperty>(1){ SortFilter.New(CustomerTransactionProperty.CustomerTransactionID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="customertransactionid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction</returns>
        public CustomerTransaction ByPK(int customertransactionid)
        {
            var where = new QueryFilters<CustomerTransactionProperty>(1){QueryFilter.New(CustomerTransactionProperty.CustomerTransactionID, FilterConditions.Equals, customertransactionid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="customertransactionid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction</returns>
        public CustomerTransaction ByPK(int customertransactionid, NavProps<CustomerTransactionNavProperty> navprops)
        {
            var where = new QueryFilters<CustomerTransactionProperty>(1){QueryFilter.New(CustomerTransactionProperty.CustomerTransactionID, FilterConditions.Equals, customertransactionid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction from the database by Primary Key.
        /// </summary>
        /// <param name="customertransactionid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int customertransactionid)
        {
            var where = new QueryFilters<CustomerTransactionProperty>(1){QueryFilter.New(CustomerTransactionProperty.CustomerTransactionID, FilterConditions.Equals, customertransactionid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<CustomerTransactionProperty> ComposeKeys(CustomerTransaction customertransaction)
        {
            return new QueryFilters<CustomerTransactionProperty>{ QueryFilter.New(CustomerTransactionProperty.CustomerTransactionID, FilterConditions.Equals, customertransaction.CustomerTransactionID) };
        }
        protected override QueryFilters<CustomerTransactionProperty> GetChanges(CustomerTransaction original, CustomerTransaction changed)
        {
            return CustomerTransactionUtils.GetChanges(original, changed);
        }
        protected override void Merge(CustomerTransaction source, CustomerTransaction target)
        {
            CustomerTransactionUtils.Merge(source, target);
        }
        protected override QueryFilters<CustomerTransactionProperty> ComposeInsertPredicate(CustomerTransaction customertransaction)
        {
            return new QueryFilters<CustomerTransactionProperty>{ QueryFilter.New(CustomerTransactionProperty.CustomerTransactionID, FilterConditions.Equals, customertransaction.CustomerTransactionID), QueryFilter.New(CustomerTransactionProperty.CustomerID, FilterConditions.Equals, customertransaction.CustomerID), QueryFilter.New(CustomerTransactionProperty.TransactionTypeID, FilterConditions.Equals, customertransaction.TransactionTypeID), QueryFilter.New(CustomerTransactionProperty.InvoiceID, FilterConditions.Equals, customertransaction.InvoiceID), QueryFilter.New(CustomerTransactionProperty.PaymentMethodID, FilterConditions.Equals, customertransaction.PaymentMethodID), QueryFilter.New(CustomerTransactionProperty.TransactionDate, FilterConditions.Equals, customertransaction.TransactionDate), QueryFilter.New(CustomerTransactionProperty.AmountExcludingTax, FilterConditions.Equals, customertransaction.AmountExcludingTax), QueryFilter.New(CustomerTransactionProperty.TaxAmount, FilterConditions.Equals, customertransaction.TaxAmount), QueryFilter.New(CustomerTransactionProperty.TransactionAmount, FilterConditions.Equals, customertransaction.TransactionAmount), QueryFilter.New(CustomerTransactionProperty.OutstandingBalance, FilterConditions.Equals, customertransaction.OutstandingBalance), QueryFilter.New(CustomerTransactionProperty.FinalizationDate, FilterConditions.Equals, customertransaction.FinalizationDate), QueryFilter.New(CustomerTransactionProperty.LastEditedBy, FilterConditions.Equals, customertransaction.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 14);
        }
        private static CustomerTransaction MaterializeSingleEntity(SqlDataReader r)
        {
            return new CustomerTransaction
            {
                CustomerTransactionID = r.GetInt32(0),
                CustomerID = r.GetInt32(1),
                TransactionTypeID = r.GetInt32(2),
                InvoiceID = r.GetValue(3) as int?,
                PaymentMethodID = r.GetValue(4) as int?,
                TransactionDate = r.GetDateTime(5),
                AmountExcludingTax = r.GetDecimal(6),
                TaxAmount = r.GetDecimal(7),
                TransactionAmount = r.GetDecimal(8),
                OutstandingBalance = r.GetDecimal(9),
                FinalizationDate = r.GetValue(10) as DateTime?,
                IsFinalized = r.GetValue(11) as bool?,
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
                var np = (CustomerTransactionNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case CustomerTransactionNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerTransactionNavProperty.Customer:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerTransactionNavProperty.Invoice:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerTransactionNavProperty.PaymentMethod:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerTransactionNavProperty.TransactionType:
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
                var np = (CustomerTransactionNavProperty)p.Value;
                switch(np)
                {
                    case CustomerTransactionNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerTransactionNavProperty.Customer:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerTransactionNavProperty.Invoice:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerTransactionNavProperty.PaymentMethod:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PaymentMethodRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerTransactionNavProperty.TransactionType:
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
        protected override void BuildObjectGraph(List<CustomerTransaction> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<CustomerTransaction> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (CustomerTransactionNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case CustomerTransactionNavProperty.Person:
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
                    case CustomerTransactionNavProperty.Customer:
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
                                if(navByKey.ContainsKey(c.CustomerID))
                                    c.Customer = navByKey[c.CustomerID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerTransactionNavProperty.Invoice:
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
                                if(!c.InvoiceID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.InvoiceID.Value))
                                    c.Invoice = navByKey[c.InvoiceID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerTransactionNavProperty.PaymentMethod:
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
                    case CustomerTransactionNavProperty.TransactionType:
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
