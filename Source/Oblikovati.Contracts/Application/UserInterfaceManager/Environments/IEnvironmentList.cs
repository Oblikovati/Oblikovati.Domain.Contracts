namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

/// <summary>
/// The EnvironmentList object defines a list of environments that are displayed to the user in various contexts
/// </summary>
public interface IEnvironmentList : IList<IEnvironment>
{
    /// <summary>
    /// Method that removes the specified Environment from the list.
    /// </summary>
    /// <param name="Index"></param>
    void Remove(int Index);
}