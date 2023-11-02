using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IEllipticalCylinder
{
    IPoint BasePoint { get; set; }
    IUnitVector AxisVector { get; set; }
    IVector MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    ISurfaceEvaluator Evaluator { get; }

    void GetEllipticalCylinderData(ref List<double> BasePoint, ref List<double> AxisVector, ref List<double> MajorAxis,
        out double MinorMajorRatio);

    void PutEllipticalCylinderData(ref List<double> BasePoint, ref List<double> AxisVector, ref List<double> MajorAxis,
        double MinorMajorRatio);

    IEllipticalCylinder Copy();
}