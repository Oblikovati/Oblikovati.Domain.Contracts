namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IArc2d
{
    IPoint2d Center { get; set; }
    double Radius { get; set; }
    double StartAngle { get; set; }
    double SweepAngle { get; set; }
    IPoint2d StartPoint { get; }
    IPoint2d EndPoint { get; }
    ICurve2dEvaluator Evaluator { get; }
    void GetArcData(ref List<double> Center, out double Radius, out double StartAngle, out double SweepAngle);
    void PutArcData(ref List<double> Center, double Radius, double StartAngle, double SweepAngle);
    IArc2d Copy();
}