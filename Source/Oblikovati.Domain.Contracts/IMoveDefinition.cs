namespace Oblikovati.Domain.Contracts;

public interface IMoveDefinition
{

    IMoveOperation MoveOperation { get; }
    int MoveOperationCount { get; }
    IMoveFeature Parent { get; }
    IObjectCollection SurfaceBodies { get; set; }
    IFreeDragMoveOperation AddFreeDrag(object XOffset, object YOffset, object ZOffset);
    IMoveAlongRayMoveOperation AddMoveAlongRay(object DirectionEntity, bool UseNaturalEntityDirection, object Offset);
    IRotateAboutLineMoveOperation AddRotateAboutAxis(object AxisEntity, bool UseNaturalAxisDirection, object Angle);
    IMoveDefinition Copy();
}
