namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface ISurfaceGraphicsVertexList : IList<ISurfaceGraphicsVertexList>
{
    ISurfaceGraphicsVertex Item { get; }
    void Add(object Vertex);
    void Remove(int Index);
}