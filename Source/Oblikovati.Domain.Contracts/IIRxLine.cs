namespace Oblikovati.Domain.Contracts;

public interface IIRxLine
{
    IIRxPoint RootPoint { get; set; }
    IIRxUnitVector Direction { get; set; }
    IIRxCurveEvaluator Evaluator { get; }
    void GetLineData(out List<double> pRootPoint, out List<double> pDirection);
    void PutLineData(List<double> pRootPoint, List<double> pDirection);
}
