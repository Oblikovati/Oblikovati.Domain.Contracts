namespace Oblikovati.Domain.Contracts;

public interface IPresentationTrails : IList<IPresentationTrails>
{
    int Count { get; }
    IPresentationTrail Item { get; }
    IEnumerator GetEnumerator();
}
