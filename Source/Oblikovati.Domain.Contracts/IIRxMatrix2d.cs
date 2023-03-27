namespace Oblikovati.Domain.Contracts;

public interface IIRxMatrix2d
{
    double Cell { get; set; }
    void GetMatrixData(out List<double> pCells);
    void PutMatrixData(List<double> pCells);
}
