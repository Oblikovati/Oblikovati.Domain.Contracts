using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MeshFeature;

public interface IMeshFeatureSet : IList<IMeshFeatureSet>
{
    IMeshFeature Item { get; }

    IComponentDefinition Parent { get; }
    IAttributeSets AttributeSets { get; }
    string Name { get; set; }
    IBox RangeBox { get; }
    MeshFeaturesVisibilityEnum Visible { get; set; }
    MeshFeaturesSuppressionEnum Suppressed { get; set; }
    HealthStatusEnum HealthStatus { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);

    void Delete(bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
}