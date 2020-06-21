/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Purchasing
{
    public partial interface ISchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Purchasing;

namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Purchasing
{

    /// <summary>
    /// This interface represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial interface ISchemaRepositoryContainer
    {
        #region Entity Repositories
        IPurchaseOrderLineRepository PurchaseOrderLine { get; set; }
        IPurchaseOrderRepository PurchaseOrder { get; set; }
        ISupplierCategoryRepository SupplierCategory { get; set; }
        ISupplierCategories_ArchiveRepository SupplierCategories_Archive { get; set; }
        ISupplierRepository Supplier { get; set; }
        ISuppliers_ArchiveRepository Suppliers_Archive { get; set; }
        ISupplierTransactionRepository SupplierTransaction { get; set; }
        #endregion
    }
}
