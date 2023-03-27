using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IPublicationEventsSink_Event
{
    void add_OnModelingDataUpdate(PublicationEventsSink_OnModelingDataUpdateEventHandler handler);
    void remove_OnModelingDataUpdate(PublicationEventsSink_OnModelingDataUpdateEventHandler handler);
}
