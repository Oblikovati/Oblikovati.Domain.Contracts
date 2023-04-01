using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts;

public interface IEdgeUse
{
    ISurfaceBody Parent { get; }
    IEdge Edge { get; }
    IEdgeLoop EdgeLoop { get; }
    IWire Wire { get; }
    IEdgeUse Partner { get; }
    IEdgeUse Next { get; }
    IEdgeUse Previous { get; }
    bool IsOpposedToEdge { get; }
    bool IsParamReversed { get; }
    Curve2dTypeEnum CurveType { get; }
    object Curve { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    ICurve2dEvaluator Evaluator { get; }
    int TransientKey { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}