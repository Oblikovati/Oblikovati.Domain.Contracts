namespace Oblikovati.Contracts.Application.UserInterfaceManager.Environments;

public interface IEnvironments : IList<IEnvironment>, IInjectableSingletonEntity
{
    public IEnvironment this[string index] { get; }
    IEnvironment Add(string DisplayName, string InternalName, string ClientId, object StandardIcon, object LargeIcon);
}