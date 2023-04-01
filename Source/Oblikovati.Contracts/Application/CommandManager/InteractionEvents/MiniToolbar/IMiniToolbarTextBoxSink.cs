namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MiniToolbar;

public interface IMiniToolbarTextBoxSink
{
    void OnChange();
    void OnEnter();
    void OnExit();
    void OnItemHoverEnd();
    void OnItemHoverStart();
    void OnItemRemove();
    void OnSelect();
}