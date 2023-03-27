using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IControlDefinitionEventsSink_Event
{
    void add_OnCommandInputs(ControlDefinitionEventsSink_OnCommandInputsEventHandler handler);
    void remove_OnCommandInputs(ControlDefinitionEventsSink_OnCommandInputsEventHandler handler);
}
