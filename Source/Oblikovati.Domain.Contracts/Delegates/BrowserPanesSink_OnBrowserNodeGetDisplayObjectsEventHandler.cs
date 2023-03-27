using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void BrowserPanesSink_OnBrowserNodeGetDisplayObjectsEventHandler(object BrowserNodeDefinition, out IObjectCollection Objects, INameValueMap Context, out HandlingCodeEnum HandlingCode);
