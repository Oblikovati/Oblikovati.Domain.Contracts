using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface ILine2d
{
    IPoint2d RootPoint { get; set; }
    IUnitVector2d Direction { get; set; }
    ICurve2dEvaluator Evaluator { get; }
    void GetLineData(ref List<double> RootPoint, ref List<double> Direction);
    void PutLineData(ref List<double> RootPoint, ref List<double> Direction);
    double DistanceTo(IPoint2d Point);
    IObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance);
    ILine2d Copy();
}