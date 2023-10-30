namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

/// <summary>
/// The BrowserPanes object provides access to the existing objects of the browser and allows you to create additional panes. See the article in the overviews section.
/// </summary>
public interface IBrowserPanes : IList<IBrowserPane>
{
    /// <summary>
    /// Property that returns the that is currently being displayed.
    /// </summary>
    IBrowserPane ActivePane { get; }
    /// <summary>
    /// Property that returns the collection of ClientNodeResource objects.
    /// A ClientNodeResource holds the icons necessary to define the open, closed and status images for all of
    /// the ClientBrowserNodes associated with this document.
    /// The ClientNodeResources collection has a method that allows you to add a new set of
    /// images that can then be used to create a new ClientBrowserNodeDefinition.
    /// </summary>
    IClientNodeResources ClientNodeResources { get; }
    /// <summary>
    /// Property that returns the events sink object for the BrowserPanes object.
    /// </summary>
    IBrowserPanesEvents BrowserPanesEvents { get; }
    /// <summary>
    /// Method that creates and returns a new BrowserPane object. 
    /// </summary>
    /// <param name="Name"></param>
    /// <param name="InternalName"></param>
    /// <returns></returns>
    IBrowserPane Add(string Name, string InternalName);
    /// <summary>
    /// Method that creates and returns a new BrowserPane object.
    /// The BrowserPane created is one in which Oblikovatis's
    /// BrowserTreeNodes can be instanced to generate a completely customizable tree view.
    /// </summary>
    /// <param name="Name"></param>
    /// <param name="InternalName"></param>
    /// <param name="TopNodeDefinition"></param>
    /// <returns></returns>
    IBrowserPane AddTreeBrowserPane(string Name, string InternalName, IBrowserNodeDefinition TopNodeDefinition);

    /// <summary>
    /// Method that creates a new The definition object can then be further used to construct ClientBrowserNodes
    /// that make up the tree in a custom tree-browser pane.
    /// The new ClientBrowserNodeDefinition is returned.
    /// Note that this node definition object is constructed and has an identity within the
    /// 'name space' or context of the entire owning document.
    /// </summary>
    /// <param name="Label"></param>
    /// <param name="Id"></param>
    /// <param name="Icon"></param>
    /// <param name="ToolTipText"></param>
    /// <param name="ExpandedIcon"></param>
    /// <param name="DisplayState"></param>
    /// <param name="StateIconToolTipText"></param>
    /// <returns></returns>
    static IClientBrowserNodeDefinition CreateBrowserNodeDefinition(string Label, int Id, IClientNodeResource Icon,
        string ToolTipText, object ExpandedIcon, object DisplayState, object StateIconToolTipText)
    {
        throw new NotImplementedException();
    }

    IBrowserPane AddTransientTreeBrowserPane(string Name, string InternalName,
        IBrowserNodeDefinition TopNodeDefinition);
    
    /// <summary>
    /// Method that returns the specified ClientBrowserNodeDefinition.
    /// </summary>
    /// <param name="ClientId"></param>
    /// <param name="Id"></param>
    /// <returns></returns>
    IClientBrowserNodeDefinition GetClientBrowserNodeDefinition(string ClientId, int Id);
}