namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MiniToolbar;

public interface IMiniToolbarTextEditorSink
{
    void OnChange();
    void OnEnter();
    void OnExit();
}