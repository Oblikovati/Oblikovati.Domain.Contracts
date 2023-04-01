namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedPartComponents;

public interface IDerivedPartEntity
{
    object ReferencedEntity { get; }
    bool IncludeEntity { get; set; }
}