/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters.Sales
{
    public partial class SchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Data.Repository.WorldWideImporters.Sales;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Sales;
using TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Sales;

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters.Sales
{

    /// <summary>
    /// This class represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial class SchemaRepositoryContainer:ISchemaRepositoryContainer
    {
        #region Entity Repositories
        public IBuyingGroupRepository BuyingGroup { get; set; }
        public IBuyingGroups_ArchiveRepository BuyingGroups_Archive { get; set; }
        public ICustomerCategoryRepository CustomerCategory { get; set; }
        public ICustomerCategories_ArchiveRepository CustomerCategories_Archive { get; set; }
        public ICustomerRepository Customer { get; set; }
        public ICustomers_ArchiveRepository Customers_Archive { get; set; }
        public ICustomerTransactionRepository CustomerTransaction { get; set; }
        public IInvoiceLineRepository InvoiceLine { get; set; }
        public IInvoiceRepository Invoice { get; set; }
        public IOrderLineRepository OrderLine { get; set; }
        public IOrderRepository Order { get; set; }
        public ISpecialDealRepository SpecialDeal { get; set; }
        #endregion
        public SchemaRepositoryContainer()
        {
            #region Entity Repositories
            BuyingGroup = new BuyingGroupRepository();
            BuyingGroups_Archive = new BuyingGroups_ArchiveRepository();
            CustomerCategory = new CustomerCategoryRepository();
            CustomerCategories_Archive = new CustomerCategories_ArchiveRepository();
            Customer = new CustomerRepository();
            Customers_Archive = new Customers_ArchiveRepository();
            CustomerTransaction = new CustomerTransactionRepository();
            InvoiceLine = new InvoiceLineRepository();
            Invoice = new InvoiceRepository();
            OrderLine = new OrderLineRepository();
            Order = new OrderRepository();
            SpecialDeal = new SpecialDealRepository();
            #endregion
            // If not implemented this method is removed during compilation
            LoadCustomRepositories();
        }
        // Implement this method in a partial class to load custom repositories
        partial void LoadCustomRepositories();
    }
}
