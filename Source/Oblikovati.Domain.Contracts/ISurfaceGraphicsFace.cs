namespace Oblikovati.Domain.Contracts;

public interface ISurfaceGraphicsFace
{
    IFace Face { get; }
    IColor Color { get; set; }
    IRenderStyle RenderStyle { get; set; }
    int Index { get; }
    ISurfaceGraphics Parent { get; }

    bool Selectable { get; set; }
    IAsset Appearance { get; set; }
}
