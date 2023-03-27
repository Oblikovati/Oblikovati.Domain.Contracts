namespace Oblikovati.Domain.Contracts;

public interface IDWGEntityEllipticalArcSegment
{

    IDWGEntity Parent { get; }
    object Geometry { get; }
}
