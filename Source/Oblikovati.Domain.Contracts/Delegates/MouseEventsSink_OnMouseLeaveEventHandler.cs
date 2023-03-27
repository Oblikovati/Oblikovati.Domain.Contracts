using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void MouseEventsSink_OnMouseLeaveEventHandler(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, IView View);
