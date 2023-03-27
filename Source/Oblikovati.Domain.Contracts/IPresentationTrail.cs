namespace Oblikovati.Domain.Contracts;

public interface IPresentationTrail
{

    IPresentationComponent PresentationComponent { get; }

    IPresentationTrailSegments Segments { get; }
    bool Deleted { get; }
}
