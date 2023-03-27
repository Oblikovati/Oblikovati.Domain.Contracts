using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void SelectEventsSink_OnSelectEventHandler(IObjectsEnumerator JustSelectedEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
