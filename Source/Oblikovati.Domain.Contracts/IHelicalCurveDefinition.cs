using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
