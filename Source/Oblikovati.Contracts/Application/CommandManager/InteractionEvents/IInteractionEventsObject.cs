using Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MiniToolbar;
using Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MouseEvents;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents;

public interface IInteractionEventsObject
{
    ICommandManager Parent { get; }
    IDocument TargetDocument { get; }
    ISelectEvents SelectEvents { get; }
    IMouseEvents MouseEvents { get; }
    IKeyboardEvents KeyboardEvents { get; }
    ITriadEvents TriadEvents { get; }
    IManipulatorEvents ManipulatorEvents { get; }
    bool SelectionActive { get; set; }
    bool InteractionDisabled { get; set; }
    string StatusBarText { get; set; }
    string Name { get; set; }
    IInteractionGraphics InteractionGraphics { get; }
    bool AllowCommandAliases { get; set; }
    IMeasureEvents MeasureEvents { get; }
    void Start();
    void Stop();
    void GetCursor(out CursorTypeEnum CursorType, out object Cursor, out CursorHotSpotEnum CursorHotSpot);
    void SetCursor(CursorTypeEnum CursorType, object Cursor, object CursorHotSpot);
    IMiniToolbar CreateMiniToolbar();
}