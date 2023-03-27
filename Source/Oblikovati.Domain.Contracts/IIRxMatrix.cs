namespace Oblikovati.Domain.Contracts;

public interface IIRxMatrix
{
    double Cell { get; set; }
    void GetMatrixData(out List<double> pCells);
    void PutMatrixData(List<double> pCells);
}
