using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingViewEventsSink_Event
{
    void add_OnViewUpdate(DrawingViewEventsSink_OnViewUpdateEventHandler handler);
    void remove_OnViewUpdate(DrawingViewEventsSink_OnViewUpdateEventHandler handler);
}
