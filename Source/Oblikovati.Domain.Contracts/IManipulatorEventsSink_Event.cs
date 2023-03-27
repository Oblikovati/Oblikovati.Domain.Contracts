using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IManipulatorEventsSink_Event
{
    void add_OnManipulatorElementSelectionChange(ManipulatorEventsSink_OnManipulatorElementSelectionChangeEventHandler handler);
    void remove_OnManipulatorElementSelectionChange(ManipulatorEventsSink_OnManipulatorElementSelectionChangeEventHandler handler);
    void add_OnStartDrag(ManipulatorEventsSink_OnStartDragEventHandler handler);
    void remove_OnStartDrag(ManipulatorEventsSink_OnStartDragEventHandler handler);
    void add_OnEndDrag(ManipulatorEventsSink_OnEndDragEventHandler handler);
    void remove_OnEndDrag(ManipulatorEventsSink_OnEndDragEventHandler handler);
    void add_OnDrag(ManipulatorEventsSink_OnDragEventHandler handler);
    void remove_OnDrag(ManipulatorEventsSink_OnDragEventHandler handler);
}
