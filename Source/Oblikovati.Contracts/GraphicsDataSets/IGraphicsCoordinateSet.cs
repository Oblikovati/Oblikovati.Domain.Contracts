using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.GraphicsDataSets;

public interface IGraphicsCoordinateSet
{
    int Id { get; }
    IPoint Coordinate { get; set; }
    void Remove(int Index);
    void Delete();
    void Add(int Index, IPoint Coordinate);
    void GetCoordinates(ref List<double> Coordinates);
    void PutCoordinates(ref List<double> Coordinates);
}