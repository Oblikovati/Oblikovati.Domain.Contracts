namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MouseEvents;

public interface IMouseEventsObject
{
    IInteractionEvents Parent { get; }
    bool MouseMoveEnabled { get; set; }
    bool PointInferenceEnabled { get; set; }
    IPointInferenceEnumerator PointInferences { get; }
}