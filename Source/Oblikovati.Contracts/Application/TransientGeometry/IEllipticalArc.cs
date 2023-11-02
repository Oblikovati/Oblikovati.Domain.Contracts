using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IEllipticalArc
{
    IPoint Center { get; set; }
    IUnitVector MajorAxis { get; set; }
    IUnitVector MinorAxis { get; set; }
    double MajorRadius { get; set; }
    double MinorRadius { get; set; }
    double StartAngle { get; set; }
    double SweepAngle { get; set; }
    IPoint StartPoint { get; }
    IPoint EndPoint { get; }
    ICurveEvaluator Evaluator { get; }

    void GetEllipticalArcData(ref List<double> Center, ref List<double> MajorAxis, ref List<double> MinorAxis,
        out double MajorRadius, out double MinorRadius, out double StartAngle, out double SweepAngle);

    void PutEllipticalArcData(ref List<double> Center, ref List<double> MajorAxis, ref List<double> MinorAxis,
        double MajorRadius, double MinorRadius, double StartAngle, double SweepAngle);

    IEllipticalArc Copy();
}