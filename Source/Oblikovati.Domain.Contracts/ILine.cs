namespace Oblikovati.Domain.Contracts;

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
