using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.DWG;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IImportedDWGComponentProxy
{
    IComponentDefinition Parent { get; }
    bool LinkedToFile { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; }
    bool IsEmbedded { get; }
    IReferencedFileDescriptor ReferencedFile { get; }
    IImportedComponentDefinition Definition { get; set; }
    bool SuppressLinkToFile { get; set; }
    IDWGBlockDefinition ModelSpaceDefinition { get; }
    IBox2d Crop { get; set; }
    bool Visible { get; set; }
    IImportedDWGLayersEnumerator Layers { get; }
    bool Grounded { get; set; }
    object XYPlane { get; }
    object XZPlane { get; }
    object YZPlane { get; }
    object XAxis { get; }
    object YAxis { get; }
    object ZAxis { get; }
    object Origin { get; }
    IBox RangeBox { get; }
    IImportedDWGComponent NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void BreakLinkToFile();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void SetEndOfPart(bool Before);
}