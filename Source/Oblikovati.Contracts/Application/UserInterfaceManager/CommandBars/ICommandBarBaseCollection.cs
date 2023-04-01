namespace Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;

public interface ICommandBarBaseCollection : IList<ICommandBarBaseCollection>
{
    ICommandBarBase Item { get; }


    ICommandBarBase Add(string DisplayName, object InternalName);
}