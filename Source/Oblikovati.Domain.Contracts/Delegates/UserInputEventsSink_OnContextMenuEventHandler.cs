using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnContextMenuEventHandler(SelectionDeviceEnum SelectionDevice, INameValueMap AdditionalInfo, ICommandBar CommandBar);
