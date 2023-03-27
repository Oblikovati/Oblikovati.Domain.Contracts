namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarValueEditorSink
{
    void OnChange();
    void OnEnter();
    void OnExit();
}
