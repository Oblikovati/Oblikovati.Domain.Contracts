namespace Oblikovati.Domain.Contracts;

public interface IFlatPunchResults : IList<IFlatPunchResults>
{

    IFlatPunchResult Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
