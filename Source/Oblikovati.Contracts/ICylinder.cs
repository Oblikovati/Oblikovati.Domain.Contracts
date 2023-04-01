using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts;

public interface ICylinder
{
    IPoint BasePoint { get; set; }
    IUnitVector AxisVector { get; set; }
    double Radius { get; set; }
    ISurfaceEvaluator Evaluator { get; }
    void GetCylinderData(ref List<double> BasePoint, ref List<double> AxisVector, out double Radius);
    void PutCylinderData(ref List<double> BasePoint, ref List<double> AxisVector, double Radius);
    ICylinder Copy();
}