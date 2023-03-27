namespace Oblikovati.Domain.Contracts;

public interface IIRxTorus
{
    IIRxPoint CenterPoint { get; set; }
    IIRxUnitVector AxisVector { get; set; }
    double MajorRadius { get; set; }
    double MinorRadius { get; set; }
    IIRxSurfaceEvaluator Evaluator { get; }
    void GetTorusData(out List<double> pCenterPoint, out List<double> pAxisVector, out double pMajorRadius, out double pMinorRadius);
    void PutTorusData(List<double> pCenterPoint, List<double> pAxisVector, double MajorRadius, double MinorRadius);
}
