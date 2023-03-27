namespace Oblikovati.Domain.Contracts;

public interface IIRxCylinder
{
    IIRxPoint BasePoint { get; set; }
    IIRxUnitVector AxisVector { get; set; }
    double Radius { get; set; }
    IIRxSurfaceEvaluator Evaluator { get; }
    void GetCylinderData(out List<double> pBasePoint, out List<double> pAxisVector, out double pRadius);
    void PutCylinderData(List<double> pBasePoint, List<double> pAxisVector, double Radius);
}
