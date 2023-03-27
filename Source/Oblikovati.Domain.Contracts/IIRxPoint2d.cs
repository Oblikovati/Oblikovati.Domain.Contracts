namespace Oblikovati.Domain.Contracts;

public interface IIRxPoint2d
{
    double X { get; set; }
    double Y { get; set; }
    void GetPointData(out List<double> pCoords);
    void PutPointData(List<double> pCoords);
}
