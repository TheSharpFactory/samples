/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{
    public static partial class SpecialDealUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Sales
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Sales.SpecialDeal.
    /// </summary>
    public static partial class SpecialDealUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(SpecialDeal one, SpecialDeal two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.SpecialDealID != two.SpecialDealID)
                return true;
            if(one.StockItemID != two.StockItemID)
                return true;
            if(one.CustomerID != two.CustomerID)
                return true;
            if(one.BuyingGroupID != two.BuyingGroupID)
                return true;
            if(one.CustomerCategoryID != two.CustomerCategoryID)
                return true;
            if(one.StockGroupID != two.StockGroupID)
                return true;
            if(string.CompareOrdinal(one.DealDescription, two.DealDescription) != 0)
                return true;
            if(one.StartDate != two.StartDate)
                return true;
            if(one.EndDate != two.EndDate)
                return true;
            if(one.DiscountAmount != two.DiscountAmount)
                return true;
            if(one.DiscountPercentage != two.DiscountPercentage)
                return true;
            if(one.UnitPrice != two.UnitPrice)
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
        public static void Merge(SpecialDeal source, SpecialDeal target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.SpecialDealID = source.SpecialDealID;
            target.StockItemID = source.StockItemID;
            target.CustomerID = source.CustomerID;
            target.BuyingGroupID = source.BuyingGroupID;
            target.CustomerCategoryID = source.CustomerCategoryID;
            target.StockGroupID = source.StockGroupID;
            target.DealDescription = source.DealDescription;
            target.StartDate = source.StartDate;
            target.EndDate = source.EndDate;
            target.DiscountAmount = source.DiscountAmount;
            target.DiscountPercentage = source.DiscountPercentage;
            target.UnitPrice = source.UnitPrice;
            target.LastEditedBy = source.LastEditedBy;
            target.LastEditedWhen = source.LastEditedWhen;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of SpecialDealProperty</returns>
        public static QueryFilters<SpecialDealProperty> GetChanges(SpecialDeal original, SpecialDeal changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<SpecialDealProperty>(14);
            #region Detect Changes
            if(original.SpecialDealID != changed.SpecialDealID)
                changes.Add(QueryFilter.New(SpecialDealProperty.SpecialDealID, FilterConditions.Equals, changed.SpecialDealID));
            if(original.StockItemID != changed.StockItemID)
                changes.Add(QueryFilter.New(SpecialDealProperty.StockItemID, FilterConditions.Equals, changed.StockItemID));
            if(original.CustomerID != changed.CustomerID)
                changes.Add(QueryFilter.New(SpecialDealProperty.CustomerID, FilterConditions.Equals, changed.CustomerID));
            if(original.BuyingGroupID != changed.BuyingGroupID)
                changes.Add(QueryFilter.New(SpecialDealProperty.BuyingGroupID, FilterConditions.Equals, changed.BuyingGroupID));
            if(original.CustomerCategoryID != changed.CustomerCategoryID)
                changes.Add(QueryFilter.New(SpecialDealProperty.CustomerCategoryID, FilterConditions.Equals, changed.CustomerCategoryID));
            if(original.StockGroupID != changed.StockGroupID)
                changes.Add(QueryFilter.New(SpecialDealProperty.StockGroupID, FilterConditions.Equals, changed.StockGroupID));
            if(string.CompareOrdinal(original.DealDescription, changed.DealDescription) != 0)
                changes.Add(QueryFilter.New(SpecialDealProperty.DealDescription, FilterConditions.Equals, changed.DealDescription));
            if(original.StartDate != changed.StartDate)
                changes.Add(QueryFilter.New(SpecialDealProperty.StartDate, FilterConditions.Equals, changed.StartDate));
            if(original.EndDate != changed.EndDate)
                changes.Add(QueryFilter.New(SpecialDealProperty.EndDate, FilterConditions.Equals, changed.EndDate));
            if(original.DiscountAmount != changed.DiscountAmount)
                changes.Add(QueryFilter.New(SpecialDealProperty.DiscountAmount, FilterConditions.Equals, changed.DiscountAmount));
            if(original.DiscountPercentage != changed.DiscountPercentage)
                changes.Add(QueryFilter.New(SpecialDealProperty.DiscountPercentage, FilterConditions.Equals, changed.DiscountPercentage));
            if(original.UnitPrice != changed.UnitPrice)
                changes.Add(QueryFilter.New(SpecialDealProperty.UnitPrice, FilterConditions.Equals, changed.UnitPrice));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(SpecialDealProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.LastEditedWhen != changed.LastEditedWhen)
                changes.Add(QueryFilter.New(SpecialDealProperty.LastEditedWhen, FilterConditions.Equals, changed.LastEditedWhen));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
