namespace Oblikovati.Contracts;

public interface IFlatPunchResults : IList<IFlatPunchResults>
{
    IFlatPunchResult Item { get; }
}