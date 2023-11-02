using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface ICone
{
    IPoint BasePoint { get; set; }
    IUnitVector AxisVector { get; set; }
    double Radius { get; set; }
    double HalfAngle { get; set; }
    bool IsExpanding { get; set; }
    ISurfaceEvaluator Evaluator { get; }

    void GetConeData(ref List<double> BasePoint, ref List<double> AxisVector, out double Radius, out double HalfAngle,
        out bool IsExpanding);

    void PutConeData(ref List<double> BasePoint, ref List<double> AxisVector, double Radius, double HalfAngle,
        bool IsExpanding);

    ICone Copy();
}