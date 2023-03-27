namespace Oblikovati.Domain.Contracts;

public interface IGraphicsCoordinateSet
{
    int Count { get; }
    int Id { get; }
    IPoint Coordinate { get; set; }
    void Remove(int Index);
    void Delete();
    void Add(int Index, IPoint Coordinate);
    void GetCoordinates(ref List<double> Coordinates);
    void PutCoordinates(ref List<double> Coordinates);
}
