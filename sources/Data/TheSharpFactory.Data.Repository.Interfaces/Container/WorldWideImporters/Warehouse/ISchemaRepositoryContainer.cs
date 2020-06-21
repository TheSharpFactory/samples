/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Warehouse
{
    public partial interface ISchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse;

namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This interface represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial interface ISchemaRepositoryContainer
    {
        #region Entity Repositories
        IColdRoomTemperatureRepository ColdRoomTemperature { get; set; }
        IColdRoomTemperatures_ArchiveRepository ColdRoomTemperatures_Archive { get; set; }
        IColorRepository Color { get; set; }
        IColors_ArchiveRepository Colors_Archive { get; set; }
        IPackageTypeRepository PackageType { get; set; }
        IPackageTypes_ArchiveRepository PackageTypes_Archive { get; set; }
        IStockGroupRepository StockGroup { get; set; }
        IStockGroups_ArchiveRepository StockGroups_Archive { get; set; }
        IStockItemHoldingRepository StockItemHolding { get; set; }
        IStockItemRepository StockItem { get; set; }
        IStockItems_ArchiveRepository StockItems_Archive { get; set; }
        IStockItemStockGroupRepository StockItemStockGroup { get; set; }
        IStockItemTransactionRepository StockItemTransaction { get; set; }
        IVehicleTemperatureRepository VehicleTemperature { get; set; }
        #endregion
    }
}
