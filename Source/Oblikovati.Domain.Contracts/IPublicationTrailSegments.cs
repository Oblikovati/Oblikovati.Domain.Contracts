namespace Oblikovati.Domain.Contracts;

public interface IPublicationTrailSegments : IList<IPublicationTrailSegments>
{
    int Count { get; }
    IPublicationTrailSegment Item { get; }
    IEnumerator GetEnumerator();
}
