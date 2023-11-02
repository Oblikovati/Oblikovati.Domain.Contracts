using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface ILineSegment
{
    IPoint StartPoint { get; set; }
    IPoint EndPoint { get; set; }
    IPoint MidPoint { get; }
    IUnitVector Direction { get; }
    ICurveEvaluator Evaluator { get; }
    void GetLineSegmentData(ref List<double> StartPoint, ref List<double> EndPoint);
    void PutLineSegmentData(ref List<double> StartPoint, ref List<double> EndPoint);
    double DistanceTo(IPoint Point);
    IObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance);
    IObjectsEnumerator IntersectWithSurface(object Surface, double Tolerance);
    ILineSegment Copy();
}