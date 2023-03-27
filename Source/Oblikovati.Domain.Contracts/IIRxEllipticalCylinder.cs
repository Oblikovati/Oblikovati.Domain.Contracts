namespace Oblikovati.Domain.Contracts;

public interface IIRxEllipticalCylinder
{
    IIRxPoint BasePoint { get; set; }
    IIRxUnitVector AxisVector { get; set; }
    IIRxVector MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    IIRxSurfaceEvaluator Evaluator { get; }
    void GetEllipticalCylinderData(out List<double> pBasePoint, out List<double> pAxisVector, out List<double> pMajorAxis, out double pMinorMajorRatio);
    void PutEllipticalCylinderData(List<double> pBasePoint, List<double> pAxisVector, List<double> pMajorAxis, double MinorMajorRatio);
}
