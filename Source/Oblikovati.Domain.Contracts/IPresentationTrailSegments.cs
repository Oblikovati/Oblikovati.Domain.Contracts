namespace Oblikovati.Domain.Contracts;

public interface IPresentationTrailSegments : IList<IPresentationTrailSegments>
{
    int Count { get; }
    IPresentationTrailSegment Item { get; }
    IEnumerator GetEnumerator();
}
