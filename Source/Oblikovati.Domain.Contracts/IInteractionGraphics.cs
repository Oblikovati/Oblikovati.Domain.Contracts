namespace Oblikovati.Domain.Contracts;

public interface IInteractionGraphics
{
    IGraphicsDataSets GraphicsDataSets { get; }
    IClientGraphics OverlayClientGraphics { get; }
    IClientGraphics PreviewClientGraphics { get; }
    void UpdateOverlayGraphics(IView TheView);
    void _EraseAll();
}
