namespace Oblikovati.Domain.Contracts;

public interface IPlane
{
    IPoint RootPoint { get; set; }
    IUnitVector Normal { get; set; }
    ISurfaceEvaluator Evaluator { get; }
    bool IsCoplanarTo { get; }
    bool IsParallelTo { get; }
    bool IsPerpendicularTo { get; }
    void GetPlaneData(ref List<double> RootPoint, ref List<double> Normal);
    void PutPlaneData(ref List<double> RootPoint, ref List<double> Normal);
    IPoint IntersectWithLine(object Line, double Tolerance);
    ILine IntersectWithPlane(IPlane Plane, double Tolerance);
    double DistanceTo(IPoint Point);
    IObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance);
    IObjectsEnumerator IntersectWithSurface(object Surface, double Tolerance);
    IPlane Copy();
}
