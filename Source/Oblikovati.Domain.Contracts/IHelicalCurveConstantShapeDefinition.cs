using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHelicalCurveConstantShapeDefinition
{

    IHelicalCurve Parent { get; }
    bool Clockwise { get; set; }
    IPoint CurveStart { get; set; }
    IPoint AxisEndPoint { get; set; }
    HelicalShapeDefinitionTypeEnum ShapeDefinitionType { get; set; }
    IPoint AxisStartPoint { get; set; }
    HelixEndTypeEnum HelixStartEndType { get; set; }
    HelixEndTypeEnum HelixEndEndType { get; set; }
    object HelixStartTransitionAngle { get; set; }
    object HelixEndTransitionAngle { get; set; }
    object HelixStartFlatAngle { get; set; }
    object HelixEndFlatAngle { get; set; }
    object Diameter { get; set; }
    object Pitch { get; set; }
    object Revolution { get; set; }
    object Height { get; set; }
    object Taper { get; set; }
    IHelicalCurveDefinition Copy();
}
