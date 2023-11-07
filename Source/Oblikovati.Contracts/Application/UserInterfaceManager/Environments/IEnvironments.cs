namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

/// <summary>
/// The Environments collection object provides access to all of the existing objects, and allows creation of new ones. 
/// </summary>
public interface IEnvironments : IList<IEnvironment>, IInjectableSingletonEntity
{
    /// <summary>
    /// Method that creates a new Environment object.
    /// </summary>
    /// <param name="DisplayName"></param>
    /// <param name="InternalName"></param>
    /// <param name="ClientId"></param>
    /// <param name="StandardIcon"></param>
    /// <param name="LargeIcon"></param>
    /// <returns></returns>
    IEnvironment Add(string DisplayName, string InternalName, Guid? ClientId = default, object? StandardIcon = null, object? LargeIcon = null);
}