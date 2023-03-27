using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPublicationMeshFace
{
    IAttributeSets AttributeSets { get; }
    ISurfaceEvaluator Evaluator { get; }
    IFace Face { get; }
    object Geometry { get; }
    SurfaceTypeEnum SurfaceType { get; }
    IPublicationComponent Component { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
