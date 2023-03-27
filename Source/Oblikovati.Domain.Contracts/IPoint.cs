namespace Oblikovati.Domain.Contracts;

public interface IPoint
{
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }
    void GetPointData(ref List<double> Coords);
    void PutPointData(ref List<double> Coords);
    void TransformBy(IMatrix Matrix);
    void TranslateBy(IVector Vector);
    double DistanceTo(IPoint Point);
    IVector VectorTo(IPoint Point);
    bool IsEqualTo(IPoint Point, double Tolerance);
    IPoint Copy();
}
