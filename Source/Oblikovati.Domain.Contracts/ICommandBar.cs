using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
