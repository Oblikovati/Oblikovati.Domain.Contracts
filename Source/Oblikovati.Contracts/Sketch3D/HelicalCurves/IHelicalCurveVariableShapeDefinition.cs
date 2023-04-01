using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch3D.HelicalCurves;

public interface IHelicalCurveVariableShapeDefinition
{
    IHelicalCurve Parent { get; }
    bool Clockwise { get; set; }
    IPoint CurveStart { get; set; }
    IPoint AxisEndPoint { get; set; }
    HelicalShapeDefinitionTypeEnum ShapeDefinitionType { get; set; }
    IPoint AxisStartPoint { get; set; }
    IHelicalCurveShapeDefinitionRows ShapeDefinitionRows { get; }
    IHelicalCurveDefinition Copy();
}