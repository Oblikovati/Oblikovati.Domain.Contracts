using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IIRxUserInputEvents_Event
{
    void add_OnStartCommand(IRxUserInputEvents_OnStartCommandEventHandler handler);
    void remove_OnStartCommand(IRxUserInputEvents_OnStartCommandEventHandler handler);
    void add_OnStopCommand(IRxUserInputEvents_OnStopCommandEventHandler handler);
    void remove_OnStopCommand(IRxUserInputEvents_OnStopCommandEventHandler handler);
}
