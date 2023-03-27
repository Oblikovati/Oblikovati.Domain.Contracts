namespace Oblikovati.Domain.Contracts;

public interface IIRxVector
{
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }
    void GetVectorData(out List<double> pCoords);
    void PutVectorData(List<double> pCoords);
}
