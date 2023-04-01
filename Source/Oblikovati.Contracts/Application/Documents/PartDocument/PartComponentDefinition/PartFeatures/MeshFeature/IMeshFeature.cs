using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MeshFeature;

public interface IMeshFeature
{
    IAttributeSets AttributeSets { get; }
    string Name { get; set; }
    IBox RangeBox { get; }
    IMeshFeatureSet Parent { get; }
    bool Visible { get; set; }
    bool Suppressed { get; set; }
    IMeshFeatureEntitiesEnumerator Entities { get; }
    IAsset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    HealthStatusEnum HealthStatus { get; }
    IRenderStyle RenderStyle { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete(bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}