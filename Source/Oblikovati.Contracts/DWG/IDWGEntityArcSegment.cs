namespace Oblikovati.Contracts.DWG;

public interface IDWGEntityArcSegment
{
    IDWGEntity Parent { get; }
    object Geometry { get; }
}