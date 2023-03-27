using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISurfaceEvaluator
{
    IBox RangeBox { get; }
    IBox2d ParamRangeRect { get; }
    bool IsParamOnFace { get; }
    double Area { get; }
    int Continuity { get; }
    bool IsExtrudedShape { get; }
    bool IsRevolvedShape { get; }
    void GetParamAtPoint(ref List<double> Points, ref List<double> GuessParams, ref List<double> MaxDeviations, ref List<double> Params, ref List<SolutionNatureEnum> SolutionNatures);
    void GetPointAtParam(ref List<double> Params, ref List<double> Points);
    void GetNormal(ref List<double> Params, ref List<double> Normals);
    void GetTangents(ref List<double> Params, ref List<double> UTangents, ref List<double> VTangents);
    void GetCurvatures(ref List<double> Params, ref List<double> MaxTangents, ref List<double> MaxCurvatures, ref List<double> MinCurvatures);
    void GetFirstDerivatives(ref List<double> Params, ref List<double> UPartials, ref List<double> VPartials);
    void GetSecondDerivatives(ref List<double> Params, ref List<double> UUPartials, ref List<double> UVPartials, ref List<double> VVPartials);
    void GetThirdDerivatives(ref List<double> Params, ref List<double> UUUPartials, ref List<double> VVVPartials);
    void GetParamAnomaly(ref List<double> PeriodicityU, ref List<double> PeriodicityV, out int NumEndSingularitiesU, ref List<double> SingularitiesU, out int NumEndSingularitiesV, ref List<double> SingularitiesV, ref List<bool> UnboundedParams);
    object Get3dCurveFrom2dCurve(object Curve2d);
    IObjectCollection GetIsoCurve(double Parameter, bool UDirection);
    void GetNormalAtPoint(ref List<double> Points, ref List<double> Normals);
}
