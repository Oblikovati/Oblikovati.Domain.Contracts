namespace Oblikovati.Domain.Contracts;

public interface IIRxEdgeUse
{
    IIRxEdge Edge { get; }
    IIRxEdgeLoop EdgeLoop { get; }
    IIRxEdgeUse Partner { get; }
    IIRxEdgeUse Next { get; }
    IIRxEdgeUse Previous { get; }
    short IsOpposedToEdge { get; }
    short IsParamReversed { get; }
    Guid CurveType { get; }
    IntPtr Curve { get; }
    uint GeometryForm { get; }
    IIRxCurve2dEvaluator Evaluator { get; }
}
