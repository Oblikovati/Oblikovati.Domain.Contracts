using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPresentationMeshFeatureSet : IList<IPresentationMeshFeatureSet>
{

    int Count { get; }
    IPresentationMeshFeature Item { get; }
    string Name { get; }
    IPresentationComponent Parent { get; }
    MeshFeaturesSuppressionEnum Suppressed { get; }
    MeshFeaturesVisibilityEnum Visible { get; }
    IEnumerator GetEnumerator();
}
