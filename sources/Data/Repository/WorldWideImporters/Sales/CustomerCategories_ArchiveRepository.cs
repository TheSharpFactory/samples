/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{
    public partial class CustomerCategories_ArchiveRepository
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

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Sales
{

    /// <summary>
    /// This class represents the Repository for: CustomerCategories_Archive.
    /// </summary>
    public partial class CustomerCategories_ArchiveRepository:WritableRepositoryBase<CustomerCategories_Archive, CustomerCategories_ArchiveProperty>, ICustomerCategories_ArchiveRepository
    {
        #region Constructors
        public CustomerCategories_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Sales_CustomerCategories_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<CustomerCategories_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<CustomerCategories_ArchiveProperty> ComposeKeys(CustomerCategories_Archive customercategories_archive)
        {
            return new QueryFilters<CustomerCategories_ArchiveProperty>{ QueryFilter.New(CustomerCategories_ArchiveProperty.CustomerCategoryID, FilterConditions.Equals, customercategories_archive.CustomerCategoryID), QueryFilter.New(CustomerCategories_ArchiveProperty.CustomerCategoryName, FilterConditions.Equals, customercategories_archive.CustomerCategoryName), QueryFilter.New(CustomerCategories_ArchiveProperty.LastEditedBy, FilterConditions.Equals, customercategories_archive.LastEditedBy), QueryFilter.New(CustomerCategories_ArchiveProperty.ValidFrom, FilterConditions.Equals, customercategories_archive.ValidFrom), QueryFilter.New(CustomerCategories_ArchiveProperty.ValidTo, FilterConditions.Equals, customercategories_archive.ValidTo) };
        }
        protected override QueryFilters<CustomerCategories_ArchiveProperty> GetChanges(CustomerCategories_Archive original, CustomerCategories_Archive changed)
        {
            return CustomerCategories_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(CustomerCategories_Archive source, CustomerCategories_Archive target)
        {
            CustomerCategories_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<CustomerCategories_ArchiveProperty> ComposeInsertPredicate(CustomerCategories_Archive customercategories_archive)
        {
            return new QueryFilters<CustomerCategories_ArchiveProperty>{ QueryFilter.New(CustomerCategories_ArchiveProperty.CustomerCategoryID, FilterConditions.Equals, customercategories_archive.CustomerCategoryID), QueryFilter.New(CustomerCategories_ArchiveProperty.CustomerCategoryName, FilterConditions.Equals, customercategories_archive.CustomerCategoryName), QueryFilter.New(CustomerCategories_ArchiveProperty.LastEditedBy, FilterConditions.Equals, customercategories_archive.LastEditedBy), QueryFilter.New(CustomerCategories_ArchiveProperty.ValidFrom, FilterConditions.Equals, customercategories_archive.ValidFrom), QueryFilter.New(CustomerCategories_ArchiveProperty.ValidTo, FilterConditions.Equals, customercategories_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static CustomerCategories_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new CustomerCategories_Archive
            {
                CustomerCategoryID = r.GetInt32(0),
                CustomerCategoryName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        #endregion
    }
}
