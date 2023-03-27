namespace Oblikovati.Domain.Contracts;

public interface IDWGEntityLineSegment
{

    IDWGEntity Parent { get; }
    ILineSegment Geometry { get; }
}
