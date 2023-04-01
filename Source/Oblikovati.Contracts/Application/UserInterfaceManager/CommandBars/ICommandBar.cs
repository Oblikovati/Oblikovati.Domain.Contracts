using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;

public interface ICommandBar
{
    bool BuiltIn { get; }
    ICommandBarControls Controls { get; }
    CommandBarTypeEnum CommandBarType { get; }
    string DisplayName { get; set; }
    string InternalName { get; }
    bool Visible { get; set; }
    string ClientId { get; }
    ICommandBar Copy(string DisplayName, string InternalName, string ClientId);
    void Delete();
}