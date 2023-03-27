namespace Oblikovati.Domain.Contracts;

public interface IEllipseFull
{
    IPoint Center { get; set; }
    IUnitVector Normal { get; set; }
    IVector MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    ICurveEvaluator Evaluator { get; }
    void GetEllipseFullData(ref List<double> Center, ref List<double> AxisVector, ref List<double> MajorAxis, out double MinorMajorRatio);
    void PutEllipseFullData(ref List<double> Center, ref List<double> AxisVector, ref List<double> MajorAxis, double MinorMajorRatio);
    IEllipseFull Copy();
}
