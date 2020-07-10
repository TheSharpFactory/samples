/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Sales
{
    public partial interface ISchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales;

namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Sales
{

    /// <summary>
    /// This interface represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial interface ISchemaRepositoryContainer
    {
        #region Entity Repositories
        IBuyingGroupRepository BuyingGroup { get; set; }
        IBuyingGroups_ArchiveRepository BuyingGroups_Archive { get; set; }
        ICustomerCategoryRepository CustomerCategory { get; set; }
        ICustomerCategories_ArchiveRepository CustomerCategories_Archive { get; set; }
        ICustomerRepository Customer { get; set; }
        ICustomers_ArchiveRepository Customers_Archive { get; set; }
        ICustomerTransactionRepository CustomerTransaction { get; set; }
        IInvoiceLineRepository InvoiceLine { get; set; }
        IInvoiceRepository Invoice { get; set; }
        IOrderLineRepository OrderLine { get; set; }
        IOrderRepository Order { get; set; }
        ISpecialDealRepository SpecialDeal { get; set; }
        #endregion
    }
}
