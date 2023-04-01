namespace Oblikovati.Contracts.Application.CommandManager;

public interface ICommandCategories : IList<ICommandCategory>
{
    public ICommandCategory this[string Index] { get; }
    ICommandCategory Add(string DisplayName, string InternalName, string ClientId);
}