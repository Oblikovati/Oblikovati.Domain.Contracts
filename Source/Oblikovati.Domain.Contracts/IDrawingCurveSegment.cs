using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingCurveSegment
{

    IDrawingCurve Parent { get; }
    ILayer Layer { get; set; }
    bool Visible { get; set; }
    bool HiddenLine { get; }
    IPoint2d StartPoint { get; }
    IPoint2d EndPoint { get; }
    object Geometry { get; }
    Curve2dTypeEnum GeometryType { get; }
}
