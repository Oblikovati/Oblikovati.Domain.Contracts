using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IBrowserPanesSink
{
    void OnBrowserNodeActivate(object BrowserNodeDefinition, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnBrowserNodeGetDisplayObjects(object BrowserNodeDefinition, out IObjectCollection Objects,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnBrowserNodeLabelEdit(object BrowserNodeDefinition, string NewLabel, EventTimingEnum BeforeOrAfter,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnBrowserNodeDeleteEntry(object BrowserNodeDefinition, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnBrowserNodesReorder(IBrowserPane BrowserPane, IBrowserNodesEnumerator DragNodes, IBrowserNode TargetNode,
        InsertionLocationTypeEnum eInsertionLoactionType, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}