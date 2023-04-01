namespace Oblikovati.Contracts.Application.TransientObjects.Math;

public interface IUnitVector
{
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }
    void GetUnitVectorData(ref List<double> Coords);
    void PutUnitVectorData(ref List<double> Coords);
    void TransformBy(IMatrix Matrix);
    double AngleTo(IUnitVector Argument);
    bool IsParallelTo(IUnitVector Argument, double Tolerance);
    bool IsPerpendicularTo(IUnitVector Argument, double Tolerance);
    bool IsEqualTo(IUnitVector Argument, double Tolerance);
    double DotProduct(IUnitVector Argument);
    IUnitVector CrossProduct(IUnitVector Argument);
    IVector AsVector();
    IUnitVector Copy();
}