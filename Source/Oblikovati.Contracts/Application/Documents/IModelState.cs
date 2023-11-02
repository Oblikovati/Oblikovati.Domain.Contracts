using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents;

public interface IModelState
{
    IAttributeSets AttributeSets { get; }
    IComponentDefinition Parent { get; }
    IDocument Document { get; }
    IDocument FactoryDocument { get; }
    ModelStateTypeEnum ModelStateType { get; }
    string Name { get; set; }
    IDocumentDescriptor SubstituteDocumentDescriptor { get; }
    IComponentOccurrence SubstituteOccurrence { get; }
    IModelState BOMDelegate { get; }
    IModelState Copy(string NewName);
    IDesignViewRepresentation CopyComponentSuppressionToVisibility(string NewName);
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Activate();
}