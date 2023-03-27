namespace Oblikovati.Domain.Contracts;

public interface IDWGEntityEllipticalArcSegmentProxy
{
    object Geometry { get; }
    IDWGEntityEllipticalArcSegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
