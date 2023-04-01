using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IPoint2d
{
    double X { get; set; }
    double Y { get; set; }
    void GetPointData(ref List<double> Coords);
    void PutPointData(ref List<double> Coords);
    double DistanceTo(IPoint2d Point);
    void TransformBy(IMatrix2d Matrix);
    void TranslateBy(IVector2d Vector);
    IVector2d VectorTo(IPoint2d Point);
    bool IsEqualTo(IPoint2d Point, double Tolerance);
    IPoint2d Copy();
}