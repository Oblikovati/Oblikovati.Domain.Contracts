namespace Oblikovati.Domain.Contracts;

public interface IDWGEntityArcSegment
{

    IDWGEntity Parent { get; }
    object Geometry { get; }
}
