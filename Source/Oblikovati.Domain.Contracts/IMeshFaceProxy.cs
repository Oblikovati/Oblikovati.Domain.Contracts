using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMeshFaceProxy
{

    object Geometry { get; }
    SurfaceTypeEnum SurfaceType { get; }
    ISurfaceEvaluator Evaluator { get; }
    IFace Face { get; }
    IMeshFeature MeshFeature { get; }
    IMeshFeatureEntity MeshFeatureEntity { get; }
    IMeshFace NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
