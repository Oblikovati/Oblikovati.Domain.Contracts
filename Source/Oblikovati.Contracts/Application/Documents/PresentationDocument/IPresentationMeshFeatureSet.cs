using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationMeshFeatureSet : IList<IPresentationMeshFeatureSet>
{
    IPresentationMeshFeature Item { get; }
    string Name { get; }
    IPresentationComponent Parent { get; }
    MeshFeaturesSuppressionEnum Suppressed { get; }
    MeshFeaturesVisibilityEnum Visible { get; }
}