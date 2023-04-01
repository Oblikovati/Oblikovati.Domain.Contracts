using Oblikovati.Contracts.Application.CommandManager.InteractionEvents;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IManipulatorEventsObject
{
    IInteractionEvents Parent { get; }
    bool Enabled { get; set; }
    IMatrix Transform { get; set; }
    bool Visible { get; set; }
    ManipulatorElementEnum SelectedElement { get; set; }
    void ApplyDrag(ManipulatorElementEnum ManipulatorElement, object DragValue);
    void SetAppearance(ManipulatorElementEnum VisibleElements, ManipulatorElementEnum EnabledElements);
    IPoint2d SuggestedMiniToolbarPosition(int MiniToolbarHeight, int MiniToolbarWidth);
    void ClearCurrentDragValue();
}