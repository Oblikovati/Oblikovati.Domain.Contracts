namespace Oblikovati.Domain.Contracts;

public interface IIRxLine2d
{
    IIRxPoint2d RootPoint { get; set; }
    IIRxUnitVector2d Direction { get; set; }
    IIRxCurve2dEvaluator Evaluator { get; }
    void GetLineData(out List<double> pRootPoint, out List<double> pDirection);
    void PutLineData(List<double> pRootPoint, List<double> pDirection);
}
