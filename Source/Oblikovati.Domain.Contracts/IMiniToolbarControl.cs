using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarControl
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
    void Delete();
}
