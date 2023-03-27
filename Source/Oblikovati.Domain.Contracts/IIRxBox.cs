namespace Oblikovati.Domain.Contracts;

public interface IIRxBox
{
    IIRxPoint MinPoint { get; set; }
    IIRxPoint MaxPoint { get; set; }
    void GetBoxData(out List<double> pMinPoint, out List<double> pMaxPoint);
    void PutBoxData(List<double> pMinPoint, List<double> pMaxPoint);
}
