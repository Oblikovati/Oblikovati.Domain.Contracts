namespace Oblikovati.Domain.Contracts;

public interface IMouseEventsObject
{
    IInteractionEvents Parent { get; }
    bool MouseMoveEnabled { get; set; }
    bool PointInferenceEnabled { get; set; }
    IPointInferenceEnumerator PointInferences { get; }
}
