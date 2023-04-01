using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface IGraphicsTextureCoordinateSet
{
    int Id { get; }
    object Coordinate { get; set; }
    TextureDimensionEnum TextureDimension { get; set; }
    void Remove(int Index);
    void Delete();
    void Add(int Index, object Coordinate);
    void GetCoordinates(ref List<double> Coordinates);
    void PutCoordinates(List<double> Coordinates);
}