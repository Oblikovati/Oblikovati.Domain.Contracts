using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPresentationComponent
{

    IAsset Appearance { get; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; }
    string Name { get; }
    IPresentationMeshFeatureSetsEnumerator MeshFeatureSets { get; }
    IPresentationBodiesEnumerator SurfaceBodies { get; }
    bool IsLeaf { get; }
    IMatrix Transformation { get; }
    double Opacity { get; }
    IPresentationScene Parent { get; }
    IPresentationComponent ParentComponent { get; }
    IPresentationComponentsEnumerator SubComponents { get; }
    bool Visible { get; }
}
