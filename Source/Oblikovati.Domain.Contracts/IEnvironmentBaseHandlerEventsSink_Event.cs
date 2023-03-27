using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IEnvironmentBaseHandlerEventsSink_Event
{
    void add_OnActivate(EnvironmentBaseHandlerEventsSink_OnActivateEventHandler handler);
    void remove_OnActivate(EnvironmentBaseHandlerEventsSink_OnActivateEventHandler handler);
    void add_OnDeactivate(EnvironmentBaseHandlerEventsSink_OnDeactivateEventHandler handler);
    void remove_OnDeactivate(EnvironmentBaseHandlerEventsSink_OnDeactivateEventHandler handler);
}
