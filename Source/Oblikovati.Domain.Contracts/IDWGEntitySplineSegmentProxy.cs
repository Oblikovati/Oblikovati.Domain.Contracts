namespace Oblikovati.Domain.Contracts;

public interface IDWGEntitySplineSegmentProxy
{
    IPoint StartPoint { get; }
    IPoint EndPoint { get; }
    IDWGEntitySplineSegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
