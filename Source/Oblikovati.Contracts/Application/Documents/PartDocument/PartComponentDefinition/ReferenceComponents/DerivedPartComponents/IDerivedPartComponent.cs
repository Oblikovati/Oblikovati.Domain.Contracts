using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iMateDefinitions;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ReferenceFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;
using Oblikovati.Contracts.Sketch2D;
using Oblikovati.Contracts.Sketch3D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedPartComponents;

public interface IDerivedPartComponent
{
    IComponentDefinition Parent { get; }
    bool LinkedToFile { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; }
    bool IsEmbedded { get; }
    IReferencedFileDescriptor ReferencedFile { get; }
    IReferenceFeature PrimaryBody { get; }
    ISketchesEnumerator Sketches { get; }
    IObjectsEnumerator WorkFeatures { get; }
    IReferenceFeaturesEnumerator SurfaceBodies { get; }
    IParametersEnumerator Parameters { get; }
    IDerivedPartDefinition Definition { get; set; }
    bool SuppressLinkToFile { get; set; }
    ISketches3DEnumerator Sketches3D { get; }
    IReferenceFeaturesEnumerator SolidBodies { get; }
    IiMateDefinitionsEnumerator iMateDefinitions { get; }
    ISketchBlockDefinitionsEnumerator SketchBlockDefinitions { get; }
    ISketchBlocksEnumerator SketchBlocks { get; }
    void BreakLinkToFile();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void SetEndOfPart(bool Before);
}