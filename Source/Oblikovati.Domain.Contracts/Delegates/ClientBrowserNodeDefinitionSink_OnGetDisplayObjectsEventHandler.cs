using Oblikovati.Domain.Contracts;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ClientBrowserNodeDefinitionSink_OnGetDisplayObjectsEventHandler(out IObjectCollection Objects, INameValueMap Context);
