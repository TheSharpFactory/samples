/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class StockItems_ArchiveRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Warehouse;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class represents the Repository for: StockItems_Archive.
    /// </summary>
    public partial class StockItems_ArchiveRepository:WritableRepositoryBase<StockItems_Archive, StockItems_ArchiveProperty>, IStockItems_ArchiveRepository
    {
        #region Constructors
        public StockItems_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_StockItems_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<StockItems_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<StockItems_ArchiveProperty> ComposeKeys(StockItems_Archive stockitems_archive)
        {
            return new QueryFilters<StockItems_ArchiveProperty>{ QueryFilter.New(StockItems_ArchiveProperty.StockItemID, FilterConditions.Equals, stockitems_archive.StockItemID), QueryFilter.New(StockItems_ArchiveProperty.StockItemName, FilterConditions.Equals, stockitems_archive.StockItemName), QueryFilter.New(StockItems_ArchiveProperty.SupplierID, FilterConditions.Equals, stockitems_archive.SupplierID), QueryFilter.New(StockItems_ArchiveProperty.ColorID, FilterConditions.Equals, stockitems_archive.ColorID), QueryFilter.New(StockItems_ArchiveProperty.UnitPackageID, FilterConditions.Equals, stockitems_archive.UnitPackageID), QueryFilter.New(StockItems_ArchiveProperty.OuterPackageID, FilterConditions.Equals, stockitems_archive.OuterPackageID), QueryFilter.New(StockItems_ArchiveProperty.Brand, FilterConditions.Equals, stockitems_archive.Brand), QueryFilter.New(StockItems_ArchiveProperty.Size, FilterConditions.Equals, stockitems_archive.Size), QueryFilter.New(StockItems_ArchiveProperty.LeadTimeDays, FilterConditions.Equals, stockitems_archive.LeadTimeDays), QueryFilter.New(StockItems_ArchiveProperty.QuantityPerOuter, FilterConditions.Equals, stockitems_archive.QuantityPerOuter), QueryFilter.New(StockItems_ArchiveProperty.IsChillerStock, FilterConditions.Equals, stockitems_archive.IsChillerStock), QueryFilter.New(StockItems_ArchiveProperty.Barcode, FilterConditions.Equals, stockitems_archive.Barcode), QueryFilter.New(StockItems_ArchiveProperty.TaxRate, FilterConditions.Equals, stockitems_archive.TaxRate), QueryFilter.New(StockItems_ArchiveProperty.UnitPrice, FilterConditions.Equals, stockitems_archive.UnitPrice), QueryFilter.New(StockItems_ArchiveProperty.RecommendedRetailPrice, FilterConditions.Equals, stockitems_archive.RecommendedRetailPrice), QueryFilter.New(StockItems_ArchiveProperty.TypicalWeightPerUnit, FilterConditions.Equals, stockitems_archive.TypicalWeightPerUnit), QueryFilter.New(StockItems_ArchiveProperty.MarketingComments, FilterConditions.Equals, stockitems_archive.MarketingComments), QueryFilter.New(StockItems_ArchiveProperty.InternalComments, FilterConditions.Equals, stockitems_archive.InternalComments), QueryFilter.New(StockItems_ArchiveProperty.Photo, FilterConditions.Equals, stockitems_archive.Photo), QueryFilter.New(StockItems_ArchiveProperty.CustomFields, FilterConditions.Equals, stockitems_archive.CustomFields), QueryFilter.New(StockItems_ArchiveProperty.Tags, FilterConditions.Equals, stockitems_archive.Tags), QueryFilter.New(StockItems_ArchiveProperty.SearchDetails, FilterConditions.Equals, stockitems_archive.SearchDetails), QueryFilter.New(StockItems_ArchiveProperty.LastEditedBy, FilterConditions.Equals, stockitems_archive.LastEditedBy), QueryFilter.New(StockItems_ArchiveProperty.ValidFrom, FilterConditions.Equals, stockitems_archive.ValidFrom), QueryFilter.New(StockItems_ArchiveProperty.ValidTo, FilterConditions.Equals, stockitems_archive.ValidTo) };
        }
        protected override QueryFilters<StockItems_ArchiveProperty> GetChanges(StockItems_Archive original, StockItems_Archive changed)
        {
            return StockItems_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(StockItems_Archive source, StockItems_Archive target)
        {
            StockItems_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<StockItems_ArchiveProperty> ComposeInsertPredicate(StockItems_Archive stockitems_archive)
        {
            return new QueryFilters<StockItems_ArchiveProperty>{ QueryFilter.New(StockItems_ArchiveProperty.StockItemID, FilterConditions.Equals, stockitems_archive.StockItemID), QueryFilter.New(StockItems_ArchiveProperty.StockItemName, FilterConditions.Equals, stockitems_archive.StockItemName), QueryFilter.New(StockItems_ArchiveProperty.SupplierID, FilterConditions.Equals, stockitems_archive.SupplierID), QueryFilter.New(StockItems_ArchiveProperty.ColorID, FilterConditions.Equals, stockitems_archive.ColorID), QueryFilter.New(StockItems_ArchiveProperty.UnitPackageID, FilterConditions.Equals, stockitems_archive.UnitPackageID), QueryFilter.New(StockItems_ArchiveProperty.OuterPackageID, FilterConditions.Equals, stockitems_archive.OuterPackageID), QueryFilter.New(StockItems_ArchiveProperty.Brand, FilterConditions.Equals, stockitems_archive.Brand), QueryFilter.New(StockItems_ArchiveProperty.Size, FilterConditions.Equals, stockitems_archive.Size), QueryFilter.New(StockItems_ArchiveProperty.LeadTimeDays, FilterConditions.Equals, stockitems_archive.LeadTimeDays), QueryFilter.New(StockItems_ArchiveProperty.QuantityPerOuter, FilterConditions.Equals, stockitems_archive.QuantityPerOuter), QueryFilter.New(StockItems_ArchiveProperty.IsChillerStock, FilterConditions.Equals, stockitems_archive.IsChillerStock), QueryFilter.New(StockItems_ArchiveProperty.Barcode, FilterConditions.Equals, stockitems_archive.Barcode), QueryFilter.New(StockItems_ArchiveProperty.TaxRate, FilterConditions.Equals, stockitems_archive.TaxRate), QueryFilter.New(StockItems_ArchiveProperty.UnitPrice, FilterConditions.Equals, stockitems_archive.UnitPrice), QueryFilter.New(StockItems_ArchiveProperty.RecommendedRetailPrice, FilterConditions.Equals, stockitems_archive.RecommendedRetailPrice), QueryFilter.New(StockItems_ArchiveProperty.TypicalWeightPerUnit, FilterConditions.Equals, stockitems_archive.TypicalWeightPerUnit), QueryFilter.New(StockItems_ArchiveProperty.MarketingComments, FilterConditions.Equals, stockitems_archive.MarketingComments), QueryFilter.New(StockItems_ArchiveProperty.InternalComments, FilterConditions.Equals, stockitems_archive.InternalComments), QueryFilter.New(StockItems_ArchiveProperty.Photo, FilterConditions.Equals, stockitems_archive.Photo), QueryFilter.New(StockItems_ArchiveProperty.CustomFields, FilterConditions.Equals, stockitems_archive.CustomFields), QueryFilter.New(StockItems_ArchiveProperty.Tags, FilterConditions.Equals, stockitems_archive.Tags), QueryFilter.New(StockItems_ArchiveProperty.SearchDetails, FilterConditions.Equals, stockitems_archive.SearchDetails), QueryFilter.New(StockItems_ArchiveProperty.LastEditedBy, FilterConditions.Equals, stockitems_archive.LastEditedBy), QueryFilter.New(StockItems_ArchiveProperty.ValidFrom, FilterConditions.Equals, stockitems_archive.ValidFrom), QueryFilter.New(StockItems_ArchiveProperty.ValidTo, FilterConditions.Equals, stockitems_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 25);
        }
        private static StockItems_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new StockItems_Archive
            {
                StockItemID = r.GetInt32(0),
                StockItemName = r.GetString(1),
                SupplierID = r.GetInt32(2),
                ColorID = r.GetValue(3) as int?,
                UnitPackageID = r.GetInt32(4),
                OuterPackageID = r.GetInt32(5),
                Brand = r.GetValue(6) as string,
                Size = r.GetValue(7) as string,
                LeadTimeDays = r.GetInt32(8),
                QuantityPerOuter = r.GetInt32(9),
                IsChillerStock = r.GetBoolean(10),
                Barcode = r.GetValue(11) as string,
                TaxRate = r.GetDecimal(12),
                UnitPrice = r.GetDecimal(13),
                RecommendedRetailPrice = r.GetValue(14) as decimal?,
                TypicalWeightPerUnit = r.GetDecimal(15),
                MarketingComments = r.GetValue(16) as string,
                InternalComments = r.GetValue(17) as string,
                Photo = r.GetValue(18) as byte[],
                CustomFields = r.GetValue(19) as string,
                Tags = r.GetValue(20) as string,
                SearchDetails = r.GetString(21),
                LastEditedBy = r.GetInt32(22),
                ValidFrom = r.GetDateTime(23),
                ValidTo = r.GetDateTime(24),
            };
        }
        #endregion
    }
}
