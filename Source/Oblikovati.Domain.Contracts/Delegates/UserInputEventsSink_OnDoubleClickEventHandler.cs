using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnDoubleClickEventHandler(IObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, MouseButtonEnum Button, ShiftStateEnum ShiftKeys, IPoint ModelPosition, IPoint2d ViewPosition, IView View, INameValueMap AdditionalInfo, out HandlingCodeEnum HandlingCode);
