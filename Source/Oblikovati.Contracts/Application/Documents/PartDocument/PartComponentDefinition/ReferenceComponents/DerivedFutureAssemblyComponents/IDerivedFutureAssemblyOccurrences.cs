namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedFutureAssemblyComponents;

public interface IDerivedFutureAssemblyOccurrences : IList<IDerivedFutureAssemblyOccurrences>
{
    IDerivedFutureAssemblyOccurrence Item { get; }
}