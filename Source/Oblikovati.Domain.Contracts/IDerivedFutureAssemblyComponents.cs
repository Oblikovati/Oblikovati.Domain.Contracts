namespace Oblikovati.Domain.Contracts;

public interface IDerivedFutureAssemblyComponents : IList<IDerivedFutureAssemblyComponents>
{

    int Count { get; }
    IDerivedFutureAssemblyComponent Item { get; }
    IComponentDefinition Parent { get; }
    IDerivedFutureAssemblyComponent Add(IDerivedFutureAssemblyDefinition Definition);
    IDerivedFutureAssemblyDefinition CreateDefinition(string FullDocumentName);
    IEnumerator GetEnumerator();
}
