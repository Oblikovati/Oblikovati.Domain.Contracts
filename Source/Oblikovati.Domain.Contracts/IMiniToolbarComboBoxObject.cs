using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarComboBoxObject
{
    IMiniToolbar Parent { get; }
    bool AutoHide { get; set; }
    MiniToolbarControlTypeEnum ControlType { get; }
    string DisplayName { get; set; }
    bool Enabled { get; set; }
    string InternalName { get; }
    string ToolTipText { get; set; }
    bool Visible { get; set; }
    int Index { get; }
    int Count { get; }
    IMiniToolbarListItem Item { get; }
    IMiniToolbarListItem SelectedItem { get; }
    bool ShowIcon { get; set; }
    bool ShowText { get; set; }
    int Width { get; set; }
    int SelectedIndex { get; set; }
    void Delete();
    IMiniToolbarListItem AddItem(string Text, string ToolTipText, string InternalName, bool AllowDelete, object StandardIcon, object LargeIcon, int Index);
    void Clear();
    void RemoveItem(object Index);
}
