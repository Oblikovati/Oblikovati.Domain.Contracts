using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICommandBarPopUp
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
    string Caption { get; set; }
    void Delete();
}
