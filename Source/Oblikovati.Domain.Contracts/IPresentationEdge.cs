using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPresentationEdge
{

    ICurveEvaluator Evaluator { get; }
    IPresentationFacesEnumerator Faces { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    CurveTypeEnum GeometryType { get; }
    bool IsParamReversed { get; }
    IPoint PointOnEdge { get; }
    IPresentationVertex StartVertex { get; }
    IPresentationVertex StopVertex { get; }
    IPresentationBody Parent { get; }
    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount, out List<double> VertexCoordinates, out List<int> VertexIndices);
    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out List<double> VertexCoordinates, out int PolylineCount, out List<int> PolylineLengths);
    void GetExistingStrokeTolerances(out int ToleranceCount, out List<double> ExistingTolerances);
    void CalculateStrokesWithOptions(double ChordalTolerance, INameValueMap Options, out int VertexCount, out List<double> VertexCoordinates, out int PolylineCount, out List<int> PolylineLengths);
}
