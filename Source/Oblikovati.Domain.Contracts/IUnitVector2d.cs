namespace Oblikovati.Domain.Contracts;

public interface IUnitVector2d
{
    double X { get; set; }
    double Y { get; set; }
    void GetUnitVectorData(ref List<double> Coords);
    void PutUnitVectorData(ref List<double> Coords);
    void TransformBy(IMatrix2d Value);
    double AngleTo(IUnitVector2d Vector);
    bool IsParallelTo(IUnitVector2d Vector, double Tolerance);
    bool IsPerpendicularTo(IUnitVector2d Vector, double Tolerance);
    bool IsEqualTo(IUnitVector2d Vector, double Tolerance);
    double DotProduct(IUnitVector2d Vector);
    IVector2d AsVector();
    IUnitVector2d Copy();
}
