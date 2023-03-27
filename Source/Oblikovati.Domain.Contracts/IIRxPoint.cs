namespace Oblikovati.Domain.Contracts;

public interface IIRxPoint
{
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }
    void GetPointData(out List<double> pCoords);
    void PutPointData(List<double> pCoords);
}
