using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISelectEventsSink
{
    void OnPreSelect(ref object PreSelectEntity, out bool DoHighlight, ref IObjectCollection MorePreSelectEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
    void OnPreSelectMouseMove(object PreSelectEntity, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
    void OnStopPreSelect(IPoint ModelPosition, IPoint2d ViewPosition, IView View);
    void OnSelect(IObjectsEnumerator JustSelectedEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
    void OnUnSelect(IObjectsEnumerator UnSelectedEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
}
