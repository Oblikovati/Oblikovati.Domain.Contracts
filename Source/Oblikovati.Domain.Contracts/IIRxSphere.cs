namespace Oblikovati.Domain.Contracts;

public interface IIRxSphere
{
    IIRxPoint CenterPoint { get; set; }
    double Radius { get; set; }
    IIRxSurfaceEvaluator Evaluator { get; }
    void GetSphereData(out List<double> pCenterPoint, out double pRadius);
    void PutSphereData(List<double> pCenterPoint, double Radius);
}
