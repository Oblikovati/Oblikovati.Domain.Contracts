namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarListItem
{
    bool AllowDelete { get; set; }
    int Index { get; }
    string InternalName { get; }
    bool IsChecked { get; set; }
    bool IsSeperator { get; }
    string Text { get; set; }
    bool ShowCheckBox { get; set; }
    string ToolTipText { get; set; }
}
