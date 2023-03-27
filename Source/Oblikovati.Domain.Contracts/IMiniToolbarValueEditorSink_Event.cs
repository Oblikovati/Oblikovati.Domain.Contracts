using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarValueEditorSink_Event
{
    void add_OnChange(MiniToolbarValueEditorSink_OnChangeEventHandler handler);
    void remove_OnChange(MiniToolbarValueEditorSink_OnChangeEventHandler handler);
    void add_OnEnter(MiniToolbarValueEditorSink_OnEnterEventHandler handler);
    void remove_OnEnter(MiniToolbarValueEditorSink_OnEnterEventHandler handler);
    void add_OnExit(MiniToolbarValueEditorSink_OnExitEventHandler handler);
    void remove_OnExit(MiniToolbarValueEditorSink_OnExitEventHandler handler);
}
