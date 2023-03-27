using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void BrowserPanesSink_OnBrowserNodeActivateEventHandler(object BrowserNodeDefinition, INameValueMap Context, out HandlingCodeEnum HandlingCode);
