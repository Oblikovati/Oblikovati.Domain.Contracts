using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.NotClassified;

public interface ITextureCoordinateSet
{
    IPoint Item { get; }

    void GetCoordinates(out List<double> Coordinates);
}