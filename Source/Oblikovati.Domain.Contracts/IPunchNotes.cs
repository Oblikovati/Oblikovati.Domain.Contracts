namespace Oblikovati.Domain.Contracts;

public interface IPunchNotes : IList<IPunchNotes>
{

    int Count { get; }
    IPunchNote Item { get; }
    IPunchNote Add(IPoint2d Position, IGeometryIntent PunchEdge, object DimensionStyle);
    IEnumerator GetEnumerator();
}
