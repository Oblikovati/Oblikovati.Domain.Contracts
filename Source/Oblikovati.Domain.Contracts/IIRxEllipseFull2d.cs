namespace Oblikovati.Domain.Contracts;

public interface IIRxEllipseFull2d
{
    IIRxPoint2d Center { get; set; }
    IIRxVector2d MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    IIRxCurve2dEvaluator Evaluator { get; }
    void GetEllipseFullData(out List<double> pCenter, out List<double> pMajorAxis, out double pMinorMajorRatio);
    void PutEllipseFullData(List<double> pCenter, List<double> pMajorAxis, double MinorMajorRatio);
}
