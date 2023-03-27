namespace Oblikovati.Domain.Contracts;

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
