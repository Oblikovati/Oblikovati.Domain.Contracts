namespace Oblikovati.Domain.Contracts;

public interface ICircle
{
    IPoint Center { get; set; }
    IUnitVector Normal { get; set; }
    double Radius { get; set; }
    ICurveEvaluator Evaluator { get; }
    void GetCircleData(ref List<double> Center, ref List<double> AxisVector, out double Radius);
    void PutCircleData(ref List<double> Center, ref List<double> AxisVector, double Radius);
    ICircle Copy();
}
