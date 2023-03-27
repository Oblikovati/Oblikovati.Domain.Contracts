namespace Oblikovati.Domain.Contracts;

public interface IIRxBox2d
{
    IIRxPoint2d MinPoint { get; set; }
    IIRxPoint2d MaxPoint { get; set; }
    void GetBoxData(out List<double> pMinPoint, out List<double> pMaxPoint);
    void PutBoxData(List<double> pMinPoint, List<double> pMaxPoint);
}
