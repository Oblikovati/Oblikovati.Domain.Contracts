using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

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