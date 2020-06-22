/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{
    public static partial class PurchaseOrderUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Purchasing.PurchaseOrder.
    /// </summary>
    public static partial class PurchaseOrderUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(PurchaseOrder one, PurchaseOrder two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.PurchaseOrderID != two.PurchaseOrderID)
                return true;
            if(one.SupplierID != two.SupplierID)
                return true;
            if(one.OrderDate != two.OrderDate)
                return true;
            if(one.DeliveryMethodID != two.DeliveryMethodID)
                return true;
            if(one.ContactPersonID != two.ContactPersonID)
                return true;
            if(one.ExpectedDeliveryDate != two.ExpectedDeliveryDate)
                return true;
            if(string.CompareOrdinal(one.SupplierReference, two.SupplierReference) != 0)
                return true;
            if(one.IsOrderFinalized != two.IsOrderFinalized)
                return true;
            if(string.CompareOrdinal(one.Comments, two.Comments) != 0)
                return true;
            if(string.CompareOrdinal(one.InternalComments, two.InternalComments) != 0)
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
        public static void Merge(PurchaseOrder source, PurchaseOrder target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.PurchaseOrderID = source.PurchaseOrderID;
            target.SupplierID = source.SupplierID;
            target.OrderDate = source.OrderDate;
            target.DeliveryMethodID = source.DeliveryMethodID;
            target.ContactPersonID = source.ContactPersonID;
            target.ExpectedDeliveryDate = source.ExpectedDeliveryDate;
            target.SupplierReference = source.SupplierReference;
            target.IsOrderFinalized = source.IsOrderFinalized;
            target.Comments = source.Comments;
            target.InternalComments = source.InternalComments;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of PurchaseOrderProperty</returns>
        public static QueryFilters<PurchaseOrderProperty> GetChanges(PurchaseOrder original, PurchaseOrder changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<PurchaseOrderProperty>(12);
            #region Detect Changes
            if(original.PurchaseOrderID != changed.PurchaseOrderID)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.PurchaseOrderID, FilterConditions.Equals, changed.PurchaseOrderID));
            if(original.SupplierID != changed.SupplierID)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.SupplierID, FilterConditions.Equals, changed.SupplierID));
            if(original.OrderDate != changed.OrderDate)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.OrderDate, FilterConditions.Equals, changed.OrderDate));
            if(original.DeliveryMethodID != changed.DeliveryMethodID)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.DeliveryMethodID, FilterConditions.Equals, changed.DeliveryMethodID));
            if(original.ContactPersonID != changed.ContactPersonID)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.ContactPersonID, FilterConditions.Equals, changed.ContactPersonID));
            if(original.ExpectedDeliveryDate != changed.ExpectedDeliveryDate)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.ExpectedDeliveryDate, FilterConditions.Equals, changed.ExpectedDeliveryDate));
            if(string.CompareOrdinal(original.SupplierReference, changed.SupplierReference) != 0)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.SupplierReference, FilterConditions.Equals, changed.SupplierReference));
            if(original.IsOrderFinalized != changed.IsOrderFinalized)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.IsOrderFinalized, FilterConditions.Equals, changed.IsOrderFinalized));
            if(string.CompareOrdinal(original.Comments, changed.Comments) != 0)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.Comments, FilterConditions.Equals, changed.Comments));
            if(string.CompareOrdinal(original.InternalComments, changed.InternalComments) != 0)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.InternalComments, FilterConditions.Equals, changed.InternalComments));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(PurchaseOrderProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
