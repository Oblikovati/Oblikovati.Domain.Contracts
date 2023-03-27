using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMeshFeatureSet : IList<IMeshFeatureSet>
{

    IMeshFeature Item { get; }
    int Count { get; }
    IComponentDefinition Parent { get; }
    IAttributeSets AttributeSets { get; }
    string Name { get; set; }
    IBox RangeBox { get; }
    MeshFeaturesVisibilityEnum Visible { get; set; }
    MeshFeaturesSuppressionEnum Suppressed { get; set; }
    HealthStatusEnum HealthStatus { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    IEnumerator GetEnumerator();
    void Delete(bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}
