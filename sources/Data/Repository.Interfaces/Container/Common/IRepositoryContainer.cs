/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.Interfaces
{
    public partial interface IRepositoryContainer
    {
    }
}

************************************************/


namespace TheSharpFactory.Data.Repository.Container.Interfaces
{

    /// <summary>
    /// This interface represents the Repository Container.
    /// </summary>
    public partial interface IRepositoryContainer
    {
        WorldWideImporters.IModelRepositoryContainer WorldWideImporters { get; set; }
    }
}
