using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMeshFace
{

    object Geometry { get; }
    SurfaceTypeEnum SurfaceType { get; }
    ISurfaceEvaluator Evaluator { get; }
    IFace Face { get; }
    IMeshFeature MeshFeature { get; }
    IMeshFeatureEntity MeshFeatureEntity { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
