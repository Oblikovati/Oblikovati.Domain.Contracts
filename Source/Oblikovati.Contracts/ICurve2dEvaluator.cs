using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface ICurve2dEvaluator
{
    IBox2d RangeBox { get; }
    int Continuity { get; }
    void GetEndPoints(ref List<double> StartPoint, ref List<double> EndPoint);
    void GetParamExtents(out double MinParam, out double MaxParam);

    void GetParamAtPoint(ref List<double> Points, ref List<double> GuessParams, ref List<double> MaxDeviations,
        ref List<double> Params, ref List<SolutionNatureEnum> SolTypes);

    void GetPointAtParam(ref List<double> Params, ref List<double> Points);
    void GetTangent(ref List<double> Params, ref List<double> Tangents);
    void GetCurvature(ref List<double> Params, ref List<double> Directions, ref List<double> Curvatures);
    void GetFirstDerivatives(ref List<double> Params, ref List<double> FirstDerivs);
    void GetSecondDerivatives(ref List<double> Params, ref List<double> SecondDerivs);
    void GetThirdDerivatives(ref List<double> Params, ref List<double> ThirdDerivs);
    void GetParamAtLength(double FromParam, double Length, out double Param);
    void GetLengthAtParam(double FromParam, double ToParam, out double Length);
    void GetParamAnomaly(ref List<double> Periodicity, out bool IsSingular, out bool UnboundedParam);

    void GetStrokes(double FromParam, double ToParam, double Tolerance, out int VertexCount,
        out List<double> VertexCoordinates);
}