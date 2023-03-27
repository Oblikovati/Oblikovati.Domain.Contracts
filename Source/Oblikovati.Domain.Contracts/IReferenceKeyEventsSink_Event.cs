using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IReferenceKeyEventsSink_Event
{
    void add_OnBindKeyToObject(ReferenceKeyEventsSink_OnBindKeyToObjectEventHandler handler);
    void remove_OnBindKeyToObject(ReferenceKeyEventsSink_OnBindKeyToObjectEventHandler handler);
}
