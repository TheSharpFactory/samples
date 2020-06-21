/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters.Application
{
    public partial class SchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Data.Repository.WorldWideImporters.Application;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application;
using TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Application;

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters.Application
{

    /// <summary>
    /// This class represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial class SchemaRepositoryContainer:ISchemaRepositoryContainer
    {
        #region Entity Repositories
        public ICityRepository City { get; set; }
        public ICities_ArchiveRepository Cities_Archive { get; set; }
        public ICountryRepository Country { get; set; }
        public ICountries_ArchiveRepository Countries_Archive { get; set; }
        public IDeliveryMethodRepository DeliveryMethod { get; set; }
        public IDeliveryMethods_ArchiveRepository DeliveryMethods_Archive { get; set; }
        public IPaymentMethodRepository PaymentMethod { get; set; }
        public IPaymentMethods_ArchiveRepository PaymentMethods_Archive { get; set; }
        public IPersonRepository Person { get; set; }
        public IPeople_ArchiveRepository People_Archive { get; set; }
        public IStateProvinceRepository StateProvince { get; set; }
        public IStateProvinces_ArchiveRepository StateProvinces_Archive { get; set; }
        public ISystemParameterRepository SystemParameter { get; set; }
        public ITransactionTypeRepository TransactionType { get; set; }
        public ITransactionTypes_ArchiveRepository TransactionTypes_Archive { get; set; }
        #endregion
        public SchemaRepositoryContainer()
        {
            #region Entity Repositories
            City = new CityRepository();
            Cities_Archive = new Cities_ArchiveRepository();
            Country = new CountryRepository();
            Countries_Archive = new Countries_ArchiveRepository();
            DeliveryMethod = new DeliveryMethodRepository();
            DeliveryMethods_Archive = new DeliveryMethods_ArchiveRepository();
            PaymentMethod = new PaymentMethodRepository();
            PaymentMethods_Archive = new PaymentMethods_ArchiveRepository();
            Person = new PersonRepository();
            People_Archive = new People_ArchiveRepository();
            StateProvince = new StateProvinceRepository();
            StateProvinces_Archive = new StateProvinces_ArchiveRepository();
            SystemParameter = new SystemParameterRepository();
            TransactionType = new TransactionTypeRepository();
            TransactionTypes_Archive = new TransactionTypes_ArchiveRepository();
            #endregion
            // If not implemented this method is removed during compilation
            LoadCustomRepositories();
        }
        // Implement this method in a partial class to load custom repositories
        partial void LoadCustomRepositories();
    }
}
