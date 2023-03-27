using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IChangeDefinitionSink_Event
{
    void add_OnReplay(ChangeDefinitionSink_OnReplayEventHandler handler);
    void remove_OnReplay(ChangeDefinitionSink_OnReplayEventHandler handler);
}
