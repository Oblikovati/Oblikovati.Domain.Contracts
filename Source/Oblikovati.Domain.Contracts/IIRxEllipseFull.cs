namespace Oblikovati.Domain.Contracts;

public interface IIRxEllipseFull
{
    IIRxPoint Center { get; set; }
    IIRxUnitVector Normal { get; set; }
    IIRxVector MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    IIRxCurveEvaluator Evaluator { get; }
    void GetEllipseFullData(out List<double> pCenter, out List<double> pNormal, out List<double> pMajorAxis, out double pMinorMajorRatio);
    void PutEllipseFullData(List<double> pCenter, List<double> pNormal, List<double> pMajorAxis, double MinorMajorRatio);
}
