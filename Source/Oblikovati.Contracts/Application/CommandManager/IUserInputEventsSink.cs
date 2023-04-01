using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;
using Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;
using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager;

public interface IUserInputEventsSink
{
    void OnStartCommand(CommandIDEnum CommandID);
    void OnActivateCommand(string CommandName, INameValueMap Context);
    void OnTerminateCommand(string CommandName, INameValueMap Context);
    void OnStopCommand(CommandIDEnum CommandID);
    void OnContextMenuOld(SelectionDeviceEnum SelectionDevice, INameValueMap AdditionalInfo, ICommandBar CommandBar);

    void OnDrag(DragStateEnum DragState, ShiftStateEnum ShiftKeys, IPoint ModelPosition, IPoint2d ViewPosition,
        IView View, INameValueMap AdditionalInfo, out HandlingCodeEnum HandlingCode);

    void OnContextMenu(SelectionDeviceEnum SelectionDevice, INameValueMap AdditionalInfo, ICommandBar CommandBar);

    void OnDoubleClick(IObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, MouseButtonEnum Button,
        ShiftStateEnum ShiftKeys, IPoint ModelPosition, IPoint2d ViewPosition, IView View, INameValueMap AdditionalInfo,
        out HandlingCodeEnum HandlingCode);

    void OnDeleteKeyUp(IObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, IView View,
        INameValueMap AdditionalInfo, out HandlingCodeEnum HandlingCode);

    void OnPreSelect(ref object PreSelectEntity, out bool DoHighlight, ref IObjectCollection MorePreSelectEntities,
        SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);

    void OnStopPreSelect(IPoint ModelPosition, IPoint2d ViewPosition, IView View);

    void OnSelect(IObjectsEnumerator JustSelectedEntities, ref IObjectCollection MoreSelectedEntities,
        SelectionDeviceEnum SelectionDevice, IPoint ModelPosition, IPoint2d ViewPosition, IView View);

    void OnUnSelect(IObjectsEnumerator UnSelectedEntities, SelectionDeviceEnum SelectionDevice, IPoint ModelPosition,
        IPoint2d ViewPosition, IView View);

    void OnRadialMarkingMenu(IObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice,
        IRadialMarkingMenu RadialMenu, INameValueMap AdditionalInfo);

    void OnLinearMarkingMenu(IObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice,
        ICommandControls LinearMenu, INameValueMap AdditionalInfo);

    void OnContextualMiniToolbar(IObjectsEnumerator SelectedEntities, INameValueMap DisplayedCommands,
        INameValueMap AdditionalInfo);

    void OnMarkTutorialCommand(string CommandID, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}