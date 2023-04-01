using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPublicationMeshEdge
{
    IAttributeSets AttributeSets { get; }
    ICurveEvaluator Evaluator { get; }
    IEdge Edge { get; }
    object Geometry { get; }
    CurveTypeEnum GeometryType { get; }
    IPublicationComponent Component { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}