namespace Oblikovati.Domain.Contracts;

public interface IIRxCircle
{
    IIRxPoint Center { get; set; }
    IIRxUnitVector Normal { get; set; }
    double Radius { get; set; }
    IIRxCurveEvaluator Evaluator { get; }
    void GetCircleData(out List<double> pCenter, out List<double> pNormal, out double pRadius);
    void PutCircleData(List<double> pCenter, List<double> pNormal, double Radius);
}
