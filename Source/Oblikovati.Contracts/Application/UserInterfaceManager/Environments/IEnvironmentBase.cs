using Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

public interface IEnvironmentBase
{
    /// <summary>
    /// Property that indicates the name of the environment.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Display Name of the Environment.
    /// </summary>
    string DisplayName { get; }
    ICommandBarBase DefaultToolBar { get; set; }
    ICommandBarBase DefaultPanelBar { get; set; }
    ICommandBarList PanelBarList { get; }
    ICommandBarBase MenuBar { get; }
    ICommandBarBase CurrentPanelBar { get; set; }
}