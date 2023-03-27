namespace Oblikovati.Domain.Contracts;

public interface IWeldBeads : IList<IWeldBeads>
{

    int Count { get; }
    IWeldBead Item { get; }
    IEnumerator GetEnumerator();
}
