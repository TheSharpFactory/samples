/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class InvoiceRepository
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
    /// This class represents the Repository for: Invoice.
    /// </summary>
    public partial class InvoiceRepository:WritableRepositoryBase<Invoice, InvoiceProperty, InvoiceNavProperty>, IInvoiceRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<InvoiceNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<InvoiceNavProperty, NavPropertyInfo>(12){ { InvoiceNavProperty.CustomerTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.InvoiceID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerTransactionProperty.InvoiceID, },} } }, { InvoiceNavProperty.InvoiceLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_InvoiceLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.InvoiceID, OtherPropId = (int)WorldWideImportersE.Sales.InvoiceLineProperty.InvoiceID, },} } }, { InvoiceNavProperty.Person, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.AccountsPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { InvoiceNavProperty.Person1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.LastEditedBy, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { InvoiceNavProperty.Customer, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.BillToCustomerID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, },} } }, { InvoiceNavProperty.Person2, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.ContactPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { InvoiceNavProperty.Customer1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Customer, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.CustomerID, OtherPropId = (int)WorldWideImportersE.Sales.CustomerProperty.CustomerID, },} } }, { InvoiceNavProperty.DeliveryMethod, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_DeliveryMethod, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.DeliveryMethodID, OtherPropId = (int)WorldWideImportersE.Application.DeliveryMethodProperty.DeliveryMethodID, },} } }, { InvoiceNavProperty.Order, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Order, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.OrderID, OtherPropId = (int)WorldWideImportersE.Sales.OrderProperty.OrderID, },} } }, { InvoiceNavProperty.Person3, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.PackedByPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { InvoiceNavProperty.Person4, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Application_Person, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.SalespersonPersonID, OtherPropId = (int)WorldWideImportersE.Application.PersonProperty.PersonID, },} } }, { InvoiceNavProperty.StockItemTransactions, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItemTransaction, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)WorldWideImportersE.Sales.InvoiceProperty.InvoiceID, OtherPropId = (int)WorldWideImportersE.Warehouse.StockItemTransactionProperty.InvoiceID, },} } },};
        #endregion
        #region Constructors
        public InvoiceRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_Invoice;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_Sales_Invoices) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<InvoiceProperty>(1){ SortFilter.New(InvoiceProperty.InvoiceID),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice from the database by Primary Key.
        /// </summary>
        /// <param name="invoiceid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice</returns>
        public Invoice ByPK(int invoiceid)
        {
            var where = new QueryFilters<InvoiceProperty>(1){QueryFilter.New(InvoiceProperty.InvoiceID, FilterConditions.Equals, invoiceid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="invoiceid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice</returns>
        public Invoice ByPK(int invoiceid, NavProps<InvoiceNavProperty> navprops)
        {
            var where = new QueryFilters<InvoiceProperty>(1){QueryFilter.New(InvoiceProperty.InvoiceID, FilterConditions.Equals, invoiceid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice from the database by Primary Key.
        /// </summary>
        /// <param name="invoiceid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int invoiceid)
        {
            var where = new QueryFilters<InvoiceProperty>(1){QueryFilter.New(InvoiceProperty.InvoiceID, FilterConditions.Equals, invoiceid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<InvoiceProperty> ComposeKeys(Invoice invoice)
        {
            return new QueryFilters<InvoiceProperty>{ QueryFilter.New(InvoiceProperty.InvoiceID, FilterConditions.Equals, invoice.InvoiceID) };
        }
        protected override QueryFilters<InvoiceProperty> GetChanges(Invoice original, Invoice changed)
        {
            return InvoiceUtils.GetChanges(original, changed);
        }
        protected override void Merge(Invoice source, Invoice target)
        {
            InvoiceUtils.Merge(source, target);
        }
        protected override QueryFilters<InvoiceProperty> ComposeInsertPredicate(Invoice invoice)
        {
            return new QueryFilters<InvoiceProperty>{ QueryFilter.New(InvoiceProperty.InvoiceID, FilterConditions.Equals, invoice.InvoiceID), QueryFilter.New(InvoiceProperty.CustomerID, FilterConditions.Equals, invoice.CustomerID), QueryFilter.New(InvoiceProperty.BillToCustomerID, FilterConditions.Equals, invoice.BillToCustomerID), QueryFilter.New(InvoiceProperty.OrderID, FilterConditions.Equals, invoice.OrderID), QueryFilter.New(InvoiceProperty.DeliveryMethodID, FilterConditions.Equals, invoice.DeliveryMethodID), QueryFilter.New(InvoiceProperty.ContactPersonID, FilterConditions.Equals, invoice.ContactPersonID), QueryFilter.New(InvoiceProperty.AccountsPersonID, FilterConditions.Equals, invoice.AccountsPersonID), QueryFilter.New(InvoiceProperty.SalespersonPersonID, FilterConditions.Equals, invoice.SalespersonPersonID), QueryFilter.New(InvoiceProperty.PackedByPersonID, FilterConditions.Equals, invoice.PackedByPersonID), QueryFilter.New(InvoiceProperty.InvoiceDate, FilterConditions.Equals, invoice.InvoiceDate), QueryFilter.New(InvoiceProperty.CustomerPurchaseOrderNumber, FilterConditions.Equals, invoice.CustomerPurchaseOrderNumber), QueryFilter.New(InvoiceProperty.IsCreditNote, FilterConditions.Equals, invoice.IsCreditNote), QueryFilter.New(InvoiceProperty.CreditNoteReason, FilterConditions.Equals, invoice.CreditNoteReason), QueryFilter.New(InvoiceProperty.Comments, FilterConditions.Equals, invoice.Comments), QueryFilter.New(InvoiceProperty.DeliveryInstructions, FilterConditions.Equals, invoice.DeliveryInstructions), QueryFilter.New(InvoiceProperty.InternalComments, FilterConditions.Equals, invoice.InternalComments), QueryFilter.New(InvoiceProperty.TotalDryItems, FilterConditions.Equals, invoice.TotalDryItems), QueryFilter.New(InvoiceProperty.TotalChillerItems, FilterConditions.Equals, invoice.TotalChillerItems), QueryFilter.New(InvoiceProperty.DeliveryRun, FilterConditions.Equals, invoice.DeliveryRun), QueryFilter.New(InvoiceProperty.RunPosition, FilterConditions.Equals, invoice.RunPosition), QueryFilter.New(InvoiceProperty.ReturnedDeliveryData, FilterConditions.Equals, invoice.ReturnedDeliveryData), QueryFilter.New(InvoiceProperty.LastEditedBy, FilterConditions.Equals, invoice.LastEditedBy) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 25);
        }
        private static Invoice MaterializeSingleEntity(SqlDataReader r)
        {
            return new Invoice
            {
                InvoiceID = r.GetInt32(0),
                CustomerID = r.GetInt32(1),
                BillToCustomerID = r.GetInt32(2),
                OrderID = r.GetValue(3) as int?,
                DeliveryMethodID = r.GetInt32(4),
                ContactPersonID = r.GetInt32(5),
                AccountsPersonID = r.GetInt32(6),
                SalespersonPersonID = r.GetInt32(7),
                PackedByPersonID = r.GetInt32(8),
                InvoiceDate = r.GetDateTime(9),
                CustomerPurchaseOrderNumber = r.GetValue(10) as string,
                IsCreditNote = r.GetBoolean(11),
                CreditNoteReason = r.GetValue(12) as string,
                Comments = r.GetValue(13) as string,
                DeliveryInstructions = r.GetValue(14) as string,
                InternalComments = r.GetValue(15) as string,
                TotalDryItems = r.GetInt32(16),
                TotalChillerItems = r.GetInt32(17),
                DeliveryRun = r.GetValue(18) as string,
                RunPosition = r.GetValue(19) as string,
                ReturnedDeliveryData = r.GetValue(20) as string,
                ConfirmedDeliveryTime = r.GetValue(21) as DateTime?,
                ConfirmedReceivedBy = r.GetValue(22) as string,
                LastEditedBy = r.GetInt32(23),
                LastEditedWhen = r.GetDateTime(24),
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
                var np = (InvoiceNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case InvoiceNavProperty.CustomerTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.InvoiceLines:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.Person:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.Person1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.Customer:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.Person2:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.Customer1:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.DeliveryMethod:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.Order:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.Person3:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.Person4:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.StockItemTransactions:
                        npInfo.NavProps = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (InvoiceNavProperty)p.Value;
                switch(np)
                {
                    case InvoiceNavProperty.CustomerTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.InvoiceLines:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.Person:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.Person1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.Customer:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.Person2:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.Customer1:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.DeliveryMethod:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.Order:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.Person3:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.Person4:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.StockItemTransactions:
                        result.Add(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<Invoice> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Invoice> ComposeDictionaryByPK(List<Invoice> entities, MultiKeyDictionary<int, Invoice> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Invoice>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.InvoiceID, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Invoice> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Invoice>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (InvoiceNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case InvoiceNavProperty.CustomerTransactions:
                    #region CustomerTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.InvoiceID.Value];
                                p.CustomerTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.CustomerTransaction>(p.CustomerTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.InvoiceLines:
                    #region InvoiceLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.InvoiceID];
                                p.InvoiceLines = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.InvoiceLine>(p.InvoiceLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.InvoiceLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.Person:
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
                                if(navByKey.ContainsKey(c.AccountsPersonID))
                                    c.Person = navByKey[c.AccountsPersonID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.Person1:
                    #region Person1
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
                                    c.Person1 = navByKey[c.LastEditedBy];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.Customer:
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
                                if(navByKey.ContainsKey(c.BillToCustomerID))
                                    c.Customer = navByKey[c.BillToCustomerID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.Person2:
                    #region Person2
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>();
                            foreach(var p in list)
                                navByKey.Add(p.PersonID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.ContactPersonID))
                                    c.Person2 = navByKey[c.ContactPersonID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.Customer1:
                    #region Customer1
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
                                    c.Customer1 = navByKey[c.CustomerID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.DeliveryMethod:
                    #region DeliveryMethod
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.DeliveryMethod>();
                            foreach(var p in list)
                                navByKey.Add(p.DeliveryMethodID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.DeliveryMethodID))
                                    c.DeliveryMethod = navByKey[c.DeliveryMethodID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.DeliveryMethodRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.Order:
                    #region Order
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order>();
                            foreach(var p in list)
                                navByKey.Add(p.OrderID, p);
                            foreach(var c in entities)
                            {
                                if(!c.OrderID.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.OrderID.Value))
                                    c.Order = navByKey[c.OrderID.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Sales.OrderRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.Person3:
                    #region Person3
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>();
                            foreach(var p in list)
                                navByKey.Add(p.PersonID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.PackedByPersonID))
                                    c.Person3 = navByKey[c.PackedByPersonID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.Person4:
                    #region Person4
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Data.Entity.WorldWideImporters.Application.Person>();
                            foreach(var p in list)
                                navByKey.Add(p.PersonID, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.SalespersonPersonID))
                                    c.Person4 = navByKey[c.SalespersonPersonID];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Application.PersonRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.StockItemTransactions:
                    #region StockItemTransactions
                    {
                        var list = UnboxEntityList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.InvoiceID.Value];
                                p.StockItemTransactions = AddEntityToList<TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItemTransaction>(p.StockItemTransactions, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse.StockItemTransactionRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
