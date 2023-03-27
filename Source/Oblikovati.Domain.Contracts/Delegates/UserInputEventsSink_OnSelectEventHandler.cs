using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnSelectEventHandler(IObjectsEnumerator JustSelectedEntities, ref IObjectCollection MoreSelectedEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
