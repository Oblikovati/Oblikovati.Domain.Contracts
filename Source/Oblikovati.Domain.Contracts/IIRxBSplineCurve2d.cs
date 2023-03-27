namespace Oblikovati.Domain.Contracts;

public interface IIRxBSplineCurve2d
{
    IIRxPoint2d PoleAtIndex { get; set; }
    IIRxCurve2dEvaluator Evaluator { get; }
    void GetBSplineInfo(out uint pnOrder, out uint pnNumPoles, out uint pnNumKnots, out short pIsRational, out short pIsPeriodic, out short pIsClosed);
    void GetBSplineData(uint nPoles, uint nKnots, uint nWeights, out double pPoles, out double pKnots, ref double pWeights);
    void PutBSplineInfoAndData(uint nOrder, uint nPoles, uint nKnots, uint nWeights, short bIsPeriodic, double pPoles, double pKnots, ref double pWeights);
}
