namespace Oblikovati.Domain.Contracts;

public interface ITextureCoordinateSet
{


    IPoint Item { get; }
    int Count { get; }
    void GetCoordinates(out List<double> Coordinates);
}
