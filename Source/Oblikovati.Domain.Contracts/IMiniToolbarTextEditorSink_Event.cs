using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarTextEditorSink_Event
{
    void add_OnChange(MiniToolbarTextEditorSink_OnChangeEventHandler handler);
    void remove_OnChange(MiniToolbarTextEditorSink_OnChangeEventHandler handler);
    void add_OnEnter(MiniToolbarTextEditorSink_OnEnterEventHandler handler);
    void remove_OnEnter(MiniToolbarTextEditorSink_OnEnterEventHandler handler);
    void add_OnExit(MiniToolbarTextEditorSink_OnExitEventHandler handler);
    void remove_OnExit(MiniToolbarTextEditorSink_OnExitEventHandler handler);
}
