using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedAssemblyComponents;

public interface IDerivedAssemblyComponents : IList<IDerivedAssemblyComponents>
{
    IDerivedAssemblyComponent Item { get; }
    IComponentDefinition Parent { get; }
    IDerivedAssemblyComponent Add(IDerivedAssemblyDefinition Definition);
    IDerivedAssemblyDefinition CreateDefinition(string FullDocumentName);
    IDerivedAssemblyDefinition _CreateDefinition(string FullDocumentName);
}