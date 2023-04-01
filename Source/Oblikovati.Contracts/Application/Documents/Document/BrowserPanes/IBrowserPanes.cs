namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IBrowserPanes : IList<IBrowserPane>
{
    IBrowserPane ActivePane { get; }
    IClientNodeResources ClientNodeResources { get; }
    IBrowserPanesEvents BrowserPanesEvents { get; }
    IBrowserPane Add(string Name, string InternalName);
    IBrowserPane AddTreeBrowserPane(string Name, string InternalName, IBrowserNodeDefinition TopNodeDefinition);

    IClientBrowserNodeDefinition CreateBrowserNodeDefinition(string Label, int Id, IClientNodeResource Icon,
        object ToolTipText, object ExpandedIcon, object DisplayState, object StateIconToolTipText);

    IBrowserPane AddTransientTreeBrowserPane(string Name, string InternalName,
        IBrowserNodeDefinition TopNodeDefinition);

    INativeBrowserNodeDefinition GetNativeBrowserNodeDefinition(object NativeObject);
    IClientBrowserNodeDefinition GetClientBrowserNodeDefinition(string ClientId, int Id);
    IBrowserPane AddByManifest(string Name, string InternalName, string ManifestFileName);
    INativeBrowserNodeDefinition GetNativeBrowserNodeDefinitionWithOptions(object Native, object Options);
}