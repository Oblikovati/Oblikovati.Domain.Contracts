namespace Oblikovati.Contracts.Application.TransientObjects.Math;

public interface IVector2d
{
    double X { get; set; }
    double Y { get; set; }
    double Length { get; }
    void GetVectorData(ref List<double> Coords);
    void PutVectorData(ref List<double> Coords);
    void TransformBy(IMatrix2d Value);
    void ScaleBy(double Value);
    void AddVector(IVector2d Value);
    void SubtractVector(IVector2d Value);
    double AngleTo(IVector2d Vector);
    void Normalize();
    bool IsParallelTo(IVector2d Vector, double Tolerance);
    bool IsPerpendicularTo(IVector2d Vector, double Tolerance);
    bool IsEqualTo(IVector2d Vector, double Tolerance);
    double DotProduct(IVector2d Vector);
    IUnitVector2d AsUnitVector();
    IVector2d Copy();
}