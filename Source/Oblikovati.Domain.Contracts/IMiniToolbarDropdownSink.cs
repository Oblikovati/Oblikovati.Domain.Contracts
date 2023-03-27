namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarDropdownSink
{
    void OnPreMenuDisplay();
    void OnSelect(IMiniToolbarListItem ListItem);
    void OnItemRemove(IMiniToolbarListItem ListItem);
    void OnItemHoverEnd(IMiniToolbarListItem ListItem);
    void OnItemHoverStart(IMiniToolbarListItem ListItem);
}
