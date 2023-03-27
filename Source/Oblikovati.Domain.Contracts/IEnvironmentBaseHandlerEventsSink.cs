namespace Oblikovati.Domain.Contracts;

public interface IEnvironmentBaseHandlerEventsSink
{
    void OnActivate();
    void OnDeactivate();
}
