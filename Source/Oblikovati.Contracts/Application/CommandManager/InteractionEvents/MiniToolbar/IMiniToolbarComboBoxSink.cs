namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MiniToolbar;

public interface IMiniToolbarComboBoxSink
{
    void OnPreMenuDisplay();
    void OnItemHoverEnd(IMiniToolbarListItem ListItem);
    void OnItemHoverStart(IMiniToolbarListItem ListItem);
    void OnItemRemove(IMiniToolbarListItem ListItem);
    void OnSelect(IMiniToolbarListItem ListItem);
}