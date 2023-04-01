namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedFutureAssemblyComponents;

public interface IDerivedFutureAssemblyDefinition
{
    string ActiveDesignViewRepresentation { get; set; }
    string ActivePositionalRepresentation { get; set; }
    IDerivedFutureAssemblyOccurrences Occurrences { get; }
    string FullFileName { get; }
    bool IsAssociativeDesignView { get; set; }
}