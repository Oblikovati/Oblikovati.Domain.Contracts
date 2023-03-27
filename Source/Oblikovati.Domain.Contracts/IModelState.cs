using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
