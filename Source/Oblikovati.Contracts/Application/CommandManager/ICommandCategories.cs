namespace Oblikovati.Contracts.Application.CommandManager;

public interface ICommandCategories : IList<ICommandCategory>
{
    ICommandCategory Add(string DisplayName, string InternalName, string ClientId);
}