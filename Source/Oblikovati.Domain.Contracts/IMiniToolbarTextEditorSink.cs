namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarTextEditorSink
{
    void OnChange();
    void OnEnter();
    void OnExit();
}
