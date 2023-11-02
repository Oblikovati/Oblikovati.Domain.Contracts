using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.NotClassified;

public interface ISphere
{
    IPoint CenterPoint { get; set; }
    double Radius { get; set; }
    ISurfaceEvaluator Evaluator { get; }
    void GetSphereData(ref List<double> CenterPoint, out double Radius);
    void PutSphereData(ref List<double> CenterPoint, double Radius);
    ISphere Copy();
}