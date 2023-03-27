using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface ICustomDataEventsSink_Event
{
    void add_OnRequestCustomData(CustomDataEventsSink_OnRequestCustomDataEventHandler handler);
    void remove_OnRequestCustomData(CustomDataEventsSink_OnRequestCustomDataEventHandler handler);
    void add_OnExecuteCustomAction(CustomDataEventsSink_OnExecuteCustomActionEventHandler handler);
    void remove_OnExecuteCustomAction(CustomDataEventsSink_OnExecuteCustomActionEventHandler handler);
}
