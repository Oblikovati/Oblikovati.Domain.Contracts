using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
