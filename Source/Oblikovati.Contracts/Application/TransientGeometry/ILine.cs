using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface ILine
{
    IPoint RootPoint { get; set; }
    IUnitVector Direction { get; set; }
    ICurveEvaluator Evaluator { get; }
    bool IsColinearTo { get; }
    void GetLineData(ref List<double> RootPoint, ref List<double> Direction);
    void PutLineData(ref List<double> RootPoint, ref List<double> Direction);
    double DistanceTo(IPoint Point);
    IObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance);
    IObjectsEnumerator IntersectWithSurface(object Surface, double Tolerance);
    ILine Copy();
}