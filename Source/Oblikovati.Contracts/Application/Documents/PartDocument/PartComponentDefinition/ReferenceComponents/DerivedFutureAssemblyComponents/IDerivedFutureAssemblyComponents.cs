using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedFutureAssemblyComponents;

public interface IDerivedFutureAssemblyComponents : IList<IDerivedFutureAssemblyComponents>
{
    IDerivedFutureAssemblyComponent Item { get; }
    IComponentDefinition Parent { get; }
    IDerivedFutureAssemblyComponent Add(IDerivedFutureAssemblyDefinition Definition);
    IDerivedFutureAssemblyDefinition CreateDefinition(string FullDocumentName);
}