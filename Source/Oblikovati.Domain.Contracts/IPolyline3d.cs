namespace Oblikovati.Domain.Contracts;

public interface IPolyline3d
{
    ICurveEvaluator Evaluator { get; }
    IPoint PointAtIndex { get; set; }
    int PointCount { get; }
    void GetPoints(out List<double> Points);
    void PutPoints(object Points);
    IPolyline3d Copy();
}
