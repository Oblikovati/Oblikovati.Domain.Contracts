using Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;

public interface ICommandBarControl
{
    ICommandBar Parent { get; }
    bool BuiltIn { get; }
    bool GroupBegins { get; set; }
    string DisplayName { get; }
    IControlDefinition DisplayedControl { get; set; }
    IControlDefinition ControlDefinition { get; }
    ICommandBar CommandBar { get; }
    ControlTypeEnum ControlType { get; }
    string InternalName { get; }
    int Index { get; }
    void Delete();
}