using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedFuturePartComponents;

public interface IDerivedFuturePartComponents : IList<IDerivedFuturePartComponents>
{
    IDerivedFuturePartComponent Item { get; }
    IComponentDefinition Parent { get; }
    IDerivedFuturePartComponent Add(IDerivedFuturePartDefinition Definition);
    IDerivedFuturePartDefinition CreateDefinition(string FullDocumentName);
}