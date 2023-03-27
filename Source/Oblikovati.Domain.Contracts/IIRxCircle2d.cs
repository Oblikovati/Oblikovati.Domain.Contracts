namespace Oblikovati.Domain.Contracts;

public interface IIRxCircle2d
{
    IIRxPoint2d Center { get; set; }
    double Radius { get; set; }
    IIRxCurve2dEvaluator Evaluator { get; }
    void GetCircleData(out List<double> pCenter, out double pRadius);
    void PutCircleData(List<double> pCenter, double Radius);
}
