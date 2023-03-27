namespace Oblikovati.Domain.Contracts;

public interface IChamferNotes : IList<IChamferNotes>
{

    int Count { get; }
    IChamferNote Item { get; }
    IChamferNote Add(IPoint2d Position, object ChamferEdgeOne, object ChamferEdgeTwo, object DimensionStyle);
    IEnumerator GetEnumerator();
}
