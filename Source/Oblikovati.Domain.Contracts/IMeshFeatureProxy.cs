using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMeshFeatureProxy
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
    IMeshFeature NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete(bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}
