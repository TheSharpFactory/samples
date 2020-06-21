/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{
    public partial class SupplierCategories_ArchiveRepository
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

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class represents the Repository for: SupplierCategories_Archive.
    /// </summary>
    public partial class SupplierCategories_ArchiveRepository:WritableRepositoryBase<SupplierCategories_Archive, SupplierCategories_ArchiveProperty>, ISupplierCategories_ArchiveRepository
    {
        #region Constructors
        public SupplierCategories_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Purchasing_SupplierCategories_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<SupplierCategories_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<SupplierCategories_ArchiveProperty> ComposeKeys(SupplierCategories_Archive suppliercategories_archive)
        {
            return new QueryFilters<SupplierCategories_ArchiveProperty>{ QueryFilter.New(SupplierCategories_ArchiveProperty.SupplierCategoryID, FilterConditions.Equals, suppliercategories_archive.SupplierCategoryID), QueryFilter.New(SupplierCategories_ArchiveProperty.SupplierCategoryName, FilterConditions.Equals, suppliercategories_archive.SupplierCategoryName), QueryFilter.New(SupplierCategories_ArchiveProperty.LastEditedBy, FilterConditions.Equals, suppliercategories_archive.LastEditedBy), QueryFilter.New(SupplierCategories_ArchiveProperty.ValidFrom, FilterConditions.Equals, suppliercategories_archive.ValidFrom), QueryFilter.New(SupplierCategories_ArchiveProperty.ValidTo, FilterConditions.Equals, suppliercategories_archive.ValidTo) };
        }
        protected override QueryFilters<SupplierCategories_ArchiveProperty> GetChanges(SupplierCategories_Archive original, SupplierCategories_Archive changed)
        {
            return SupplierCategories_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(SupplierCategories_Archive source, SupplierCategories_Archive target)
        {
            SupplierCategories_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<SupplierCategories_ArchiveProperty> ComposeInsertPredicate(SupplierCategories_Archive suppliercategories_archive)
        {
            return new QueryFilters<SupplierCategories_ArchiveProperty>{ QueryFilter.New(SupplierCategories_ArchiveProperty.SupplierCategoryID, FilterConditions.Equals, suppliercategories_archive.SupplierCategoryID), QueryFilter.New(SupplierCategories_ArchiveProperty.SupplierCategoryName, FilterConditions.Equals, suppliercategories_archive.SupplierCategoryName), QueryFilter.New(SupplierCategories_ArchiveProperty.LastEditedBy, FilterConditions.Equals, suppliercategories_archive.LastEditedBy), QueryFilter.New(SupplierCategories_ArchiveProperty.ValidFrom, FilterConditions.Equals, suppliercategories_archive.ValidFrom), QueryFilter.New(SupplierCategories_ArchiveProperty.ValidTo, FilterConditions.Equals, suppliercategories_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static SupplierCategories_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new SupplierCategories_Archive
            {
                SupplierCategoryID = r.GetInt32(0),
                SupplierCategoryName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        #endregion
    }
}
