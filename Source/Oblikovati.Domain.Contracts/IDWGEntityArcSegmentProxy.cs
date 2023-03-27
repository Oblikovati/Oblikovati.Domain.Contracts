namespace Oblikovati.Domain.Contracts;

public interface IDWGEntityArcSegmentProxy
{
    object Geometry { get; }
    IDWGEntityArcSegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
