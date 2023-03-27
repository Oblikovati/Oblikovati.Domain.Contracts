using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IUserInputEventsSink_Event
{
    void add_OnStartCommand(UserInputEventsSink_OnStartCommandEventHandler handler);
    void remove_OnStartCommand(UserInputEventsSink_OnStartCommandEventHandler handler);
    void add_OnActivateCommand(UserInputEventsSink_OnActivateCommandEventHandler handler);
    void remove_OnActivateCommand(UserInputEventsSink_OnActivateCommandEventHandler handler);
    void add_OnTerminateCommand(UserInputEventsSink_OnTerminateCommandEventHandler handler);
    void remove_OnTerminateCommand(UserInputEventsSink_OnTerminateCommandEventHandler handler);
    void add_OnStopCommand(UserInputEventsSink_OnStopCommandEventHandler handler);
    void remove_OnStopCommand(UserInputEventsSink_OnStopCommandEventHandler handler);
    void add_OnContextMenuOld(UserInputEventsSink_OnContextMenuOldEventHandler handler);
    void remove_OnContextMenuOld(UserInputEventsSink_OnContextMenuOldEventHandler handler);
    void add_OnDrag(UserInputEventsSink_OnDragEventHandler handler);
    void remove_OnDrag(UserInputEventsSink_OnDragEventHandler handler);
    void add_OnContextMenu(UserInputEventsSink_OnContextMenuEventHandler handler);
    void remove_OnContextMenu(UserInputEventsSink_OnContextMenuEventHandler handler);
    void add_OnDoubleClick(UserInputEventsSink_OnDoubleClickEventHandler handler);
    void remove_OnDoubleClick(UserInputEventsSink_OnDoubleClickEventHandler handler);
    void add_OnDeleteKeyUp(UserInputEventsSink_OnDeleteKeyUpEventHandler handler);
    void remove_OnDeleteKeyUp(UserInputEventsSink_OnDeleteKeyUpEventHandler handler);
    void add_OnPreSelect(UserInputEventsSink_OnPreSelectEventHandler handler);
    void remove_OnPreSelect(UserInputEventsSink_OnPreSelectEventHandler handler);
    void add_OnStopPreSelect(UserInputEventsSink_OnStopPreSelectEventHandler handler);
    void remove_OnStopPreSelect(UserInputEventsSink_OnStopPreSelectEventHandler handler);
    void add_OnSelect(UserInputEventsSink_OnSelectEventHandler handler);
    void remove_OnSelect(UserInputEventsSink_OnSelectEventHandler handler);
    void add_OnUnSelect(UserInputEventsSink_OnUnSelectEventHandler handler);
    void remove_OnUnSelect(UserInputEventsSink_OnUnSelectEventHandler handler);
    void add_OnRadialMarkingMenu(UserInputEventsSink_OnRadialMarkingMenuEventHandler handler);
    void remove_OnRadialMarkingMenu(UserInputEventsSink_OnRadialMarkingMenuEventHandler handler);
    void add_OnLinearMarkingMenu(UserInputEventsSink_OnLinearMarkingMenuEventHandler handler);
    void remove_OnLinearMarkingMenu(UserInputEventsSink_OnLinearMarkingMenuEventHandler handler);
    void add_OnContextualMiniToolbar(UserInputEventsSink_OnContextualMiniToolbarEventHandler handler);
    void remove_OnContextualMiniToolbar(UserInputEventsSink_OnContextualMiniToolbarEventHandler handler);
    void add_OnMarkTutorialCommand(UserInputEventsSink_OnMarkTutorialCommandEventHandler handler);
    void remove_OnMarkTutorialCommand(UserInputEventsSink_OnMarkTutorialCommandEventHandler handler);
}
