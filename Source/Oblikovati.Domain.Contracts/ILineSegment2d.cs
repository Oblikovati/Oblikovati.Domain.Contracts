namespace Oblikovati.Domain.Contracts;

public interface ILineSegment2d
{
    IPoint2d StartPoint { get; set; }
    IPoint2d EndPoint { get; set; }
    IPoint2d MidPoint { get; }
    IUnitVector2d Direction { get; }
    ICurve2dEvaluator Evaluator { get; }
    void GetLineSegmentData(ref List<double> StartPoint, ref List<double> EndPoint);
    void PutLineSegmentData(ref List<double> StartPoint, ref List<double> EndPoint);
    double DistanceTo(IPoint2d Point);
    IObjectsEnumerator IntersectWithCurve(object Curve, double Tolerance);
    ILineSegment2d Copy();
}
