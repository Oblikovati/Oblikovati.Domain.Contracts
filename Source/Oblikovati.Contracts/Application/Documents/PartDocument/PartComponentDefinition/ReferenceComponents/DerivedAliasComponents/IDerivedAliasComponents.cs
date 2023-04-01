using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedAliasComponents;

public interface IDerivedAliasComponents : IList<IDerivedAliasComponents>
{
    IDerivedAliasComponent Item { get; }
    IComponentDefinition Parent { get; }
}