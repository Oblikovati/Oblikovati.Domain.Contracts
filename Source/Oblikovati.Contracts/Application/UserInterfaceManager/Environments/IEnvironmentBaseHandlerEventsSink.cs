namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

public interface IEnvironmentBaseHandlerEventsSink
{
    void OnActivate();
    void OnDeactivate();
}