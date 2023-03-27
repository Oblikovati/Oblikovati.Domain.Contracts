namespace Oblikovati.Domain.Contracts;

public interface IIRxEdge
{
    IIRxVertex StartVertex { get; }
    IIRxVertex StopVertex { get; }
    IIRxEnumEdgeUses EdgeUses { get; }
    IIRxEnumFaces Faces { get; }
    short IsParamReversed { get; }
    Guid CurveType { get; }
    IntPtr Curve { get; }
    uint GeometryForm { get; }
    IIRxCurveEvaluator Evaluator { get; }
}
