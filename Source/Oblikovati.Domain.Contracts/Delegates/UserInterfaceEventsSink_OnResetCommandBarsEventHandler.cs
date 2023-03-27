using Oblikovati.Domain.Contracts;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInterfaceEventsSink_OnResetCommandBarsEventHandler(IObjectsEnumerator CommandBars, INameValueMap Context);
