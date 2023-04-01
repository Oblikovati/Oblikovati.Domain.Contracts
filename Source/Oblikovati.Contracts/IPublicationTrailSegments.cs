namespace Oblikovati.Contracts;

public interface IPublicationTrailSegments : IList<IPublicationTrailSegments>
{
    IPublicationTrailSegment Item { get; }
}