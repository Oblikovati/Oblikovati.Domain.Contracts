namespace Oblikovati.Domain.Contracts;

public interface IImportedComponents : IList<IImportedComponents>
{

    int Count { get; }
    IComponentDefinition Parent { get; }
    IImportedComponent Item { get; }
    IImportedComponent Add(IImportedComponentDefinition Definition);
    IImportedComponentDefinition CreateDefinition(string FullFileName);
    IEnumerator GetEnumerator();
}
