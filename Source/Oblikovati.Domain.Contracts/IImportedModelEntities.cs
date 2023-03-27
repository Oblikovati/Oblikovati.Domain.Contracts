namespace Oblikovati.Domain.Contracts;

public interface IImportedModelEntities : IList<IImportedModelEntities>
{

    int Count { get; }
    IImportedModelEntity Item { get; }
    IEnumerator GetEnumerator();
}
