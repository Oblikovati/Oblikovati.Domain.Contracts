using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MoveFaceFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

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