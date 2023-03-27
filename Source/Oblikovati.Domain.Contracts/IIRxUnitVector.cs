namespace Oblikovati.Domain.Contracts;

public interface IIRxUnitVector
{
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }
    void GetUnitVectorData(out List<double> pCoords);
    void PutUnitVectorData(List<double> pCoords);
}
