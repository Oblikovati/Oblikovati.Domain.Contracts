using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IShrinkwrapComponentProxy
{

    IComponentDefinition Parent { get; }
    bool LinkedToFile { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; }
    bool IsEmbedded { get; }
    IReferencedFileDescriptor ReferencedFile { get; }
    IShrinkwrapDefinition Definition { get; set; }
    IReferenceFeaturesEnumerator ReferenceFeatures { get; }
    bool SuppressLinkToFile { get; set; }
    IShrinkwrapComponent NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void BreakLinkToFile();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void SetEndOfPart(bool Before);
}
