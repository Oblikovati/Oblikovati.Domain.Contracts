using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnDragEventHandler(DragStateEnum DragState, ShiftStateEnum ShiftKeys, IPoint ModelPosition, IPoint2d ViewPosition, IView View, INameValueMap AdditionalInfo, out HandlingCodeEnum HandlingCode);
