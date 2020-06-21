/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{
    public static partial class StockItems_ArchiveUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse.StockItems_Archive.
    /// </summary>
    public static partial class StockItems_ArchiveUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(StockItems_Archive one, StockItems_Archive two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.StockItemID != two.StockItemID)
                return true;
            if(string.CompareOrdinal(one.StockItemName, two.StockItemName) != 0)
                return true;
            if(one.SupplierID != two.SupplierID)
                return true;
            if(one.ColorID != two.ColorID)
                return true;
            if(one.UnitPackageID != two.UnitPackageID)
                return true;
            if(one.OuterPackageID != two.OuterPackageID)
                return true;
            if(string.CompareOrdinal(one.Brand, two.Brand) != 0)
                return true;
            if(string.CompareOrdinal(one.Size, two.Size) != 0)
                return true;
            if(one.LeadTimeDays != two.LeadTimeDays)
                return true;
            if(one.QuantityPerOuter != two.QuantityPerOuter)
                return true;
            if(one.IsChillerStock != two.IsChillerStock)
                return true;
            if(string.CompareOrdinal(one.Barcode, two.Barcode) != 0)
                return true;
            if(one.TaxRate != two.TaxRate)
                return true;
            if(one.UnitPrice != two.UnitPrice)
                return true;
            if(one.RecommendedRetailPrice != two.RecommendedRetailPrice)
                return true;
            if(one.TypicalWeightPerUnit != two.TypicalWeightPerUnit)
                return true;
            if(string.CompareOrdinal(one.MarketingComments, two.MarketingComments) != 0)
                return true;
            if(string.CompareOrdinal(one.InternalComments, two.InternalComments) != 0)
                return true;
            if(!Compare.ByteArrays(one.Photo, two.Photo))
                return true;
            if(string.CompareOrdinal(one.CustomFields, two.CustomFields) != 0)
                return true;
            if(string.CompareOrdinal(one.Tags, two.Tags) != 0)
                return true;
            if(string.CompareOrdinal(one.SearchDetails, two.SearchDetails) != 0)
                return true;
            if(one.LastEditedBy != two.LastEditedBy)
                return true;
            if(one.ValidFrom != two.ValidFrom)
                return true;
            if(one.ValidTo != two.ValidTo)
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
        public static void Merge(StockItems_Archive source, StockItems_Archive target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.StockItemID = source.StockItemID;
            target.StockItemName = source.StockItemName;
            target.SupplierID = source.SupplierID;
            target.ColorID = source.ColorID;
            target.UnitPackageID = source.UnitPackageID;
            target.OuterPackageID = source.OuterPackageID;
            target.Brand = source.Brand;
            target.Size = source.Size;
            target.LeadTimeDays = source.LeadTimeDays;
            target.QuantityPerOuter = source.QuantityPerOuter;
            target.IsChillerStock = source.IsChillerStock;
            target.Barcode = source.Barcode;
            target.TaxRate = source.TaxRate;
            target.UnitPrice = source.UnitPrice;
            target.RecommendedRetailPrice = source.RecommendedRetailPrice;
            target.TypicalWeightPerUnit = source.TypicalWeightPerUnit;
            target.MarketingComments = source.MarketingComments;
            target.InternalComments = source.InternalComments;
            target.Photo = source.Photo;
            target.CustomFields = source.CustomFields;
            target.Tags = source.Tags;
            target.SearchDetails = source.SearchDetails;
            target.LastEditedBy = source.LastEditedBy;
            target.ValidFrom = source.ValidFrom;
            target.ValidTo = source.ValidTo;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of StockItems_ArchiveProperty</returns>
        public static QueryFilters<StockItems_ArchiveProperty> GetChanges(StockItems_Archive original, StockItems_Archive changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<StockItems_ArchiveProperty>(25);
            #region Detect Changes
            if(original.StockItemID != changed.StockItemID)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.StockItemID, FilterConditions.Equals, changed.StockItemID));
            if(string.CompareOrdinal(original.StockItemName, changed.StockItemName) != 0)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.StockItemName, FilterConditions.Equals, changed.StockItemName));
            if(original.SupplierID != changed.SupplierID)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.SupplierID, FilterConditions.Equals, changed.SupplierID));
            if(original.ColorID != changed.ColorID)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.ColorID, FilterConditions.Equals, changed.ColorID));
            if(original.UnitPackageID != changed.UnitPackageID)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.UnitPackageID, FilterConditions.Equals, changed.UnitPackageID));
            if(original.OuterPackageID != changed.OuterPackageID)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.OuterPackageID, FilterConditions.Equals, changed.OuterPackageID));
            if(string.CompareOrdinal(original.Brand, changed.Brand) != 0)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.Brand, FilterConditions.Equals, changed.Brand));
            if(string.CompareOrdinal(original.Size, changed.Size) != 0)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.Size, FilterConditions.Equals, changed.Size));
            if(original.LeadTimeDays != changed.LeadTimeDays)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.LeadTimeDays, FilterConditions.Equals, changed.LeadTimeDays));
            if(original.QuantityPerOuter != changed.QuantityPerOuter)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.QuantityPerOuter, FilterConditions.Equals, changed.QuantityPerOuter));
            if(original.IsChillerStock != changed.IsChillerStock)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.IsChillerStock, FilterConditions.Equals, changed.IsChillerStock));
            if(string.CompareOrdinal(original.Barcode, changed.Barcode) != 0)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.Barcode, FilterConditions.Equals, changed.Barcode));
            if(original.TaxRate != changed.TaxRate)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.TaxRate, FilterConditions.Equals, changed.TaxRate));
            if(original.UnitPrice != changed.UnitPrice)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.UnitPrice, FilterConditions.Equals, changed.UnitPrice));
            if(original.RecommendedRetailPrice != changed.RecommendedRetailPrice)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.RecommendedRetailPrice, FilterConditions.Equals, changed.RecommendedRetailPrice));
            if(original.TypicalWeightPerUnit != changed.TypicalWeightPerUnit)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.TypicalWeightPerUnit, FilterConditions.Equals, changed.TypicalWeightPerUnit));
            if(string.CompareOrdinal(original.MarketingComments, changed.MarketingComments) != 0)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.MarketingComments, FilterConditions.Equals, changed.MarketingComments));
            if(string.CompareOrdinal(original.InternalComments, changed.InternalComments) != 0)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.InternalComments, FilterConditions.Equals, changed.InternalComments));
            if(!Compare.ByteArrays(original.Photo, changed.Photo))
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.Photo, FilterConditions.Equals, changed.Photo));
            if(string.CompareOrdinal(original.CustomFields, changed.CustomFields) != 0)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.CustomFields, FilterConditions.Equals, changed.CustomFields));
            if(string.CompareOrdinal(original.Tags, changed.Tags) != 0)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.Tags, FilterConditions.Equals, changed.Tags));
            if(string.CompareOrdinal(original.SearchDetails, changed.SearchDetails) != 0)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.SearchDetails, FilterConditions.Equals, changed.SearchDetails));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(StockItems_ArchiveProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
