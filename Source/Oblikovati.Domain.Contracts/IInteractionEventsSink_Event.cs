using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IInteractionEventsSink_Event
{
    void add_OnActivate(InteractionEventsSink_OnActivateEventHandler handler);
    void remove_OnActivate(InteractionEventsSink_OnActivateEventHandler handler);
    void add_OnTerminate(InteractionEventsSink_OnTerminateEventHandler handler);
    void remove_OnTerminate(InteractionEventsSink_OnTerminateEventHandler handler);
    void add_OnSuspend(InteractionEventsSink_OnSuspendEventHandler handler);
    void remove_OnSuspend(InteractionEventsSink_OnSuspendEventHandler handler);
    void add_OnResume(InteractionEventsSink_OnResumeEventHandler handler);
    void remove_OnResume(InteractionEventsSink_OnResumeEventHandler handler);
    void add_OnHelp(InteractionEventsSink_OnHelpEventHandler handler);
    void remove_OnHelp(InteractionEventsSink_OnHelpEventHandler handler);
}
