using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IEllipticalArc2d
{
    IPoint2d Center { get; set; }
    IUnitVector2d MajorAxis { get; set; }
    double MajorRadius { get; set; }
    double MinorRadius { get; set; }
    double StartAngle { get; set; }
    double SweepAngle { get; set; }
    IPoint2d StartPoint { get; }
    IPoint2d EndPoint { get; }
    ICurve2dEvaluator Evaluator { get; }

    void GetEllipticalArcData(ref List<double> Center, ref List<double> MajorAxis, out double MajorRadius,
        out double MinorRadius, out double StartAngle, out double SweepAngle);

    void PutEllipticalArcData(ref List<double> Center, ref List<double> MajorAxis, double MajorRadius,
        double MinorRadius, double StartAngle, double SweepAngle);

    IEllipticalArc2d Copy();
}