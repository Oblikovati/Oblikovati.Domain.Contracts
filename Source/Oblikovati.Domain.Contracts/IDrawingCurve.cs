using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingCurve
{

    IDrawingView Parent { get; }
    object ModelGeometry { get; }
    CurveTypeEnum CurveType { get; }
    ICurve2dEvaluator Evaluator2D { get; }
    ICurveEvaluator Evaluator3D { get; }
    IPoint2d StartPoint { get; }
    IPoint2d EndPoint { get; }
    IPoint2d CenterPoint { get; }
    IPoint2d MidPoint { get; }
    IDrawingCurveSegments Segments { get; }
    IColor OverrideColor { get; set; }
    IColor Color { get; set; }
    double LineWeight { get; set; }
    LineTypeEnum LineType { get; set; }
    Curve2dTypeEnum ProjectedCurveType { get; }
    DrawingEdgeTypeEnum EdgeType { get; }
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
