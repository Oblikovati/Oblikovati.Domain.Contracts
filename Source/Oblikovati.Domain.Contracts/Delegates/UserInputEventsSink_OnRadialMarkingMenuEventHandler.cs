using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnRadialMarkingMenuEventHandler(IObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, IRadialMarkingMenu RadialMenu, INameValueMap AdditionalInfo);
