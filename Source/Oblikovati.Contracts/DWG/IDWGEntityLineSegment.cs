using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.DWG;

public interface IDWGEntityLineSegment
{
    IDWGEntity Parent { get; }
    ILineSegment Geometry { get; }
}