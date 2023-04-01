using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ReferenceFeature;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedFutureAssemblyComponents;

public interface IDerivedFutureAssemblyComponent
{
    IComponentDefinition Parent { get; }
    bool LinkedToFile { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; }
    bool IsEmbedded { get; }
    IReferencedFileDescriptor ReferencedFile { get; }
    IDerivedFutureAssemblyDefinition Definition { get; set; }
    IReferenceFeaturesEnumerator ReferenceFeatures { get; }
    bool SuppressAll { get; set; }
    bool SuppressLinkToFile { get; set; }
    void BreakLinkToFile();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void SetEndOfPart(bool Before);
}