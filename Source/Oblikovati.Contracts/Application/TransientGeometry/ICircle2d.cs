using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface ICircle2d
{
    IPoint2d Center { get; set; }
    double Radius { get; set; }
    ICurve2dEvaluator Evaluator { get; }
    void GetCircleData(ref List<double> Center, out double Radius);
    void PutCircleData(ref List<double> Center, double Radius);
    ICircle2d Copy();
}