using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Application.TransientObjects.Math;

public interface IBox2d
{
    IPoint2d MinPoint { get; set; }
    IPoint2d MaxPoint { get; set; }
    void GetBoxData(ref List<double> MinPoint, ref List<double> MaxPoint);
    void PutBoxData(ref List<double> MinPoint, ref List<double> MaxPoint);
    void Extend(IPoint2d Point);
    void Expand(double Distance);
    bool Contains(IPoint2d Point);
    bool IsDisjoint(IBox2d Box);
    IBox2d Copy();
}