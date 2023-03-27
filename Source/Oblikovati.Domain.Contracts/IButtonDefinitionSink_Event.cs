using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IButtonDefinitionSink_Event
{
    void add_OnExecute(ButtonDefinitionSink_OnExecuteEventHandler handler);
    void remove_OnExecute(ButtonDefinitionSink_OnExecuteEventHandler handler);
    void add_OnHelp(ButtonDefinitionSink_OnHelpEventHandler handler);
    void remove_OnHelp(ButtonDefinitionSink_OnHelpEventHandler handler);
}
