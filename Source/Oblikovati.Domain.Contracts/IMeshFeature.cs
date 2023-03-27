using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
