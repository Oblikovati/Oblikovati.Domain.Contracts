namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationTrail
{
    IPresentationComponent PresentationComponent { get; }

    IPresentationTrailSegments Segments { get; }
    bool Deleted { get; }
}