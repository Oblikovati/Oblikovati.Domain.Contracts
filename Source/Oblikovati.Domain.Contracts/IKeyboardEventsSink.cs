using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IKeyboardEventsSink
{
    void OnKeyDown(int Key, ShiftStateEnum ShiftKeys);
    void OnKeyUp(int Key, ShiftStateEnum ShiftKeys);
    void OnKeyPress(int KeyASCII);
}
