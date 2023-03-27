using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarTextEditorObject
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
    string TextValue { get; set; }
    int Width { get; set; }
    int Height { get; set; }
    void Delete();
    void SetFocus();
    string AppendLine(string Value);
    bool SetReadonly(bool Value);
}
