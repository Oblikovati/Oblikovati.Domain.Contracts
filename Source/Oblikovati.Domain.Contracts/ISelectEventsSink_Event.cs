using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface ISelectEventsSink_Event
{
    void add_OnPreSelect(SelectEventsSink_OnPreSelectEventHandler handler);
    void remove_OnPreSelect(SelectEventsSink_OnPreSelectEventHandler handler);
    void add_OnPreSelectMouseMove(SelectEventsSink_OnPreSelectMouseMoveEventHandler handler);
    void remove_OnPreSelectMouseMove(SelectEventsSink_OnPreSelectMouseMoveEventHandler handler);
    void add_OnStopPreSelect(SelectEventsSink_OnStopPreSelectEventHandler handler);
    void remove_OnStopPreSelect(SelectEventsSink_OnStopPreSelectEventHandler handler);
    void add_OnSelect(SelectEventsSink_OnSelectEventHandler handler);
    void remove_OnSelect(SelectEventsSink_OnSelectEventHandler handler);
    void add_OnUnSelect(SelectEventsSink_OnUnSelectEventHandler handler);
    void remove_OnUnSelect(SelectEventsSink_OnUnSelectEventHandler handler);
}
