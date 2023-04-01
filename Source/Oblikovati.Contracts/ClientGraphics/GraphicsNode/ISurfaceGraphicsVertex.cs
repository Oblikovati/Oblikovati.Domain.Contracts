namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

public interface ISurfaceGraphicsVertex
{
    IVertex Vertex { get; }
    int Index { get; }
    ISurfaceGraphics Parent { get; }

    bool Selectable { get; set; }
}