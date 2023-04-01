using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MiniToolbar;

public interface IMiniToolbarTextBoxObject
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
    IColor BackgroundColor { get; set; }

    IMiniToolbarListItem Item { get; }
    IMiniToolbarListItem SelectedItem { get; }
    int SelectedIndex { get; set; }
    bool ShowIcon { get; set; }
    IColor TextColor { get; set; }
    string Text { get; set; }
    int SelectionStartPosition { get; }
    int SelectionEndPosition { get; }
    void Delete();

    IMiniToolbarListItem AddItem(string Text, string ToolTipText, string InternalName, bool AllowDelete,
        object StandardIcon, object LargeIcon, int Index);

    IMiniToolbarListItem AddSeparator(string InternalName, int Index);
    void Clear();
    void RemoveItem(object Index);
    void SetFocus();
}