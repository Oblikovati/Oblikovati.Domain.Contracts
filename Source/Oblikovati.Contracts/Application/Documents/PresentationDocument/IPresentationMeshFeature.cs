using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

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