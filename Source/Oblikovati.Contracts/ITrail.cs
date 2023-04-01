using Oblikovati.Contracts.Application.Documents.PresentationDocument;

namespace Oblikovati.Contracts;

public interface ITrail : IList<ITrail>
{
    IPresentationExplodedView Parent { get; }

    ITrailSegment Item { get; }
    void SetVisibility(bool Visible);
}