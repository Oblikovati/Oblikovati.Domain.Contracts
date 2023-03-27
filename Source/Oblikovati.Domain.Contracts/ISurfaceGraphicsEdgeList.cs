namespace Oblikovati.Domain.Contracts;

public interface ISurfaceGraphicsEdgeList : IList<ISurfaceGraphicsEdgeList>
{

    int Count { get; }
    ISurfaceGraphicsEdge Item { get; }
    IEnumerator GetEnumerator();
    void Add(object Edges);
    void Remove(int Index);
    void Clear();
}
