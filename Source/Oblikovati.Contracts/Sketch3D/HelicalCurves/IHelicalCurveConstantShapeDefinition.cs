using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch3D.HelicalCurves;

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