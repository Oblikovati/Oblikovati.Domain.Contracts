namespace Oblikovati.Domain.Contracts;

public interface IWires : IList<IWires>
{
    IWire Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
