using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPresentationMeshFeature
{

    AppearanceSourceTypeEnum AppearanceSourceType { get; }
    IAsset Appearance { get; }
    IPresentationMeshFeatureEntitiesEnumerator Entities { get; }
    string Name { get; }
    IPresentationMeshFeatureSet Parent { get; }
    bool Suppressed { get; }
    bool Visible { get; }
}
