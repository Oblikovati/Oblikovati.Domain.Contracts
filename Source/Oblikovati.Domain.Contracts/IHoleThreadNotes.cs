namespace Oblikovati.Domain.Contracts;

public interface IHoleThreadNotes : IList<IHoleThreadNotes>
{

    int Count { get; }
    IHoleThreadNote Item { get; }
    IHoleThreadNote Add(IPoint2d Position, object HoleOrThreadEdge, bool LinearDiameterType, object DimensionStyle);
    IEnumerator GetEnumerator();
}
