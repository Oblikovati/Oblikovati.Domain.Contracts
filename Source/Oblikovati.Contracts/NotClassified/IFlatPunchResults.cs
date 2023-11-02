namespace Oblikovati.Contracts.NotClassified;

public interface IFlatPunchResults : IList<IFlatPunchResults>
{
    IFlatPunchResult Item { get; }
}