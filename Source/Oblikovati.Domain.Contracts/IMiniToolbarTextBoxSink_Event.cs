using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarTextBoxSink_Event
{
    void add_OnChange(MiniToolbarTextBoxSink_OnChangeEventHandler handler);
    void remove_OnChange(MiniToolbarTextBoxSink_OnChangeEventHandler handler);
    void add_OnEnter(MiniToolbarTextBoxSink_OnEnterEventHandler handler);
    void remove_OnEnter(MiniToolbarTextBoxSink_OnEnterEventHandler handler);
    void add_OnExit(MiniToolbarTextBoxSink_OnExitEventHandler handler);
    void remove_OnExit(MiniToolbarTextBoxSink_OnExitEventHandler handler);
    void add_OnItemHoverEnd(MiniToolbarTextBoxSink_OnItemHoverEndEventHandler handler);
    void remove_OnItemHoverEnd(MiniToolbarTextBoxSink_OnItemHoverEndEventHandler handler);
    void add_OnItemHoverStart(MiniToolbarTextBoxSink_OnItemHoverStartEventHandler handler);
    void remove_OnItemHoverStart(MiniToolbarTextBoxSink_OnItemHoverStartEventHandler handler);
    void add_OnItemRemove(MiniToolbarTextBoxSink_OnItemRemoveEventHandler handler);
    void remove_OnItemRemove(MiniToolbarTextBoxSink_OnItemRemoveEventHandler handler);
    void add_OnSelect(MiniToolbarTextBoxSink_OnSelectEventHandler handler);
    void remove_OnSelect(MiniToolbarTextBoxSink_OnSelectEventHandler handler);
}
