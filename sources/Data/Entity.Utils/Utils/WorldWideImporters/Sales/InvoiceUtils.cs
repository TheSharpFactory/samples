/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{
    public static partial class InvoiceUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Invoice.
    /// </summary>
    public static partial class InvoiceUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Invoice one, Invoice two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.InvoiceID != two.InvoiceID)
                return true;
            if(one.CustomerID != two.CustomerID)
                return true;
            if(one.BillToCustomerID != two.BillToCustomerID)
                return true;
            if(one.OrderID != two.OrderID)
                return true;
            if(one.DeliveryMethodID != two.DeliveryMethodID)
                return true;
            if(one.ContactPersonID != two.ContactPersonID)
                return true;
            if(one.AccountsPersonID != two.AccountsPersonID)
                return true;
            if(one.SalespersonPersonID != two.SalespersonPersonID)
                return true;
            if(one.PackedByPersonID != two.PackedByPersonID)
                return true;
            if(one.InvoiceDate != two.InvoiceDate)
                return true;
            if(string.CompareOrdinal(one.CustomerPurchaseOrderNumber, two.CustomerPurchaseOrderNumber) != 0)
                return true;
            if(one.IsCreditNote != two.IsCreditNote)
                return true;
            if(string.CompareOrdinal(one.CreditNoteReason, two.CreditNoteReason) != 0)
                return true;
            if(string.CompareOrdinal(one.Comments, two.Comments) != 0)
                return true;
            if(string.CompareOrdinal(one.DeliveryInstructions, two.DeliveryInstructions) != 0)
                return true;
            if(string.CompareOrdinal(one.InternalComments, two.InternalComments) != 0)
                return true;
            if(one.TotalDryItems != two.TotalDryItems)
                return true;
            if(one.TotalChillerItems != two.TotalChillerItems)
                return true;
            if(string.CompareOrdinal(one.DeliveryRun, two.DeliveryRun) != 0)
                return true;
            if(string.CompareOrdinal(one.RunPosition, two.RunPosition) != 0)
                return true;
            if(string.CompareOrdinal(one.ReturnedDeliveryData, two.ReturnedDeliveryData) != 0)
                return true;
            if(one.ConfirmedDeliveryTime != two.ConfirmedDeliveryTime)
                return true;
            if(string.CompareOrdinal(one.ConfirmedReceivedBy, two.ConfirmedReceivedBy) != 0)
                return true;
            if(one.LastEditedBy != two.LastEditedBy)
                return true;
            if(one.LastEditedWhen != two.LastEditedWhen)
                return true;
            #endregion
            return false;
        }
        /// <summary>
        /// Merge all values from one Entity into another one.
        /// </summary>
        /// <param name="source">Source Entity. Will be copied to the target.</param>
        /// <param name="target">Target Entity. Will receive the values from the source.</param>
        /// <returns>void.</returns>
        public static void Merge(Invoice source, Invoice target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.InvoiceID = source.InvoiceID;
            target.CustomerID = source.CustomerID;
            target.BillToCustomerID = source.BillToCustomerID;
            target.OrderID = source.OrderID;
            target.DeliveryMethodID = source.DeliveryMethodID;
            target.ContactPersonID = source.ContactPersonID;
            target.AccountsPersonID = source.AccountsPersonID;
            target.SalespersonPersonID = source.SalespersonPersonID;
            target.PackedByPersonID = source.PackedByPersonID;
            target.InvoiceDate = source.InvoiceDate;
            target.CustomerPurchaseOrderNumber = source.CustomerPurchaseOrderNumber;
            target.IsCreditNote = source.IsCreditNote;
            target.CreditNoteReason = source.CreditNoteReason;
            target.Comments = source.Comments;
            target.DeliveryInstructions = source.DeliveryInstructions;
            target.InternalComments = source.InternalComments;
            target.TotalDryItems = source.TotalDryItems;
            target.TotalChillerItems = source.TotalChillerItems;
            target.DeliveryRun = source.DeliveryRun;
            target.RunPosition = source.RunPosition;
            target.ReturnedDeliveryData = source.ReturnedDeliveryData;
            target.ConfirmedDeliveryTime = source.ConfirmedDeliveryTime;
            target.ConfirmedReceivedBy = source.ConfirmedReceivedBy;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of InvoiceProperty</returns>
        public static QueryFilters<InvoiceProperty> GetChanges(Invoice original, Invoice changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<InvoiceProperty>(25);
            #region Detect Changes
            if(original.InvoiceID != changed.InvoiceID)
                changes.Add(QueryFilter.New(InvoiceProperty.InvoiceID, FilterConditions.Equals, changed.InvoiceID));
            if(original.CustomerID != changed.CustomerID)
                changes.Add(QueryFilter.New(InvoiceProperty.CustomerID, FilterConditions.Equals, changed.CustomerID));
            if(original.BillToCustomerID != changed.BillToCustomerID)
                changes.Add(QueryFilter.New(InvoiceProperty.BillToCustomerID, FilterConditions.Equals, changed.BillToCustomerID));
            if(original.OrderID != changed.OrderID)
                changes.Add(QueryFilter.New(InvoiceProperty.OrderID, FilterConditions.Equals, changed.OrderID));
            if(original.DeliveryMethodID != changed.DeliveryMethodID)
                changes.Add(QueryFilter.New(InvoiceProperty.DeliveryMethodID, FilterConditions.Equals, changed.DeliveryMethodID));
            if(original.ContactPersonID != changed.ContactPersonID)
                changes.Add(QueryFilter.New(InvoiceProperty.ContactPersonID, FilterConditions.Equals, changed.ContactPersonID));
            if(original.AccountsPersonID != changed.AccountsPersonID)
                changes.Add(QueryFilter.New(InvoiceProperty.AccountsPersonID, FilterConditions.Equals, changed.AccountsPersonID));
            if(original.SalespersonPersonID != changed.SalespersonPersonID)
                changes.Add(QueryFilter.New(InvoiceProperty.SalespersonPersonID, FilterConditions.Equals, changed.SalespersonPersonID));
            if(original.PackedByPersonID != changed.PackedByPersonID)
                changes.Add(QueryFilter.New(InvoiceProperty.PackedByPersonID, FilterConditions.Equals, changed.PackedByPersonID));
            if(original.InvoiceDate != changed.InvoiceDate)
                changes.Add(QueryFilter.New(InvoiceProperty.InvoiceDate, FilterConditions.Equals, changed.InvoiceDate));
            if(string.CompareOrdinal(original.CustomerPurchaseOrderNumber, changed.CustomerPurchaseOrderNumber) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.CustomerPurchaseOrderNumber, FilterConditions.Equals, changed.CustomerPurchaseOrderNumber));
            if(original.IsCreditNote != changed.IsCreditNote)
                changes.Add(QueryFilter.New(InvoiceProperty.IsCreditNote, FilterConditions.Equals, changed.IsCreditNote));
            if(string.CompareOrdinal(original.CreditNoteReason, changed.CreditNoteReason) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.CreditNoteReason, FilterConditions.Equals, changed.CreditNoteReason));
            if(string.CompareOrdinal(original.Comments, changed.Comments) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.Comments, FilterConditions.Equals, changed.Comments));
            if(string.CompareOrdinal(original.DeliveryInstructions, changed.DeliveryInstructions) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.DeliveryInstructions, FilterConditions.Equals, changed.DeliveryInstructions));
            if(string.CompareOrdinal(original.InternalComments, changed.InternalComments) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.InternalComments, FilterConditions.Equals, changed.InternalComments));
            if(original.TotalDryItems != changed.TotalDryItems)
                changes.Add(QueryFilter.New(InvoiceProperty.TotalDryItems, FilterConditions.Equals, changed.TotalDryItems));
            if(original.TotalChillerItems != changed.TotalChillerItems)
                changes.Add(QueryFilter.New(InvoiceProperty.TotalChillerItems, FilterConditions.Equals, changed.TotalChillerItems));
            if(string.CompareOrdinal(original.DeliveryRun, changed.DeliveryRun) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.DeliveryRun, FilterConditions.Equals, changed.DeliveryRun));
            if(string.CompareOrdinal(original.RunPosition, changed.RunPosition) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.RunPosition, FilterConditions.Equals, changed.RunPosition));
            if(string.CompareOrdinal(original.ReturnedDeliveryData, changed.ReturnedDeliveryData) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.ReturnedDeliveryData, FilterConditions.Equals, changed.ReturnedDeliveryData));
            if(original.ConfirmedDeliveryTime != changed.ConfirmedDeliveryTime)
                changes.Add(QueryFilter.New(InvoiceProperty.ConfirmedDeliveryTime, FilterConditions.Equals, changed.ConfirmedDeliveryTime));
            if(string.CompareOrdinal(original.ConfirmedReceivedBy, changed.ConfirmedReceivedBy) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.ConfirmedReceivedBy, FilterConditions.Equals, changed.ConfirmedReceivedBy));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(InvoiceProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(InvoiceProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
