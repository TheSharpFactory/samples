/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class TransactionTypes_ArchiveRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{

    /// <summary>
    /// This class represents the Repository for: TransactionTypes_Archive.
    /// </summary>
    public partial class TransactionTypes_ArchiveRepository:WritableRepositoryBase<TransactionTypes_Archive, TransactionTypes_ArchiveProperty>, ITransactionTypes_ArchiveRepository
    {
        #region Constructors
        public TransactionTypes_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_TransactionTypes_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<TransactionTypes_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<TransactionTypes_ArchiveProperty> ComposeKeys(TransactionTypes_Archive transactiontypes_archive)
        {
            return new QueryFilters<TransactionTypes_ArchiveProperty>{ QueryFilter.New(TransactionTypes_ArchiveProperty.TransactionTypeID, FilterConditions.Equals, transactiontypes_archive.TransactionTypeID), QueryFilter.New(TransactionTypes_ArchiveProperty.TransactionTypeName, FilterConditions.Equals, transactiontypes_archive.TransactionTypeName), QueryFilter.New(TransactionTypes_ArchiveProperty.LastEditedBy, FilterConditions.Equals, transactiontypes_archive.LastEditedBy), QueryFilter.New(TransactionTypes_ArchiveProperty.ValidFrom, FilterConditions.Equals, transactiontypes_archive.ValidFrom), QueryFilter.New(TransactionTypes_ArchiveProperty.ValidTo, FilterConditions.Equals, transactiontypes_archive.ValidTo) };
        }
        protected override QueryFilters<TransactionTypes_ArchiveProperty> GetChanges(TransactionTypes_Archive original, TransactionTypes_Archive changed)
        {
            return TransactionTypes_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(TransactionTypes_Archive source, TransactionTypes_Archive target)
        {
            TransactionTypes_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<TransactionTypes_ArchiveProperty> ComposeInsertPredicate(TransactionTypes_Archive transactiontypes_archive)
        {
            return new QueryFilters<TransactionTypes_ArchiveProperty>{ QueryFilter.New(TransactionTypes_ArchiveProperty.TransactionTypeID, FilterConditions.Equals, transactiontypes_archive.TransactionTypeID), QueryFilter.New(TransactionTypes_ArchiveProperty.TransactionTypeName, FilterConditions.Equals, transactiontypes_archive.TransactionTypeName), QueryFilter.New(TransactionTypes_ArchiveProperty.LastEditedBy, FilterConditions.Equals, transactiontypes_archive.LastEditedBy), QueryFilter.New(TransactionTypes_ArchiveProperty.ValidFrom, FilterConditions.Equals, transactiontypes_archive.ValidFrom), QueryFilter.New(TransactionTypes_ArchiveProperty.ValidTo, FilterConditions.Equals, transactiontypes_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static TransactionTypes_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new TransactionTypes_Archive
            {
                TransactionTypeID = r.GetInt32(0),
                TransactionTypeName = r.GetString(1),
                LastEditedBy = r.GetInt32(2),
                ValidFrom = r.GetDateTime(3),
                ValidTo = r.GetDateTime(4),
            };
        }
        #endregion
    }
}
