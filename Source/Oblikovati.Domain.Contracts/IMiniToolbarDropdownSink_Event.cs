using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarDropdownSink_Event
{
    void add_OnPreMenuDisplay(MiniToolbarDropdownSink_OnPreMenuDisplayEventHandler handler);
    void remove_OnPreMenuDisplay(MiniToolbarDropdownSink_OnPreMenuDisplayEventHandler handler);
    void add_OnSelect(MiniToolbarDropdownSink_OnSelectEventHandler handler);
    void remove_OnSelect(MiniToolbarDropdownSink_OnSelectEventHandler handler);
    void add_OnItemRemove(MiniToolbarDropdownSink_OnItemRemoveEventHandler handler);
    void remove_OnItemRemove(MiniToolbarDropdownSink_OnItemRemoveEventHandler handler);
    void add_OnItemHoverEnd(MiniToolbarDropdownSink_OnItemHoverEndEventHandler handler);
    void remove_OnItemHoverEnd(MiniToolbarDropdownSink_OnItemHoverEndEventHandler handler);
    void add_OnItemHoverStart(MiniToolbarDropdownSink_OnItemHoverStartEventHandler handler);
    void remove_OnItemHoverStart(MiniToolbarDropdownSink_OnItemHoverStartEventHandler handler);
}
