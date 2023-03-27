using Oblikovati.Domain.Contracts;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void CustomDataEventsSink_OnExecuteCustomActionEventHandler(INameValueMap Context, INameValueMap CustomData);
