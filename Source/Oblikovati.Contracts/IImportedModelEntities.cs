namespace Oblikovati.Contracts;

public interface IImportedModelEntities : IList<IImportedModelEntities>
{
    IImportedModelEntity Item { get; }
}