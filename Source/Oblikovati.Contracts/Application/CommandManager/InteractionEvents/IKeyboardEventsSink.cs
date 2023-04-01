using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents;

public interface IKeyboardEventsSink
{
    void OnKeyDown(int Key, ShiftStateEnum ShiftKeys);
    void OnKeyUp(int Key, ShiftStateEnum ShiftKeys);
    void OnKeyPress(int KeyASCII);
}