using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IBSplineCurve2d
{
    IPoint2d PoleAtIndex { get; set; }
    ICurve2dEvaluator Evaluator { get; }

    void GetBSplineInfo(out int Order, out int NumPoles, out int NumKnots, out bool IsRational, out bool IsPeriodic,
        out bool IsClosed);

    void GetBSplineData(ref List<double> Poles, ref List<double> Knots, ref List<double> Weights);

    void PutBSplineInfoAndData(int Order, ref List<double> Poles, ref List<double> Knots, ref List<double> Weights,
        bool IsPeriodic);

    IBSplineCurve2d Copy();
    IBSplineCurve2d ExtractPartial(double StartParam, double EndParam);
    void Split(double SplitParam, out IBSplineCurve2d CurveOne, out IBSplineCurve2d CurveTwo);
}