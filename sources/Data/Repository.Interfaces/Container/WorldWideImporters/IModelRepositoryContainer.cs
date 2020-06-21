/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters
{
    public partial interface IModelRepositoryContainer
    {
    }
}

************************************************/


namespace TheSharpFactory.Data.Repository.Container.Interfaces.WorldWideImporters
{

    /// <summary>
    /// This interface represents the Repository Container for a specific Model.
    /// </summary>
    public partial interface IModelRepositoryContainer
    {
        Application.ISchemaRepositoryContainer Application { get; set; }
        Purchasing.ISchemaRepositoryContainer Purchasing { get; set; }
        Sales.ISchemaRepositoryContainer Sales { get; set; }
        Warehouse.ISchemaRepositoryContainer Warehouse { get; set; }
    }
}
