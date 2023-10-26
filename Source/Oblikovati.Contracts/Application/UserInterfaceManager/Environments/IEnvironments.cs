namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

/// <summary>
/// The Environments collection object provides access to all of the existing objects, and allows creation of new ones. 
/// </summary>
public interface IEnvironments : IList<IEnvironment>, IInjectableSingletonEntity
{
    /// <summary>
    /// Returns the specified Environment object from the list.
    /// </summary>
    /// <param name="index"></param>
    public IEnvironment this[string index] { get; }
    /// <summary>
    /// Method that creates a new Environment object.
    /// </summary>
    /// <param name="DisplayName"></param>
    /// <param name="InternalName"></param>
    /// <param name="ClientId"></param>
    /// <param name="StandardIcon"></param>
    /// <param name="LargeIcon"></param>
    /// <returns></returns>
    IEnvironment Add(string DisplayName, string InternalName, string ClientId, object StandardIcon, object LargeIcon);
}