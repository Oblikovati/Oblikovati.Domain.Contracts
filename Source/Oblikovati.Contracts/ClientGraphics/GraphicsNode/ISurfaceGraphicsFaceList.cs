namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface ISurfaceGraphicsFaceList : IList<ISurfaceGraphicsFaceList>
{
    ISurfaceGraphicsFace Item { get; }
    void Add(object Faces);
    void Remove(int Index);
}