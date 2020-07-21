/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{
    public partial class People_ArchiveRepository
    {
    }
}

************************************************/

using System.Data.SqlClient;
using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;
using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application;

namespace TheSharpFactory.Data.Repository.WorldWideImporters.Application
{

    /// <summary>
    /// This class represents the Repository for: People_Archive.
    /// </summary>
    public partial class People_ArchiveRepository:WritableRepositoryBase<People_Archive, People_ArchiveProperty>, IPeople_ArchiveRepository
    {
        #region Constructors
        public People_ArchiveRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.WorldWideImporters;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.WorldWideImporters_Application_People_Archive;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //there was no default sort found in the store. keep this variable as a placeholder.
            //it is also possible to add a constructor and fill this collection with a custom sort.
            DefaultSort = new SortFilters<People_ArchiveProperty>(0);
            #endregion
        }
        #endregion
        #region Materialization
        protected override QueryFilters<People_ArchiveProperty> ComposeKeys(People_Archive people_archive)
        {
            return new QueryFilters<People_ArchiveProperty>{ QueryFilter.New(People_ArchiveProperty.PersonID, FilterConditions.Equals, people_archive.PersonID), QueryFilter.New(People_ArchiveProperty.FullName, FilterConditions.Equals, people_archive.FullName), QueryFilter.New(People_ArchiveProperty.PreferredName, FilterConditions.Equals, people_archive.PreferredName), QueryFilter.New(People_ArchiveProperty.SearchName, FilterConditions.Equals, people_archive.SearchName), QueryFilter.New(People_ArchiveProperty.IsPermittedToLogon, FilterConditions.Equals, people_archive.IsPermittedToLogon), QueryFilter.New(People_ArchiveProperty.LogonName, FilterConditions.Equals, people_archive.LogonName), QueryFilter.New(People_ArchiveProperty.IsExternalLogonProvider, FilterConditions.Equals, people_archive.IsExternalLogonProvider), QueryFilter.New(People_ArchiveProperty.HashedPassword, FilterConditions.Equals, people_archive.HashedPassword), QueryFilter.New(People_ArchiveProperty.IsSystemUser, FilterConditions.Equals, people_archive.IsSystemUser), QueryFilter.New(People_ArchiveProperty.IsEmployee, FilterConditions.Equals, people_archive.IsEmployee), QueryFilter.New(People_ArchiveProperty.IsSalesperson, FilterConditions.Equals, people_archive.IsSalesperson), QueryFilter.New(People_ArchiveProperty.UserPreferences, FilterConditions.Equals, people_archive.UserPreferences), QueryFilter.New(People_ArchiveProperty.PhoneNumber, FilterConditions.Equals, people_archive.PhoneNumber), QueryFilter.New(People_ArchiveProperty.FaxNumber, FilterConditions.Equals, people_archive.FaxNumber), QueryFilter.New(People_ArchiveProperty.EmailAddress, FilterConditions.Equals, people_archive.EmailAddress), QueryFilter.New(People_ArchiveProperty.Photo, FilterConditions.Equals, people_archive.Photo), QueryFilter.New(People_ArchiveProperty.CustomFields, FilterConditions.Equals, people_archive.CustomFields), QueryFilter.New(People_ArchiveProperty.OtherLanguages, FilterConditions.Equals, people_archive.OtherLanguages), QueryFilter.New(People_ArchiveProperty.LastEditedBy, FilterConditions.Equals, people_archive.LastEditedBy), QueryFilter.New(People_ArchiveProperty.ValidFrom, FilterConditions.Equals, people_archive.ValidFrom), QueryFilter.New(People_ArchiveProperty.ValidTo, FilterConditions.Equals, people_archive.ValidTo) };
        }
        protected override QueryFilters<People_ArchiveProperty> GetChanges(People_Archive original, People_Archive changed)
        {
            return People_ArchiveUtils.GetChanges(original, changed);
        }
        protected override void Merge(People_Archive source, People_Archive target)
        {
            People_ArchiveUtils.Merge(source, target);
        }
        protected override QueryFilters<People_ArchiveProperty> ComposeInsertPredicate(People_Archive people_archive)
        {
            return new QueryFilters<People_ArchiveProperty>{ QueryFilter.New(People_ArchiveProperty.PersonID, FilterConditions.Equals, people_archive.PersonID), QueryFilter.New(People_ArchiveProperty.FullName, FilterConditions.Equals, people_archive.FullName), QueryFilter.New(People_ArchiveProperty.PreferredName, FilterConditions.Equals, people_archive.PreferredName), QueryFilter.New(People_ArchiveProperty.SearchName, FilterConditions.Equals, people_archive.SearchName), QueryFilter.New(People_ArchiveProperty.IsPermittedToLogon, FilterConditions.Equals, people_archive.IsPermittedToLogon), QueryFilter.New(People_ArchiveProperty.LogonName, FilterConditions.Equals, people_archive.LogonName), QueryFilter.New(People_ArchiveProperty.IsExternalLogonProvider, FilterConditions.Equals, people_archive.IsExternalLogonProvider), QueryFilter.New(People_ArchiveProperty.HashedPassword, FilterConditions.Equals, people_archive.HashedPassword), QueryFilter.New(People_ArchiveProperty.IsSystemUser, FilterConditions.Equals, people_archive.IsSystemUser), QueryFilter.New(People_ArchiveProperty.IsEmployee, FilterConditions.Equals, people_archive.IsEmployee), QueryFilter.New(People_ArchiveProperty.IsSalesperson, FilterConditions.Equals, people_archive.IsSalesperson), QueryFilter.New(People_ArchiveProperty.UserPreferences, FilterConditions.Equals, people_archive.UserPreferences), QueryFilter.New(People_ArchiveProperty.PhoneNumber, FilterConditions.Equals, people_archive.PhoneNumber), QueryFilter.New(People_ArchiveProperty.FaxNumber, FilterConditions.Equals, people_archive.FaxNumber), QueryFilter.New(People_ArchiveProperty.EmailAddress, FilterConditions.Equals, people_archive.EmailAddress), QueryFilter.New(People_ArchiveProperty.Photo, FilterConditions.Equals, people_archive.Photo), QueryFilter.New(People_ArchiveProperty.CustomFields, FilterConditions.Equals, people_archive.CustomFields), QueryFilter.New(People_ArchiveProperty.OtherLanguages, FilterConditions.Equals, people_archive.OtherLanguages), QueryFilter.New(People_ArchiveProperty.LastEditedBy, FilterConditions.Equals, people_archive.LastEditedBy), QueryFilter.New(People_ArchiveProperty.ValidFrom, FilterConditions.Equals, people_archive.ValidFrom), QueryFilter.New(People_ArchiveProperty.ValidTo, FilterConditions.Equals, people_archive.ValidTo) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 21);
        }
        private static People_Archive MaterializeSingleEntity(SqlDataReader r)
        {
            return new People_Archive
            {
                PersonID = r.GetInt32(0),
                FullName = r.GetString(1),
                PreferredName = r.GetString(2),
                SearchName = r.GetString(3),
                IsPermittedToLogon = r.GetBoolean(4),
                LogonName = r.GetValue(5) as string,
                IsExternalLogonProvider = r.GetBoolean(6),
                HashedPassword = r.GetValue(7) as byte[],
                IsSystemUser = r.GetBoolean(8),
                IsEmployee = r.GetBoolean(9),
                IsSalesperson = r.GetBoolean(10),
                UserPreferences = r.GetValue(11) as string,
                PhoneNumber = r.GetValue(12) as string,
                FaxNumber = r.GetValue(13) as string,
                EmailAddress = r.GetValue(14) as string,
                Photo = r.GetValue(15) as byte[],
                CustomFields = r.GetValue(16) as string,
                OtherLanguages = r.GetValue(17) as string,
                LastEditedBy = r.GetInt32(18),
                ValidFrom = r.GetDateTime(19),
                ValidTo = r.GetDateTime(20),
            };
        }
        #endregion
    }
}
