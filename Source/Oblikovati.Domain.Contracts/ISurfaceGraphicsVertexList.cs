namespace Oblikovati.Domain.Contracts;

public interface ISurfaceGraphicsVertexList : IList<ISurfaceGraphicsVertexList>
{

    int Count { get; }
    ISurfaceGraphicsVertex Item { get; }
    IEnumerator GetEnumerator();
    void Add(object Vertex);
    void Remove(int Index);
    void Clear();
}
