namespace Oblikovati.Domain.Contracts;

public interface IVector
{
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }
    double Length { get; }
    void GetVectorData(ref List<double> Coords);
    void PutVectorData(ref List<double> Coords);
    void TransformBy(IMatrix Matrix);
    void ScaleBy(double Scale);
    void AddVector(IVector Argument);
    void SubtractVector(IVector Argument);
    double AngleTo(IVector Argument);
    void Normalize();
    bool IsParallelTo(IVector Argument, double Tolerance);
    bool IsPerpendicularTo(IVector Argument, double Tolerance);
    bool IsEqualTo(IVector Argument, double Tolerance);
    double DotProduct(IVector Argument);
    IVector CrossProduct(IVector Argument);
    IUnitVector AsUnitVector();
    IVector Copy();
}
