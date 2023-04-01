using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

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