namespace Oblikovati.Domain.Contracts;

public interface IDWGEntitySplineSegment
{

    IDWGEntity Parent { get; }
    IPoint StartPoint { get; }
    IPoint EndPoint { get; }
}
