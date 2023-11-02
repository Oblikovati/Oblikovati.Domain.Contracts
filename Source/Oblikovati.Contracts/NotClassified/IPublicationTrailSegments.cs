namespace Oblikovati.Contracts.NotClassified;

public interface IPublicationTrailSegments : IList<IPublicationTrailSegments>
{
    IPublicationTrailSegment Item { get; }
}