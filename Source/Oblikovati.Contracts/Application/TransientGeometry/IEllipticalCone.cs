using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IEllipticalCone
{
    IPoint BasePoint { get; set; }
    IUnitVector AxisVector { get; set; }
    IVector MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    double HalfAngle { get; set; }
    bool IsExpanding { get; set; }
    ISurfaceEvaluator Evaluator { get; }

    void GetEllipticalConeData(ref List<double> BasePoint, ref List<double> AxisVector, ref List<double> MajorAxis,
        out double MinorMajorRatio, out double HalfAngle, out bool IsExpanding);

    void PutEllipticalConeData(ref List<double> BasePoint, ref List<double> AxisVector, ref List<double> MajorAxis,
        double MinorMajorRatio, double HalfAngle, bool IsExpanding);

    IEllipticalCone Copy();
}