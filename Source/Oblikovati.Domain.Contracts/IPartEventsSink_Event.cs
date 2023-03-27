using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IPartEventsSink_Event
{
    void add_OnSurfaceBodyChanged(PartEventsSink_OnSurfaceBodyChangedEventHandler handler);
    void remove_OnSurfaceBodyChanged(PartEventsSink_OnSurfaceBodyChangedEventHandler handler);
}
