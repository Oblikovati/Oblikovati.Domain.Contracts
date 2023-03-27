using Oblikovati.Domain.Contracts;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void CustomDataEventsSink_OnRequestCustomDataEventHandler(INameValueMap Context, out INameValueMap CustomData);
