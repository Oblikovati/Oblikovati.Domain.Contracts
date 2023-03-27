using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingEventsSink_Event
{
    void add_OnRetrieveDimensions(DrawingEventsSink_OnRetrieveDimensionsEventHandler handler);
    void remove_OnRetrieveDimensions(DrawingEventsSink_OnRetrieveDimensionsEventHandler handler);
}
