/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters.Warehouse
{
    public partial class SchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Data.Repository.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Repository.Interfaces.WorldWideImporters.Warehouse;
using TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters.Warehouse;

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters.Warehouse
{

    /// <summary>
    /// This class represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial class SchemaRepositoryContainer:ISchemaRepositoryContainer
    {
        #region Entity Repositories
        public IColdRoomTemperatureRepository ColdRoomTemperature { get; set; }
        public IColdRoomTemperatures_ArchiveRepository ColdRoomTemperatures_Archive { get; set; }
        public IColorRepository Color { get; set; }
        public IColors_ArchiveRepository Colors_Archive { get; set; }
        public IPackageTypeRepository PackageType { get; set; }
        public IPackageTypes_ArchiveRepository PackageTypes_Archive { get; set; }
        public IStockGroupRepository StockGroup { get; set; }
        public IStockGroups_ArchiveRepository StockGroups_Archive { get; set; }
        public IStockItemHoldingRepository StockItemHolding { get; set; }
        public IStockItemRepository StockItem { get; set; }
        public IStockItems_ArchiveRepository StockItems_Archive { get; set; }
        public IStockItemStockGroupRepository StockItemStockGroup { get; set; }
        public IStockItemTransactionRepository StockItemTransaction { get; set; }
        public IVehicleTemperatureRepository VehicleTemperature { get; set; }
        #endregion
        public SchemaRepositoryContainer()
        {
            #region Entity Repositories
            ColdRoomTemperature = new ColdRoomTemperatureRepository();
            ColdRoomTemperatures_Archive = new ColdRoomTemperatures_ArchiveRepository();
            Color = new ColorRepository();
            Colors_Archive = new Colors_ArchiveRepository();
            PackageType = new PackageTypeRepository();
            PackageTypes_Archive = new PackageTypes_ArchiveRepository();
            StockGroup = new StockGroupRepository();
            StockGroups_Archive = new StockGroups_ArchiveRepository();
            StockItemHolding = new StockItemHoldingRepository();
            StockItem = new StockItemRepository();
            StockItems_Archive = new StockItems_ArchiveRepository();
            StockItemStockGroup = new StockItemStockGroupRepository();
            StockItemTransaction = new StockItemTransactionRepository();
            VehicleTemperature = new VehicleTemperatureRepository();
            #endregion
            // If not implemented this method is removed during compilation
            LoadCustomRepositories();
        }
        // Implement this method in a partial class to load custom repositories
        partial void LoadCustomRepositories();
    }
}
