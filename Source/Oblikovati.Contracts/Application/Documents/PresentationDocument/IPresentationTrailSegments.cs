namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationTrailSegments : IList<IPresentationTrailSegments>
{
    IPresentationTrailSegment Item { get; }
}