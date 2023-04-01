using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents;

public interface IMeasureEventsObject
{
    IInteractionEvents Parent { get; }
    bool Enabled { get; set; }
    void ShowDimensions();
    void Measure(MeasureTypeEnum MeasureType, object Options);
    void ListParameters(object ScreenPosition, object Component, bool DisplayAllParameters, int HWND);
}