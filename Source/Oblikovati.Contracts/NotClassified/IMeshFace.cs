using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MeshFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

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