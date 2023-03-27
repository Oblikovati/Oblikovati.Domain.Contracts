using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnLinearMarkingMenuEventHandler(IObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, ICommandControls LinearMenu, INameValueMap AdditionalInfo);
