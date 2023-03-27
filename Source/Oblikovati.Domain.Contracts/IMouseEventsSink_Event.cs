using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMouseEventsSink_Event
{
    void add_OnMouseUp(MouseEventsSink_OnMouseUpEventHandler handler);
    void remove_OnMouseUp(MouseEventsSink_OnMouseUpEventHandler handler);
    void add_OnMouseDown(MouseEventsSink_OnMouseDownEventHandler handler);
    void remove_OnMouseDown(MouseEventsSink_OnMouseDownEventHandler handler);
    void add_OnMouseClick(MouseEventsSink_OnMouseClickEventHandler handler);
    void remove_OnMouseClick(MouseEventsSink_OnMouseClickEventHandler handler);
    void add_OnMouseDoubleClick(MouseEventsSink_OnMouseDoubleClickEventHandler handler);
    void remove_OnMouseDoubleClick(MouseEventsSink_OnMouseDoubleClickEventHandler handler);
    void add_OnMouseMove(MouseEventsSink_OnMouseMoveEventHandler handler);
    void remove_OnMouseMove(MouseEventsSink_OnMouseMoveEventHandler handler);
    void add_OnMouseLeave(MouseEventsSink_OnMouseLeaveEventHandler handler);
    void remove_OnMouseLeave(MouseEventsSink_OnMouseLeaveEventHandler handler);
}
