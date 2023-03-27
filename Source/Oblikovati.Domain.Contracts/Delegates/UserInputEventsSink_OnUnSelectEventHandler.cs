using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnUnSelectEventHandler(IObjectsEnumerator UnSelectedEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
