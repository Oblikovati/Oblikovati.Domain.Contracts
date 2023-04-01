using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MeshFeature;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPublicationComponent
{
    IPublication Parent { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    bool OverrideVisible { get; set; }
    string Name { get; }
    IPublicationComponent ParentComponent { get; }
    IPublicationComponentsEnumerator SubComponents { get; }
    double OverrideOpacity { get; set; }
    bool InitialVisible { get; }
    bool IsVisibleOverridden { get; }
    IBox RangeBox { get; }
    IMatrix Transformation { get; }
    IMatrix InitialTransformation { get; }
    double InitialOpacity { get; }
    IPublicationBodiesEnumerator SurfaceBodies { get; }
    bool IsLeaf { get; }
    DisplayModeEnum DisplayMode { get; set; }
    DisplayModeSourceTypeEnum DisplayModeSourceType { get; set; }
    IAsset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    IMeshFeatureSets MeshFeatureSets { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void ClearVisibleOverrides();
    IMatrix GetTweakTransformationAt(IStoryboard Storyboard, double Time);
}