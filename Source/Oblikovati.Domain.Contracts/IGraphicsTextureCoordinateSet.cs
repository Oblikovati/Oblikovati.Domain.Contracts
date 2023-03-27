using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IGraphicsTextureCoordinateSet
{
    int Count { get; }
    int Id { get; }
    object Coordinate { get; set; }
    TextureDimensionEnum TextureDimension { get; set; }
    void Remove(int Index);
    void Delete();
    void Add(int Index, object Coordinate);
    void GetCoordinates(ref List<double> Coordinates);
    void PutCoordinates(List<double> Coordinates);
}
