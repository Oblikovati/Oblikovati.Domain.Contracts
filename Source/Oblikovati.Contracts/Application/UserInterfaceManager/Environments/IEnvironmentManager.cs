using Oblikovati.Contracts.Application.Documents.Document;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;
/// <summary>
/// This object provides methods and properties to get and set the base and override environments for this document.
/// </summary>
public interface IEnvironmentManager
{
    /// <summary>
    /// Property that returns the parent of the EnvironmentManager.
    /// </summary>
    IDocument Parent { get; }
    /// <summary>
    /// Property that returns the Environment that is defined as the default for this document.
    /// This is the environment displayed when the document is opened unless an override environment
    /// has been specified for this document.
    /// </summary>
    IEnvironment BaseEnvironment { get; }
    /// <summary>
    /// Gets and sets the current override environment for this document.
    /// </summary>
    IEnvironment OverrideEnvironment { get; set; }
    /// <summary>
    /// This method returns the environment associated with the currently active edit object.
    /// This is the environment which is the topmost entry in the Application menu.
    /// The active environment and EditObjectEnvironment are not necessarily the same.
    /// Using parallel environments, one can switch to a parallel environment for the same edit object.
    /// </summary>
    IEnvironment EditObjectEnvironment { get; }
    /// <summary>
    /// Method that gets the current Environment for this document.
    /// This is the environment that the document is currently displayed in.
    /// </summary>
    /// <param name="EditTargetId"></param>
    /// <returns></returns>
    IEnvironment GetCurrentEnvironment(out string EditTargetId);
    /// <summary>
    /// Method that sets the current Environment for this document.
    /// This is the environment that the document is currently displayed in.
    /// The change is not persisted with the document; i.e. the next time the document is opened,
    /// it will show up in its base environment or the override environment if specified.
    /// </summary>
    /// <param name="Environment"></param>
    /// <param name="EditObjectId"></param>
    void SetCurrentEnvironment(IEnvironment Environment, string EditObjectId);
}