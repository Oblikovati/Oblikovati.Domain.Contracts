namespace Oblikovati.Domain.Contracts;

public interface IIRxUnitVector2d
{
    double X { get; set; }
    double Y { get; set; }
    void GetUnitVectorData(out List<double> ppCoords);
    void PutUnitVectorData(List<double> pCoords);
}
