namespace Oblikovati.Contracts.NotClassified;

public interface IImportedModelEntities : IList<IImportedModelEntities>
{
    IImportedModelEntity Item { get; }
}