using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxCurveEvaluator
{
    IIRxBox RangeBox { get; }
    uint Continuity { get; }
    void GetEndPoints(out List<double> pStartPoint, out List<double> pEndPoint);
    void GetParamExtents(out double pMinParam, out double pMaxParam);
    void GetParamAtPoint(uint nPoints, double pPoints, ref double pGuessParams, ref double pMaxDeviations, ref double pParams, ref SolutionNatureEnum pSolTypes);
    void GetPointAtParam(uint nParams, double pParams, out double pPoints);
    void GetTangent(uint nParams, double pParams, out double pTangents);
    void GetCurvature(uint nParams, double pParams, ref double pDirections, ref double pCurvatures);
    void GetDerivatives(uint nParams, double pParams, ref double pFirstDerivs, ref double pSecondDerivs, ref double pThirdDerivs);
    void GetParamAtLength(double FromParam, double Length, out double pParam);
    void GetLengthAtParam(double FromParam, double ToParam, out double pLength);
    void GetParamAnomaly(out List<double> pPeriodicity, out short pIsSingular, out short pUnboundedParam);
    void GetStrokes(double FromParam, double ToParam, double Tolerance, out uint nVertexCount, out IntPtr ppVertexCoordinates);
}
