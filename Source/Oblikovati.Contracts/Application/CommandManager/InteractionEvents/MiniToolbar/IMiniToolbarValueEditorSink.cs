namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MiniToolbar;

public interface IMiniToolbarValueEditorSink
{
    void OnChange();
    void OnEnter();
    void OnExit();
}