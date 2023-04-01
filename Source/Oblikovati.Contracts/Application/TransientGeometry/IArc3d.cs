using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IArc3d
{
    IPoint Center { get; set; }
    IUnitVector Normal { get; set; }
    IUnitVector ReferenceVector { get; set; }
    double Radius { get; set; }
    double StartAngle { get; set; }
    double SweepAngle { get; set; }
    IPoint StartPoint { get; }
    IPoint EndPoint { get; }
    ICurveEvaluator Evaluator { get; }

    void GetArcData(ref List<double> Center, ref List<double> AxisVector, ref List<double> RefVector, out double Radius,
        out double StartAngle, out double SweepAngle);

    void PutArcData(ref List<double> Center, ref List<double> AxisVector, ref List<double> RefVector, double Radius,
        double StartAngle, double SweepAngle);

    IArc3d Copy();
}