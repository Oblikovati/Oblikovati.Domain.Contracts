using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface ITriadEventsSink_Event
{
    void add_OnActivate(TriadEventsSink_OnActivateEventHandler handler);
    void remove_OnActivate(TriadEventsSink_OnActivateEventHandler handler);
    void add_OnEndMove(TriadEventsSink_OnEndMoveEventHandler handler);
    void remove_OnEndMove(TriadEventsSink_OnEndMoveEventHandler handler);
    void add_OnMove(TriadEventsSink_OnMoveEventHandler handler);
    void remove_OnMove(TriadEventsSink_OnMoveEventHandler handler);
    void add_OnEndSequence(TriadEventsSink_OnEndSequenceEventHandler handler);
    void remove_OnEndSequence(TriadEventsSink_OnEndSequenceEventHandler handler);
    void add_OnStartSequence(TriadEventsSink_OnStartSequenceEventHandler handler);
    void remove_OnStartSequence(TriadEventsSink_OnStartSequenceEventHandler handler);
    void add_OnMoveTriadOnlyToggle(TriadEventsSink_OnMoveTriadOnlyToggleEventHandler handler);
    void remove_OnMoveTriadOnlyToggle(TriadEventsSink_OnMoveTriadOnlyToggleEventHandler handler);
    void add_OnStartMove(TriadEventsSink_OnStartMoveEventHandler handler);
    void remove_OnStartMove(TriadEventsSink_OnStartMoveEventHandler handler);
    void add_OnTerminate(TriadEventsSink_OnTerminateEventHandler handler);
    void remove_OnTerminate(TriadEventsSink_OnTerminateEventHandler handler);
    void add_OnSegmentSelectionChange(TriadEventsSink_OnSegmentSelectionChangeEventHandler handler);
    void remove_OnSegmentSelectionChange(TriadEventsSink_OnSegmentSelectionChangeEventHandler handler);
    void add_OnEndSequence2(TriadEventsSink_OnEndSequence2EventHandler handler);
    void remove_OnEndSequence2(TriadEventsSink_OnEndSequence2EventHandler handler);
    void add_OnTerminate2(TriadEventsSink_OnTerminate2EventHandler handler);
    void remove_OnTerminate2(TriadEventsSink_OnTerminate2EventHandler handler);
    void add_OnMoveTriadOnlyToggle2(TriadEventsSink_OnMoveTriadOnlyToggle2EventHandler handler);
    void remove_OnMoveTriadOnlyToggle2(TriadEventsSink_OnMoveTriadOnlyToggle2EventHandler handler);
}
