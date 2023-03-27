using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarComboBoxSink_Event
{
    void add_OnPreMenuDisplay(MiniToolbarComboBoxSink_OnPreMenuDisplayEventHandler handler);
    void remove_OnPreMenuDisplay(MiniToolbarComboBoxSink_OnPreMenuDisplayEventHandler handler);
    void add_OnItemHoverEnd(MiniToolbarComboBoxSink_OnItemHoverEndEventHandler handler);
    void remove_OnItemHoverEnd(MiniToolbarComboBoxSink_OnItemHoverEndEventHandler handler);
    void add_OnItemHoverStart(MiniToolbarComboBoxSink_OnItemHoverStartEventHandler handler);
    void remove_OnItemHoverStart(MiniToolbarComboBoxSink_OnItemHoverStartEventHandler handler);
    void add_OnItemRemove(MiniToolbarComboBoxSink_OnItemRemoveEventHandler handler);
    void remove_OnItemRemove(MiniToolbarComboBoxSink_OnItemRemoveEventHandler handler);
    void add_OnSelect(MiniToolbarComboBoxSink_OnSelectEventHandler handler);
    void remove_OnSelect(MiniToolbarComboBoxSink_OnSelectEventHandler handler);
}
