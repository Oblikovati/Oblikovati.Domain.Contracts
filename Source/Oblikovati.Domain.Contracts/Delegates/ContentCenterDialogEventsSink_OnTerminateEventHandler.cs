using Oblikovati.Domain.Contracts;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ContentCenterDialogEventsSink_OnTerminateEventHandler(bool Cancelled, INameValueMap Context);
