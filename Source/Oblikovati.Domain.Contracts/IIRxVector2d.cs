namespace Oblikovati.Domain.Contracts;

public interface IIRxVector2d
{
    double X { get; set; }
    double Y { get; set; }
    void GetVectorData(out List<double> pCoords);
    void PutVectorData(List<double> pCoords);
}
