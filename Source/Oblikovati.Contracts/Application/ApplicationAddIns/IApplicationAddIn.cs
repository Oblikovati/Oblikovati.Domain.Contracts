using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ApplicationAddIns;

public interface IApplicationAddIn
{
    string DisplayName { get; }
    string ShortDisplayName { get; }
    string Description { get; }
    bool StartUpEnabled { get; set; }
    int Version { get; }
    bool Hidden { get; set; }
    bool UserUnloadable { get; set; }
    ApplicationAddInTypeEnum AddInType { get; }
    bool Activated { get; }
    object Automation { get; }
    int DataVersion { get; set; }
    string ClientId { get; }
    string Location { get; }
    int UserInterfaceVersion { get; }
    AddInLoadBehaviorEnum LoadBehavior { get; }
    bool LoadAutomatically { get; set; }
    void Activate();
    void Deactivate();
}