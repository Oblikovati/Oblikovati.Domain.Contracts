namespace Oblikovati.Domain.Contracts;

public interface IIRxPlane
{
    IIRxPoint RootPoint { get; set; }
    IIRxUnitVector Normal { get; set; }
    IIRxSurfaceEvaluator Evaluator { get; }
    void GetPlaneData(out List<double> pRootPoint, out List<double> pNormal);
    void PutPlaneData(List<double> pRootPoint, List<double> pNormal);
}
