using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDerivedAssemblyComponentProxy
{

    IComponentDefinition Parent { get; }
    bool LinkedToFile { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; }
    bool IsEmbedded { get; }
    IReferencedFileDescriptor ReferencedFile { get; }
    IReferenceFeaturesEnumerator ReferenceFeatures { get; }
    bool SuppressAll { get; set; }
    IDerivedAssemblyDefinition Definition { get; set; }
    bool SuppressLinkToFile { get; set; }
    IDerivedAssemblyComponent NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void BreakLinkToFile();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void SetEndOfPart(bool Before);
}
