using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MeshFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IMeshEdge
{
    object Geometry { get; }
    CurveTypeEnum GeometryType { get; }
    ICurveEvaluator Evaluator { get; }
    IEdge Edge { get; }
    IMeshFeature MeshFeature { get; }
    IMeshFeatureEntity MeshFeatureEntity { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}