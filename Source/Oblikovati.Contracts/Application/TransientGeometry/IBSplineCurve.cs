using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IBSplineCurve
{
    IPoint PoleAtIndex { get; set; }
    ICurveEvaluator Evaluator { get; }

    void GetBSplineInfo(out int Order, out int NumPoles, out int NumKnots, out bool IsRational, out bool IsPeriodic,
        out bool IsClosed, out bool IsPlanar, ref List<double> PlaneVector);

    void GetBSplineData(ref List<double> Poles, ref List<double> Knots, ref List<double> Weights);

    void PutBSplineInfoAndData(int Order, ref List<double> Poles, ref List<double> Knots, ref List<double> Weights,
        bool IsPeriodic);

    IBSplineCurve Copy();
    IBSplineCurve ExtractPartial(double StartParam, double EndParam);
    void Split(double SplitParam, out IBSplineCurve CurveOne, out IBSplineCurve CurveTwo);
}