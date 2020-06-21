/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Application
{
    public partial interface ISchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Application;

namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Application
{

    /// <summary>
    /// This interface represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial interface ISchemaRepositoryContainer
    {
        #region Entity Repositories
        ICityRepository City { get; set; }
        ICities_ArchiveRepository Cities_Archive { get; set; }
        ICountryRepository Country { get; set; }
        ICountries_ArchiveRepository Countries_Archive { get; set; }
        IDeliveryMethodRepository DeliveryMethod { get; set; }
        IDeliveryMethods_ArchiveRepository DeliveryMethods_Archive { get; set; }
        IPaymentMethodRepository PaymentMethod { get; set; }
        IPaymentMethods_ArchiveRepository PaymentMethods_Archive { get; set; }
        IPersonRepository Person { get; set; }
        IPeople_ArchiveRepository People_Archive { get; set; }
        IStateProvinceRepository StateProvince { get; set; }
        IStateProvinces_ArchiveRepository StateProvinces_Archive { get; set; }
        ISystemParameterRepository SystemParameter { get; set; }
        ITransactionTypeRepository TransactionType { get; set; }
        ITransactionTypes_ArchiveRepository TransactionTypes_Archive { get; set; }
        #endregion
    }
}
