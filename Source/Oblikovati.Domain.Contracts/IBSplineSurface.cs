namespace Oblikovati.Domain.Contracts;

public interface IBSplineSurface
{
    IPoint PoleAtIndex { get; set; }
    ISurfaceEvaluator Evaluator { get; }
    void GetBSplineInfo(ref List<int> Order, ref List<int> NumPoles, ref List<int> NumKnots, out bool IsRational, ref List<bool> IsPeriodic, ref List<bool> IsClosed, out bool IsPlanar, ref List<double> PlaneVector);
    void GetBSplineData(ref List<double> Poles, ref List<double> KnotsU, ref List<double> KnotsV, ref List<double> Weights);
    void PutBSplineInfoAndData(ref List<int> Order, ref List<double> Poles, ref List<double> KnotsU, ref List<double> KnotsV, ref List<double> Weights, ref List<bool> IsPeriodic);
    IBSplineSurface Copy();
}
