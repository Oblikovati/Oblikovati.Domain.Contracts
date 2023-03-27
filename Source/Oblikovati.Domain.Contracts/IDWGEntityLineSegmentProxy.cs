namespace Oblikovati.Domain.Contracts;

public interface IDWGEntityLineSegmentProxy
{
    ILineSegment Geometry { get; }
    IDWGEntityLineSegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
