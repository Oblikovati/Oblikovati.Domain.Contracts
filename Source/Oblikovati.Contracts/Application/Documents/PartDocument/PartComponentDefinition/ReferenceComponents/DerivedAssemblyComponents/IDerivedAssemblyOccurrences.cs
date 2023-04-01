namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedAssemblyComponents;

public interface IDerivedAssemblyOccurrences : IList<IDerivedAssemblyOccurrences>
{
    IDerivedAssemblyOccurrence Item { get; }
}