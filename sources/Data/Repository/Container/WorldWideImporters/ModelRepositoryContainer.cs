/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters
{
    public partial class ModelRepositoryContainer
    {
    }
}

************************************************/

using IWorldWideImporters = TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters;

namespace TheSharpFactory.Data.Repository.Container.WorldWideImporters
{

    /// <summary>
    /// This class represents the Repository Container for a specific Model.
    /// </summary>
    public partial class ModelRepositoryContainer:IWorldWideImporters.IModelRepositoryContainer
    {
        public IWorldWideImporters.Application.ISchemaRepositoryContainer Application { get; set; }
        public IWorldWideImporters.Purchasing.ISchemaRepositoryContainer Purchasing { get; set; }
        public IWorldWideImporters.Sales.ISchemaRepositoryContainer Sales { get; set; }
        public IWorldWideImporters.Warehouse.ISchemaRepositoryContainer Warehouse { get; set; }
        public ModelRepositoryContainer()
        {
            Application = new Application.SchemaRepositoryContainer();
            Purchasing = new Purchasing.SchemaRepositoryContainer();
            Sales = new Sales.SchemaRepositoryContainer();
            Warehouse = new Warehouse.SchemaRepositoryContainer();
            // If not implemented this method is removed during compilation
            LoadCustomContainers();
        }
        // Implement this method in a partial class to load custom containers
        partial void LoadCustomContainers();
    }
}
