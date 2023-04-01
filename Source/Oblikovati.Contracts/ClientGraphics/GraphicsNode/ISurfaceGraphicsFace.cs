using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.ClientGraphics.GraphicsNode;

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