/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container
{
    public partial class RepositoryContainer
    {
    }
}

************************************************/

using IContainer = TheSharpFactory.Data.Repository.Container.Interfaces;

namespace TheSharpFactory.Data.Repository.Container
{

    /// <summary>
    /// This class contains all Repository Containers for all Models.
    /// </summary>
    public partial class RepositoryContainer:IContainer.IRepositoryContainer
    {
        public IContainer.WorldWideImporters.IModelRepositoryContainer  WorldWideImporters { get; set; }
        public RepositoryContainer()
        {
            WorldWideImporters = new WorldWideImporters.ModelRepositoryContainer();
            // If not implemented this method is removed during compilation
            LoadCustomContainers();
        }
        // Implement this method in a partial class to load custom containers
        partial void LoadCustomContainers();
    }
}
