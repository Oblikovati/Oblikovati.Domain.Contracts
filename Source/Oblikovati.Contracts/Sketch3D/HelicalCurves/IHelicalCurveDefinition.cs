using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch3D.HelicalCurves;

public interface IHelicalCurveDefinition
{
    IHelicalCurve Parent { get; }
    bool Clockwise { get; set; }
    IPoint CurveStart { get; set; }
    IPoint AxisEndPoint { get; set; }
    HelicalShapeDefinitionTypeEnum ShapeDefinitionType { get; set; }
    IPoint AxisStartPoint { get; set; }
    IHelicalCurveDefinition Copy();
}