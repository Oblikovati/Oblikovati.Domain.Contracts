using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts;

public interface IChamferNotes : IList<IChamferNotes>
{
    IChamferNote Item { get; }
    IChamferNote Add(IPoint2d Position, object ChamferEdgeOne, object ChamferEdgeTwo, object DimensionStyle);
}