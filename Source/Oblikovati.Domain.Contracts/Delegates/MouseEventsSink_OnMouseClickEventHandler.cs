﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void MouseEventsSink_OnMouseClickEventHandler(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
