using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
