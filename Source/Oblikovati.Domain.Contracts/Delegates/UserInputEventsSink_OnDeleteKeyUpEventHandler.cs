using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnDeleteKeyUpEventHandler(IObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, IView View, INameValueMap AdditionalInfo, out HandlingCodeEnum HandlingCode);
