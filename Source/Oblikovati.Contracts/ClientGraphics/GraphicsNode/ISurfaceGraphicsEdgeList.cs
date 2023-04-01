namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface ISurfaceGraphicsEdgeList : IList<ISurfaceGraphicsEdgeList>
{
    ISurfaceGraphicsEdge Item { get; }
    void Add(object Edges);
    void Remove(int Index);
}