using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void BrowserPanesSink_OnBrowserNodeLabelEditEventHandler(object BrowserNodeDefinition, string NewLabel, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
