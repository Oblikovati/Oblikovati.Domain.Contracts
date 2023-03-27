using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnPreSelectEventHandler(ref object PreSelectEntity, out bool DoHighlight, ref IObjectCollection MorePreSelectEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
