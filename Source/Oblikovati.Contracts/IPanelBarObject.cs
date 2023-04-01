using Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;
using Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

namespace Oblikovati.Contracts;

public interface IPanelBarObject
{
    IEnvironment Parent { get; }
    ICommandBar DefaultCommandBar { get; set; }
    ICommandBar CurrentCommandBar { get; set; }
    ICommandBarList CommandBarList { get; }
}