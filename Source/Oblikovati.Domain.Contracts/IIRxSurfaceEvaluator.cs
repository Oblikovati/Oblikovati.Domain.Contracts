using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxSurfaceEvaluator
{
    IIRxBox RangeBox { get; }
    IIRxBox2d ParamRangeRect { get; }
    short IsParamOnFace { get; }
    double Area { get; }
    uint Continuity { get; }
    short IsExtrudedShape { get; }
    short IsRevolvedShape { get; }
    void GetParamAtPoint(uint nPoints, double pPoints, ref double pGuessParams, ref double pMaxDeviations, ref double pParams, ref SolutionNatureEnum pSolTypes);
    void GetPointAtParam(uint nParams, double pParams, out double pPoints);
    void GetNormal(uint nParams, double pParams, out double pNormals);
    void GetTangents(uint nParams, double pParams, out double pUTangents, out double pVTangents);
    void GetCurvatures(uint nParams, double pParams, ref double pMaxTangents, ref double pMaxCurvatures, ref double pMinCurvatures);
    void GetDerivatives(uint nParams, double pParams, ref double pUPartials, ref double pVPartials, ref double pUUPartials, ref double pUVPartials, ref double pVVPartials, ref double pUUUPartials, ref double pVVVPartials);
    void GetParamAnomaly(out List<double> pPeriodicityU, out List<double> pPeriodicityV, out uint pnEndSingularityU, out List<double> pSingularityU, out uint pnEndSingularityV, out List<double> pSingularityV, out List<short> pUnboundedParam);
}
