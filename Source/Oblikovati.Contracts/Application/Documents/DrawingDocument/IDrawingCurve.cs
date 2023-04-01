using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.ClientGraphics.DrawingView;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

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