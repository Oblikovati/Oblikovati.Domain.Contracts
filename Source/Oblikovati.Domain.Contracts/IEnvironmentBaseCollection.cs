namespace Oblikovati.Domain.Contracts;

public interface IEnvironmentBaseCollection : IList<IEnvironmentBase>
{
    ICommandBarBaseCollection CommandBarBaseCollection { get; }
}
