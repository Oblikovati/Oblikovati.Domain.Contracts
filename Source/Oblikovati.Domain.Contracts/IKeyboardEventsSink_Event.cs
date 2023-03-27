using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IKeyboardEventsSink_Event
{
    void add_OnKeyDown(KeyboardEventsSink_OnKeyDownEventHandler handler);
    void remove_OnKeyDown(KeyboardEventsSink_OnKeyDownEventHandler handler);
    void add_OnKeyUp(KeyboardEventsSink_OnKeyUpEventHandler handler);
    void remove_OnKeyUp(KeyboardEventsSink_OnKeyUpEventHandler handler);
    void add_OnKeyPress(KeyboardEventsSink_OnKeyPressEventHandler handler);
    void remove_OnKeyPress(KeyboardEventsSink_OnKeyPressEventHandler handler);
}
