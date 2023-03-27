namespace Oblikovati.Domain.Contracts;

public interface IIRxCone
{
    IIRxPoint BasePoint { get; set; }
    IIRxUnitVector AxisVector { get; set; }
    double Radius { get; set; }
    double HalfAngle { get; set; }
    short IsExpanding { get; set; }
    IIRxSurfaceEvaluator Evaluator { get; }
    void GetConeData(out List<double> pBasePoint, out List<double> pAxisVector, out double pRadius, out double pHalfAngle, out short pbIsExpanding);
    void PutConeData(List<double> pBasePoint, List<double> pAxisVector, double Radius, double HalfAngle, short bIsExpanding);
}
