namespace Oblikovati.Domain.Contracts;

public interface IIRxEllipticalCone
{
    IIRxPoint BasePoint { get; set; }
    IIRxUnitVector AxisVector { get; set; }
    IIRxVector MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    double HalfAngle { get; set; }
    short IsExpanding { get; set; }
    IIRxSurfaceEvaluator Evaluator { get; }
    void GetEllipticalConeData(out List<double> pBasePoint, out List<double> pAxisVector, out List<double> pMajorAxis, out double pMinorMajorRatio, out double pHalfAngle, out short pbIsExpanding);
    void PutEllipticalConeData(List<double> pBasePoint, List<double> pAxisVector, List<double> pMajorAxis, double MinorMajorRatio, double HalfAngle, short bIsExpanding);
}
