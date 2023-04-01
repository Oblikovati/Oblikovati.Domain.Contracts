using Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

public interface IEnvironmentBaseCollection : IList<IEnvironmentBase>
{
    ICommandBarBaseCollection CommandBarBaseCollection { get; }
}