/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{
    public static partial class People_ArchiveUtils
    {
    }
}

************************************************/

using TheSharpFactory.Data.Entity.WorldWideImporters.Application;
using TheSharpFactory.Data.Query;

namespace TheSharpFactory.Data.Entity.Utils.WorldWideImporters.Application
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Data.Entity.WorldWideImporters.Application.People_Archive.
    /// </summary>
    public static partial class People_ArchiveUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(People_Archive one, People_Archive two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.PersonID != two.PersonID)
                return true;
            if(string.CompareOrdinal(one.FullName, two.FullName) != 0)
                return true;
            if(string.CompareOrdinal(one.PreferredName, two.PreferredName) != 0)
                return true;
            if(string.CompareOrdinal(one.SearchName, two.SearchName) != 0)
                return true;
            if(one.IsPermittedToLogon != two.IsPermittedToLogon)
                return true;
            if(string.CompareOrdinal(one.LogonName, two.LogonName) != 0)
                return true;
            if(one.IsExternalLogonProvider != two.IsExternalLogonProvider)
                return true;
            if(!Compare.ByteArrays(one.HashedPassword, two.HashedPassword))
                return true;
            if(one.IsSystemUser != two.IsSystemUser)
                return true;
            if(one.IsEmployee != two.IsEmployee)
                return true;
            if(one.IsSalesperson != two.IsSalesperson)
                return true;
            if(string.CompareOrdinal(one.UserPreferences, two.UserPreferences) != 0)
                return true;
            if(string.CompareOrdinal(one.PhoneNumber, two.PhoneNumber) != 0)
                return true;
            if(string.CompareOrdinal(one.FaxNumber, two.FaxNumber) != 0)
                return true;
            if(string.CompareOrdinal(one.EmailAddress, two.EmailAddress) != 0)
                return true;
            if(!Compare.ByteArrays(one.Photo, two.Photo))
                return true;
            if(string.CompareOrdinal(one.CustomFields, two.CustomFields) != 0)
                return true;
            if(string.CompareOrdinal(one.OtherLanguages, two.OtherLanguages) != 0)
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
        public static void Merge(People_Archive source, People_Archive target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.PersonID = source.PersonID;
            target.FullName = source.FullName;
            target.PreferredName = source.PreferredName;
            target.SearchName = source.SearchName;
            target.IsPermittedToLogon = source.IsPermittedToLogon;
            target.LogonName = source.LogonName;
            target.IsExternalLogonProvider = source.IsExternalLogonProvider;
            target.HashedPassword = source.HashedPassword;
            target.IsSystemUser = source.IsSystemUser;
            target.IsEmployee = source.IsEmployee;
            target.IsSalesperson = source.IsSalesperson;
            target.UserPreferences = source.UserPreferences;
            target.PhoneNumber = source.PhoneNumber;
            target.FaxNumber = source.FaxNumber;
            target.EmailAddress = source.EmailAddress;
            target.Photo = source.Photo;
            target.CustomFields = source.CustomFields;
            target.OtherLanguages = source.OtherLanguages;
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
        /// <returns>QueryFilters of People_ArchiveProperty</returns>
        public static QueryFilters<People_ArchiveProperty> GetChanges(People_Archive original, People_Archive changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<People_ArchiveProperty>(21);
            #region Detect Changes
            if(original.PersonID != changed.PersonID)
                changes.Add(QueryFilter.New(People_ArchiveProperty.PersonID, FilterConditions.Equals, changed.PersonID));
            if(string.CompareOrdinal(original.FullName, changed.FullName) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.FullName, FilterConditions.Equals, changed.FullName));
            if(string.CompareOrdinal(original.PreferredName, changed.PreferredName) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.PreferredName, FilterConditions.Equals, changed.PreferredName));
            if(string.CompareOrdinal(original.SearchName, changed.SearchName) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.SearchName, FilterConditions.Equals, changed.SearchName));
            if(original.IsPermittedToLogon != changed.IsPermittedToLogon)
                changes.Add(QueryFilter.New(People_ArchiveProperty.IsPermittedToLogon, FilterConditions.Equals, changed.IsPermittedToLogon));
            if(string.CompareOrdinal(original.LogonName, changed.LogonName) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.LogonName, FilterConditions.Equals, changed.LogonName));
            if(original.IsExternalLogonProvider != changed.IsExternalLogonProvider)
                changes.Add(QueryFilter.New(People_ArchiveProperty.IsExternalLogonProvider, FilterConditions.Equals, changed.IsExternalLogonProvider));
            if(!Compare.ByteArrays(original.HashedPassword, changed.HashedPassword))
                changes.Add(QueryFilter.New(People_ArchiveProperty.HashedPassword, FilterConditions.Equals, changed.HashedPassword));
            if(original.IsSystemUser != changed.IsSystemUser)
                changes.Add(QueryFilter.New(People_ArchiveProperty.IsSystemUser, FilterConditions.Equals, changed.IsSystemUser));
            if(original.IsEmployee != changed.IsEmployee)
                changes.Add(QueryFilter.New(People_ArchiveProperty.IsEmployee, FilterConditions.Equals, changed.IsEmployee));
            if(original.IsSalesperson != changed.IsSalesperson)
                changes.Add(QueryFilter.New(People_ArchiveProperty.IsSalesperson, FilterConditions.Equals, changed.IsSalesperson));
            if(string.CompareOrdinal(original.UserPreferences, changed.UserPreferences) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.UserPreferences, FilterConditions.Equals, changed.UserPreferences));
            if(string.CompareOrdinal(original.PhoneNumber, changed.PhoneNumber) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.PhoneNumber, FilterConditions.Equals, changed.PhoneNumber));
            if(string.CompareOrdinal(original.FaxNumber, changed.FaxNumber) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.FaxNumber, FilterConditions.Equals, changed.FaxNumber));
            if(string.CompareOrdinal(original.EmailAddress, changed.EmailAddress) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.EmailAddress, FilterConditions.Equals, changed.EmailAddress));
            if(!Compare.ByteArrays(original.Photo, changed.Photo))
                changes.Add(QueryFilter.New(People_ArchiveProperty.Photo, FilterConditions.Equals, changed.Photo));
            if(string.CompareOrdinal(original.CustomFields, changed.CustomFields) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.CustomFields, FilterConditions.Equals, changed.CustomFields));
            if(string.CompareOrdinal(original.OtherLanguages, changed.OtherLanguages) != 0)
                changes.Add(QueryFilter.New(People_ArchiveProperty.OtherLanguages, FilterConditions.Equals, changed.OtherLanguages));
            if(original.LastEditedBy != changed.LastEditedBy)
                changes.Add(QueryFilter.New(People_ArchiveProperty.LastEditedBy, FilterConditions.Equals, changed.LastEditedBy));
            if(original.ValidFrom != changed.ValidFrom)
                changes.Add(QueryFilter.New(People_ArchiveProperty.ValidFrom, FilterConditions.Equals, changed.ValidFrom));
            if(original.ValidTo != changed.ValidTo)
                changes.Add(QueryFilter.New(People_ArchiveProperty.ValidTo, FilterConditions.Equals, changed.ValidTo));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
