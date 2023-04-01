using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

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