using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents;

public interface ISelectEventsSink
{
    void OnPreSelect(ref object PreSelectEntity, out bool DoHighlight, ref IObjectCollection MorePreSelectEntities,
        SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);

    void OnPreSelectMouseMove(object PreSelectEntity, IPoint ModelPosition, IPoint2d ViewPosition, IView View);
    void OnStopPreSelect(IPoint ModelPosition, IPoint2d ViewPosition, IView View);

    void OnSelect(IObjectsEnumerator JustSelectedEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition,
        IPoint2d ViewPosition, IView View);

    void OnUnSelect(IObjectsEnumerator UnSelectedEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition,
        IPoint2d ViewPosition, IView View);
}