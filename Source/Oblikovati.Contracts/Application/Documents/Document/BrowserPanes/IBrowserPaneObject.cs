using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IBrowserPaneObject
{
    IDocument Parent { get; }
    string Name { get; set; }
    bool BuiltIn { get; }
    bool TreeBrowser { get; }
    string InternalName { get; }
    object Control { get; }
    IBrowserNode TopNode { get; }
    bool Visible { get; set; }
    bool Default { get; set; }
    bool Transient { get; set; }
    ISearchBox SearchBox { get; }
    void Activate();
    void Deactivate();
    void Delete();
    void Reorder(IBrowserNode TargetNode, bool Before, IBrowserNode StartNode, object EndNode);
    void Refresh();
    void Update();
    IBrowserFolder AddBrowserFolder(string Name, object BrowserNodes);
    IBrowserNode GetBrowserNodeFromObject(object NativeObject);
    void ClearPreSelect();
    void GetDockingState(out DockingStateEnum DockingState, out object DockToObject);
    void SetDockingState(DockingStateEnum DockingState, object DockToObject);
}