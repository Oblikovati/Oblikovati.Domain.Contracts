namespace Oblikovati.Domain.Contracts;

public interface IIRxBSplineSurface
{
    IIRxPoint PoleAtIndex { get; set; }
    IIRxSurfaceEvaluator Evaluator { get; }
    void GetBSplineInfo(out List<uint> pnOrder, out List<uint> pnNumPoles, out List<uint> pnNumKnots, out short pbIsRational, out List<short> pbIsPeriodic, out List<short> pbIsClosed, out short pbIsPlanar, out List<double> pPlaneVector);
    void GetBSplineData(uint nPoles, uint nKnotsU, uint nKnotsV, uint nWeights, out double pPoles, out double pKnotsU, out double pKnotsV, ref double pWeights);
    void PutBSplineInfoAndData(List<uint> pnOrder, uint nNumPolesUXV, uint nKnotsU, uint nKnotsV, uint nWeights, List<short> pbIsPeriodic, double pPoles, double pKnotsU, double pKnotsV, ref double pWeights);
}
