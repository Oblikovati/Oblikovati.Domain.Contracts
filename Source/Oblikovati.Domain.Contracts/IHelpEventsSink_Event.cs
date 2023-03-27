using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IHelpEventsSink_Event
{
    void add_OnApplicationHelp(HelpEventsSink_OnApplicationHelpEventHandler handler);
    void remove_OnApplicationHelp(HelpEventsSink_OnApplicationHelpEventHandler handler);
}
