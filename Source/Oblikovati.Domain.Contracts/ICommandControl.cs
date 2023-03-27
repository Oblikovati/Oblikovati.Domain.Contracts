using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICommandControl
{

    string DisplayName { get; }
    string InternalName { get; }
    ICommandControls ChildControls { get; }
    IControlDefinition ControlDefinition { get; }
    ControlTypeEnum ControlType { get; }
    IControlDefinition DisplayedControl { get; set; }
    bool ShowText { get; set; }
    bool UseLargeIcon { get; }
    bool Visible { get; set; }
    string KeyTip { get; set; }
    void Delete();
}
