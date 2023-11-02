using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.NotClassified;

public interface IHoleThreadNotes : IList<IHoleThreadNotes>
{
    IHoleThreadNote Item { get; }
    IHoleThreadNote Add(IPoint2d Position, object HoleOrThreadEdge, bool LinearDiameterType, object DimensionStyle);
}