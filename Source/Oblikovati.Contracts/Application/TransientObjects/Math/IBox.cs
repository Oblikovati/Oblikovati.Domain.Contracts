using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Application.TransientObjects.Math;

public interface IBox
{
    IPoint MinPoint { get; set; }
    IPoint MaxPoint { get; set; }
    void GetBoxData(ref List<double> MinPoint, ref List<double> MaxPoint);
    void PutBoxData(ref List<double> MinPoint, ref List<double> MaxPoint);
    void Extend(IPoint Point);
    void Expand(double Distance);
    bool Contains(IPoint Point);
    bool IsDisjoint(IBox Box);
    IBox Copy();
}