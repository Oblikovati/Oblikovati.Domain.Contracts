namespace Oblikovati.Domain.Contracts;

public interface IDerivedAssemblyComponents : IList<IDerivedAssemblyComponents>
{

    int Count { get; }
    IDerivedAssemblyComponent Item { get; }
    IComponentDefinition Parent { get; }
    IDerivedAssemblyComponent Add(IDerivedAssemblyDefinition Definition);
    IDerivedAssemblyDefinition CreateDefinition(string FullDocumentName);
    IDerivedAssemblyDefinition _CreateDefinition(string FullDocumentName);
    IEnumerator GetEnumerator();
}
