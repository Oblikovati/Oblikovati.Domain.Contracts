using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void KeyboardEventsSink_OnKeyDownEventHandler(int Key, ShiftStateEnum ShiftKeys);
