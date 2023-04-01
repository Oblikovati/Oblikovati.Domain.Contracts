namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedPartComponents;

public interface IDerivedPartEntities : IList<IDerivedPartEntities>
{
    IDerivedPartEntity Item { get; }
}