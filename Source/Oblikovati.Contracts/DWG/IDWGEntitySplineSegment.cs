using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.DWG;

public interface IDWGEntitySplineSegment
{
    IDWGEntity Parent { get; }
    IPoint StartPoint { get; }
    IPoint EndPoint { get; }
}