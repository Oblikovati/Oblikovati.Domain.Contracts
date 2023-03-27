namespace Oblikovati.Domain.Contracts;

public interface IIRxBSplineCurve
{
    IIRxPoint PoleAtIndex { get; set; }
    IIRxCurveEvaluator Evaluator { get; }
    void GetBSplineInfo(out uint pnOrder, out uint pnNumPoles, out uint pnNumKnots, out short pbIsRational, out short pbIsPeriodic, out short pbIsClosed, out short pbIsPlanar, out List<double> pPlaneVector);
    void GetBSplineData(uint nPoles, uint nKnots, uint nWeights, out double pPoles, out double pKnots, ref double pWeights);
    void PutBSplineInfoAndData(uint nOrder, uint nPoles, uint nKnots, uint nWeights, short bIsPeriodic, double pPoles, double pKnots, ref double pWeights);
}
