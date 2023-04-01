namespace Oblikovati.Contracts.DWG;

public interface IDWGEntityEllipticalArcSegment
{
    IDWGEntity Parent { get; }
    object Geometry { get; }
}