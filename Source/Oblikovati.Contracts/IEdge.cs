using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts;

public interface IEdge
{
    ISurfaceBody Parent { get; }
    IWire Wire { get; }
    IVertex StartVertex { get; }
    IVertex StopVertex { get; }
    IEdgeUses EdgeUses { get; }
    IFaces Faces { get; }
    bool IsParamReversed { get; }
    CurveTypeEnum GeometryType { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    ICurveEvaluator Evaluator { get; }
    IAttributeSets AttributeSets { get; }
    IEdgeCollection TangentiallyConnectedEdges { get; }
    int TransientKey { get; }
    IPoint PointOnEdge { get; }
    bool IsTolerant { get; }
    double Tolerance { get; }
    int AssociativeID { get; set; }
    CurveTypeEnum CurveType { get; }
    object Curve { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);

    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount,
        out List<double> VertexCoordinates, out List<int> VertexIndices);

    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out List<double> VertexCoordinates,
        out int PolylineCount, out List<int> PolylineLengths);

    void GetExistingStrokeTolerances(out int ToleranceCount, out List<double> ExistingTolerances);
    IEdge GetSourceEdge(bool GetLeafSource);
    IPoint GetClosestPointTo(IPoint InputPoint);

    void CalculateStrokesWithOptions(double ChordalTolerance, INameValueMap Options, out int VertexCount,
        out List<double> VertexCoordinates, out int PolylineCount, out List<int> PolylineLengths);
}