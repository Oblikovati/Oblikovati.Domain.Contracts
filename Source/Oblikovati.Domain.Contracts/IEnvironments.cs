namespace Oblikovati.Domain.Contracts;

public interface IEnvironments : IList<IEnvironment>, IInjectableSingletonEntity
{
    public IEnvironment this[string index] { get; }
    IEnvironment Add(string DisplayName, string InternalName, string ClientId, object StandardIcon, object LargeIcon);
}
