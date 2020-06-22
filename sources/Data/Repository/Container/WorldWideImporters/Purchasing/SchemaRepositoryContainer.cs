/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters.Purchasing
{
    public partial class SchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Data.Repository.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing;
using TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Purchasing;

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This class represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial class SchemaRepositoryContainer:ISchemaRepositoryContainer
    {
        #region Entity Repositories
        public IPurchaseOrderLineRepository PurchaseOrderLine { get; set; }
        public IPurchaseOrderRepository PurchaseOrder { get; set; }
        public ISupplierCategoryRepository SupplierCategory { get; set; }
        public ISupplierCategories_ArchiveRepository SupplierCategories_Archive { get; set; }
        public ISupplierRepository Supplier { get; set; }
        public ISuppliers_ArchiveRepository Suppliers_Archive { get; set; }
        public ISupplierTransactionRepository SupplierTransaction { get; set; }
        #endregion
        public SchemaRepositoryContainer()
        {
            #region Entity Repositories
            PurchaseOrderLine = new PurchaseOrderLineRepository();
            PurchaseOrder = new PurchaseOrderRepository();
            SupplierCategory = new SupplierCategoryRepository();
            SupplierCategories_Archive = new SupplierCategories_ArchiveRepository();
            Supplier = new SupplierRepository();
            Suppliers_Archive = new Suppliers_ArchiveRepository();
            SupplierTransaction = new SupplierTransactionRepository();
            #endregion
            // If not implemented this method is removed during compilation
            LoadCustomRepositories();
        }
        // Implement this method in a partial class to load custom repositories
        partial void LoadCustomRepositories();
    }
}
