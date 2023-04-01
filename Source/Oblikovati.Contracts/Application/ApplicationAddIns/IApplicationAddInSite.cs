using Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;
using Oblikovati.Contracts.Application.UserInterfaceManager.Environments;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ApplicationAddIns;

public interface IApplicationAddInSite
{
    IApplicationAddIn Parent { get; }
    ICommand CreateCommand(string CommandName, int CommandID, object InstallInTools);
    void DeleteCommand(int CommandID);

    IButtonDefinitionHandler CreateButtonDefinitionHandler(string InternalName, CommandTypesEnum Classification,
        string DisplayName, object DescriptionText, object ToolTipText, object StandardIcon, object LargeIcon);

    IEnvironmentBaseHandler CreateEnvironmentBaseHandler(string EnvironmentID, string InternalName, string DisplayName,
        IEnvironmentBase CopyFrom);
}