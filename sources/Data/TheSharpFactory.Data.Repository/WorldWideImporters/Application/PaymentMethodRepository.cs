/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class PaymentMethodRepository
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
    /// This class represents the Repository for: PaymentMethod.
    /// </summary>
    public partial class PaymentMethodRepository:WritableRepositoryBase<PaymentMethod, PaymentMethodProperty, PaymentMethodNavProperty>, IPaymentMethodRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<PaymentMethodNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<PaymentMethodNavProperty, NavPropertyInfo>(3){ { PaymentMethodNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PaymentMethodProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { PaymentMethodNavProperty.SupplierTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PaymentMethodProperty.PaymentMethodID, OtherPropId = (int)WorldWideImportersE.Purchasing.SupplierTransactionProperty.PaymentMethodID, },} } }, { PaymentMethodNavProperty.CustomerTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Application.PaymentMethodProperty.PaymentMethodID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.PaymentMethodID, },} } },};
        #endregion
        #region Constructors
        public PaymentMethodRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_PaymentMethod;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Application_PaymentMethods) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<PaymentMethodProperty>(1){ SortFilter.New(PaymentMethodProperty.PaymentMethodID),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UQ_Application_PaymentMethods_PaymentMethodName) sorting.
        private static readonly SortFilters<PaymentMethodProperty> _sortBy_UQ_Application_PaymentMethods_PaymentMethodName = new SortFilters<PaymentMethodProperty>(1){ SortFilter.New(PaymentMethodProperty.PaymentMethodName),};
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Primary Key.
        /// </summary>
        /// <param name="paymentmethodid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        public PaymentMethod ByPK(int paymentmethodid)
        {
            var where = new QueryFilters<PaymentMethodProperty>(1){QueryFilter.New(PaymentMethodProperty.PaymentMethodID, FilterConditions.Equals, paymentmethodid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="paymentmethodid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        public PaymentMethod ByPK(int paymentmethodid, NavProps<PaymentMethodNavProperty> navprops)
        {
            var where = new QueryFilters<PaymentMethodProperty>(1){QueryFilter.New(PaymentMethodProperty.PaymentMethodID, FilterConditions.Equals, paymentmethodid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Unique Key named UQ_Application_PaymentMethods_PaymentMethodName.
        /// </summary>
        /// <param name="paymentmethodname">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        public PaymentMethod ByUK(string paymentmethodname)
        {
            //this method uses the UniqueKey UQ_Application_PaymentMethods_PaymentMethodName
            var where = new QueryFilters<PaymentMethodProperty>(1){QueryFilter.New(PaymentMethodProperty.PaymentMethodName, FilterConditions.Equals, paymentmethodname ), };
            return SelectSingle(where, _sortBy_UQ_Application_PaymentMethods_PaymentMethodName);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Unique Key named UQ_Application_PaymentMethods_PaymentMethodName. Supports navigation properties.
        /// </summary>
        /// <param name="paymentmethodname">Unique Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod</returns>
        public PaymentMethod ByUK(string paymentmethodname, NavProps<PaymentMethodNavProperty> navprops)
        {
            //this method uses the UniqueKey UQ_Application_PaymentMethods_PaymentMethodName
            var where = new QueryFilters<PaymentMethodProperty>(1){QueryFilter.New(PaymentMethodProperty.PaymentMethodName, FilterConditions.Equals, paymentmethodname ), };
            return SelectSingle(where, _sortBy_UQ_Application_PaymentMethods_PaymentMethodName, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Primary Key.
        /// </summary>
        /// <param name="paymentmethodid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int paymentmethodid)
        {
            var where = new QueryFilters<PaymentMethodProperty>(1){QueryFilter.New(PaymentMethodProperty.PaymentMethodID, FilterConditions.Equals, paymentmethodid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Application.PaymentMethod from the database by Unique Key named UQ_Application_PaymentMethods_PaymentMethodName
        /// </summary>
        /// <param name="paymentmethodname">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string paymentmethodname)
        {
            //this method uses the UniqueKey UQ_Application_PaymentMethods_PaymentMethodName
            var where = new QueryFilters<PaymentMethodProperty>(1){QueryFilter.New(PaymentMethodProperty.PaymentMethodName, FilterConditions.Equals, paymentmethodname), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<PaymentMethodProperty> ComposeKeys(PaymentMethod paymentmethod)
        {
            return new QueryFilters<PaymentMethodProperty>{ QueryFilter.New(PaymentMethodProperty.PaymentMethodID, FilterConditions.Equals, paymentmethod.PaymentMethodID) };
        }
        protected override QueryFilters<PaymentMethodProperty> GetChanges(PaymentMethod original, PaymentMethod changed)
        {
            return PaymentMethodUtils.GetChanges(original, changed);
        }
        protected override void Merge(PaymentMethod source, PaymentMethod target)
        {
            PaymentMethodUtils.Merge(source, target);
        }
        protected override QueryFilters<PaymentMethodProperty> ComposeInsertPredicate(PaymentMethod paymentmethod)
        {
            return new QueryFilters<PaymentMethodProperty>{ QueryFilter.New(PaymentMethodProperty.PaymentMethodID, FilterConditions.Equals, paymentmethod.PaymentMethodID), QueryFilter.New(PaymentMethodProperty.PaymentMethodName, FilterConditions.Equals, paymentmethod.PaymentMethodName), QueryFilter.New(PaymentMethodProperty.LastEditedBy, FilterConditions.Equals, paymentmethod.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static PaymentMethod MaterializeSingleEntity(SqlDataReader r)
        {
            return new PaymentMethod
            {
                PaymentMethodID = r.GetInt32(0),
                PaymentMethodName = r.GetString(1),
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
                var np = (PaymentMethodNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case PaymentMethodNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PaymentMethodNavProperty.SupplierTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case PaymentMethodNavProperty.CustomerTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (PaymentMethodNavProperty)p.Value;
                switch(np)
                {
                    case PaymentMethodNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PaymentMethodNavProperty.SupplierTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case PaymentMethodNavProperty.CustomerTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<PaymentMethod> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, PaymentMethod> ComposeDictionaryByPK(List<PaymentMethod> entities, MultiKeyDictionary<int, PaymentMethod> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, PaymentMethod>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.PaymentMethodID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<PaymentMethod> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, PaymentMethod>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (PaymentMethodNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case PaymentMethodNavProperty.Person:
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
                    case PaymentMethodNavProperty.SupplierTransactions:
                    #region SupplierTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PaymentMethodID.Value];
                                p.SupplierTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.SupplierTransaction>(p.SupplierTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing.SupplierTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case PaymentMethodNavProperty.CustomerTransactions:
                    #region CustomerTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.PaymentMethodID.Value];
                                p.CustomerTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(p.CustomerTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
