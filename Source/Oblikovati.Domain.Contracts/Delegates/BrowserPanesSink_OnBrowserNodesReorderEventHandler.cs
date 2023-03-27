using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void BrowserPanesSink_OnBrowserNodesReorderEventHandler(IBrowserPane BrowserPane, IBrowserNodesEnumerator DragNodes, IBrowserNode TargetNode, InsertionLocationTypeEnum eInsertionLoactionType, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
