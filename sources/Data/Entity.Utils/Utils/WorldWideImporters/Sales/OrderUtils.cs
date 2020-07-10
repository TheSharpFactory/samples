/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{
    public static partial class OrderUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Order.
    /// </summary>
    public static partial class OrderUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Order one, Order two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.OrderID != two.OrderID)
                return true;
            if(one.CustomerID != two.CustomerID)
                return true;
            if(one.SalespersonPersonID != two.SalespersonPersonID)
                return true;
            if(one.PickedByPersonID != two.PickedByPersonID)
                return true;
            if(one.ContactPersonID != two.ContactPersonID)
                return true;
            if(one.BackorderOrderID != two.BackorderOrderID)
                return true;
            if(one.OrderDate != two.OrderDate)
                return true;
            if(one.ExpectedDeliveryDate != two.ExpectedDeliveryDate)
                return true;
            if(string.CompareOrdinal(one.CustomerPurchaseOrderNumber, two.CustomerPurchaseOrderNumber) != 0)
                return true;
            if(one.IsUndersupplyBackordered != two.IsUndersupplyBackordered)
                return true;
            if(string.CompareOrdinal(one.Comments, two.Comments) != 0)
                return true;
            if(string.CompareOrdinal(one.DeliveryInstructions, two.DeliveryInstructions) != 0)
                return true;
            if(string.CompareOrdinal(one.InternalComments, two.InternalComments) != 0)
                return true;
            if(one.PickingCompletedWhen != two.PickingCompletedWhen)
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
        public static void Merge(Order source, Order target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.OrderID = source.OrderID;
            target.CustomerID = source.CustomerID;
            target.SalespersonPersonID = source.SalespersonPersonID;
            target.PickedByPersonID = source.PickedByPersonID;
            target.ContactPersonID = source.ContactPersonID;
            target.BackorderOrderID = source.BackorderOrderID;
            target.OrderDate = source.OrderDate;
            target.ExpectedDeliveryDate = source.ExpectedDeliveryDate;
            target.CustomerPurchaseOrderNumber = source.CustomerPurchaseOrderNumber;
            target.IsUndersupplyBackordered = source.IsUndersupplyBackordered;
            target.Comments = source.Comments;
            target.DeliveryInstructions = source.DeliveryInstructions;
            target.InternalComments = source.InternalComments;
            target.PickingCompletedWhen = source.PickingCompletedWhen;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of OrderProperty</returns>
        public static QueryFilters<OrderProperty> GetChanges(Order original, Order changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<OrderProperty>(16);
            #region Detect Changes
            if(original.OrderID != changed.OrderID)
                changes.Add(QueryFilter.New(OrderProperty.OrderID, FilterConditions.Equals, changed.OrderID));
            if(original.CustomerID != changed.CustomerID)
                changes.Add(QueryFilter.New(OrderProperty.CustomerID, FilterConditions.Equals, changed.CustomerID));
            if(original.SalespersonPersonID != changed.SalespersonPersonID)
                changes.Add(QueryFilter.New(OrderProperty.SalespersonPersonID, FilterConditions.Equals, changed.SalespersonPersonID));
            if(original.PickedByPersonID != changed.PickedByPersonID)
                changes.Add(QueryFilter.New(OrderProperty.PickedByPersonID, FilterConditions.Equals, changed.PickedByPersonID));
            if(original.ContactPersonID != changed.ContactPersonID)
                changes.Add(QueryFilter.New(OrderProperty.ContactPersonID, FilterConditions.Equals, changed.ContactPersonID));
            if(original.BackorderOrderID != changed.BackorderOrderID)
                changes.Add(QueryFilter.New(OrderProperty.BackorderOrderID, FilterConditions.Equals, changed.BackorderOrderID));
            if(original.OrderDate != changed.OrderDate)
                changes.Add(QueryFilter.New(OrderProperty.OrderDate, FilterConditions.Equals, changed.OrderDate));
            if(original.ExpectedDeliveryDate != changed.ExpectedDeliveryDate)
                changes.Add(QueryFilter.New(OrderProperty.ExpectedDeliveryDate, FilterConditions.Equals, changed.ExpectedDeliveryDate));
            if(string.CompareOrdinal(original.CustomerPurchaseOrderNumber, changed.CustomerPurchaseOrderNumber) != 0)
                changes.Add(QueryFilter.New(OrderProperty.CustomerPurchaseOrderNumber, FilterConditions.Equals, changed.CustomerPurchaseOrderNumber));
            if(original.IsUndersupplyBackordered != changed.IsUndersupplyBackordered)
                changes.Add(QueryFilter.New(OrderProperty.IsUndersupplyBackordered, FilterConditions.Equals, changed.IsUndersupplyBackordered));
            if(string.CompareOrdinal(original.Comments, changed.Comments) != 0)
                changes.Add(QueryFilter.New(OrderProperty.Comments, FilterConditions.Equals, changed.Comments));
            if(string.CompareOrdinal(original.DeliveryInstructions, changed.DeliveryInstructions) != 0)
                changes.Add(QueryFilter.New(OrderProperty.DeliveryInstructions, FilterConditions.Equals, changed.DeliveryInstructions));
            if(string.CompareOrdinal(original.InternalComments, changed.InternalComments) != 0)
                changes.Add(QueryFilter.New(OrderProperty.InternalComments, FilterConditions.Equals, changed.InternalComments));
            if(original.PickingCompletedWhen != changed.PickingCompletedWhen)
                changes.Add(QueryFilter.New(OrderProperty.PickingCompletedWhen, FilterConditions.Equals, changed.PickingCompletedWhen));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(OrderProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(OrderProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
