using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.ClientGraphics;
using Oblikovati.Contracts.GraphicsDataSets;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents;

public interface IInteractionGraphics
{
    IGraphicsDataSets GraphicsDataSets { get; }
    IClientGraphics OverlayClientGraphics { get; }
    IClientGraphics PreviewClientGraphics { get; }
    void UpdateOverlayGraphics(IView TheView);
    void _EraseAll();
}