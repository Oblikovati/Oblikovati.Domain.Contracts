using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMoveFaceDefinition
{

    IMoveFaceFeature Parent { get; }
    IFaceCollection Faces { get; set; }
    MoveFaceTypeEnum MoveFaceType { get; }
    object MoveFaceTypeDefinition { get; }
    bool AutomaticBlending { get; set; }
    IMoveFaceDefinition Copy();
    void SetDirectionAndDistanceMoveType(object Distance, object Direction, bool DirectionReversed);
    void SetFreeMoveType(IMatrix Transformation);
    void SetPlanarMoveType(object PointOne, object PointTwo, object Plane);
}
