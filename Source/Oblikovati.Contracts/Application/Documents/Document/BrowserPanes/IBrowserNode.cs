namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IBrowserNode
{
    IBrowserNodeDefinition BrowserNodeDefinition { get; }
    IBrowserNodesEnumerator BrowserNodes { get; }
    bool Expanded { get; set; }
    bool Selected { get; }
    bool Visible { get; set; }
    string FullPath { get; }
    bool OverrideNativeGraying { get; set; }
    object NativeObject { get; }
    IBrowserFoldersEnumerator BrowserFolders { get; }
    IBrowserNode AddChild(IBrowserNodeDefinition Definition);
    void EnsureVisible();
    void DoPreSelect();
    void DoSelect();
    void Delete();
    IBrowserNodesEnumerator AllReferencedNodes(IBrowserNodeDefinition Definition);
    IBrowserNode InsertChild(IBrowserNodeDefinition Definition, IBrowserNode TargetNode, bool InsertBefore);
}