using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MeshFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IMeshEdgeProxy
{
    object Geometry { get; }
    CurveTypeEnum GeometryType { get; }
    ICurveEvaluator Evaluator { get; }
    IEdge Edge { get; }
    IMeshFeature MeshFeature { get; }
    IMeshFeatureEntity MeshFeatureEntity { get; }
    IMeshEdge NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}