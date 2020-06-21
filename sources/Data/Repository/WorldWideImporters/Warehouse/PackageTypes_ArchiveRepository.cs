/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class PackageTypes_ArchiveRepository
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
    /// This class represents the Repository for: PackageTypes_Archive.
    /// </summary>
    public partial class PackageTypes_ArchiveRepository:WritableRepositoryBase<PackageTypes_Archive, PackageTypes_ArchiveProperty>, IPackageTypes_ArchiveRepository
    {
        #region Constructors
        public PackageTypes_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_PackageTypes_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<PackageTypes_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<PackageTypes_ArchiveProperty> ComposeKeys(PackageTypes_Archive packagetypes_archive)
        {
            return new QueryFilters<PackageTypes_ArchiveProperty>{ QueryFilter.New(PackageTypes_ArchiveProperty.PackageTypeID, FilterConditions.Equals, packagetypes_archive.PackageTypeID), QueryFilter.New(PackageTypes_ArchiveProperty.PackageTypeName, FilterConditions.Equals, packagetypes_archive.PackageTypeName), QueryFilter.New(PackageTypes_ArchiveProperty.LastEditedBy, FilterConditions.Equals, packagetypes_archive.LastEditedBy), QueryFilter.New(PackageTypes_ArchiveProperty.ValidFrom, FilterConditions.Equals, packagetypes_archive.ValidFrom), QueryFilter.New(PackageTypes_ArchiveProperty.ValidTo, FilterConditions.Equals, packagetypes_archive.ValidTo) };
        }
        protected override QueryFilters<PackageTypes_ArchiveProperty> GetChanges(PackageTypes_Archive original, PackageTypes_Archive changed)
        {
            return PackageTypes_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(PackageTypes_Archive source, PackageTypes_Archive target)
        {
            PackageTypes_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<PackageTypes_ArchiveProperty> ComposeInsertPredicate(PackageTypes_Archive packagetypes_archive)
        {
            return new QueryFilters<PackageTypes_ArchiveProperty>{ QueryFilter.New(PackageTypes_ArchiveProperty.PackageTypeID, FilterConditions.Equals, packagetypes_archive.PackageTypeID), QueryFilter.New(PackageTypes_ArchiveProperty.PackageTypeName, FilterConditions.Equals, packagetypes_archive.PackageTypeName), QueryFilter.New(PackageTypes_ArchiveProperty.LastEditedBy, FilterConditions.Equals, packagetypes_archive.LastEditedBy), QueryFilter.New(PackageTypes_ArchiveProperty.ValidFrom, FilterConditions.Equals, packagetypes_archive.ValidFrom), QueryFilter.New(PackageTypes_ArchiveProperty.ValidTo, FilterConditions.Equals, packagetypes_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static PackageTypes_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new PackageTypes_Archive
            {
                PackageTypeID = r.GetInt32(0),
                PackageTypeName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        #endregion
    }
}
