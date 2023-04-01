namespace Oblikovati.Contracts.Application.UserInterfaceManager.CommandBars;

public interface ICommandBarList : IList<ICommandBarList>
{
    ICommandBar Item { get; }

    bool InheritAll { get; set; }
    void _Add(object CommandBar);
    void Add(ICommandBar CommandBar);
    void Remove(int Index);
}