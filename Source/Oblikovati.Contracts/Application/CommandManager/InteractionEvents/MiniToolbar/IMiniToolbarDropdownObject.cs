using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MiniToolbar;

public interface IMiniToolbarDropdownObject
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

    bool IsSplitButton { get; }
    IMiniToolbarListItem Item { get; }
    bool Pressed { get; set; }
    IMiniToolbarListItem SelectedItem { get; }
    bool ShowIcon { get; set; }
    bool ShowText { get; set; }
    bool HasMRUBehavior { get; set; }
    int SelectedIndex { get; set; }
    void Delete();

    IMiniToolbarListItem AddItem(string Text, string ToolTipText, string InternalName, bool AllowDelete,
        bool ShowCheckBox, object StandardIcon, object LargeIcon, int Index);

    IMiniToolbarListItem AddSeparator(string InternalName, int Index);
    void Clear();
    void RemoveItem(object Index);
}