/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse
{
    public partial class Colors_ArchiveRepository
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
    /// This class represents the Repository for: Colors_Archive.
    /// </summary>
    public partial class Colors_ArchiveRepository:WritableRepositoryBase<Colors_Archive, Colors_ArchiveProperty>, IColors_ArchiveRepository
    {
        #region Constructors
        public Colors_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Warehouse_Colors_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<Colors_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<Colors_ArchiveProperty> ComposeKeys(Colors_Archive colors_archive)
        {
            return new QueryFilters<Colors_ArchiveProperty>{ QueryFilter.New(Colors_ArchiveProperty.ColorID, FilterConditions.Equals, colors_archive.ColorID), QueryFilter.New(Colors_ArchiveProperty.ColorName, FilterConditions.Equals, colors_archive.ColorName), QueryFilter.New(Colors_ArchiveProperty.LastEditedBy, FilterConditions.Equals, colors_archive.LastEditedBy), QueryFilter.New(Colors_ArchiveProperty.ValidFrom, FilterConditions.Equals, colors_archive.ValidFrom), QueryFilter.New(Colors_ArchiveProperty.ValidTo, FilterConditions.Equals, colors_archive.ValidTo) };
        }
        protected override QueryFilters<Colors_ArchiveProperty> GetChanges(Colors_Archive original, Colors_Archive changed)
        {
            return Colors_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(Colors_Archive source, Colors_Archive target)
        {
            Colors_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<Colors_ArchiveProperty> ComposeInsertPredicate(Colors_Archive colors_archive)
        {
            return new QueryFilters<Colors_ArchiveProperty>{ QueryFilter.New(Colors_ArchiveProperty.ColorID, FilterConditions.Equals, colors_archive.ColorID), QueryFilter.New(Colors_ArchiveProperty.ColorName, FilterConditions.Equals, colors_archive.ColorName), QueryFilter.New(Colors_ArchiveProperty.LastEditedBy, FilterConditions.Equals, colors_archive.LastEditedBy), QueryFilter.New(Colors_ArchiveProperty.ValidFrom, FilterConditions.Equals, colors_archive.ValidFrom), QueryFilter.New(Colors_ArchiveProperty.ValidTo, FilterConditions.Equals, colors_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static Colors_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new Colors_Archive
            {
                ColorID = r.GetInt32(0),
                ColorName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        #endregion
    }
}
