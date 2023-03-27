namespace Oblikovati.Domain.Contracts;

public interface IPublicationTrails : IList<IPublicationTrails>
{

    int Count { get; }
    IPublicationTrail Item { get; }
    IEnumerator GetEnumerator();
}
