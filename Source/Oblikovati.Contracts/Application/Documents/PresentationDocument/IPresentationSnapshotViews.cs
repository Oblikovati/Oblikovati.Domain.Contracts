namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationSnapshotViews : IList<IPresentationSnapshotViews>
{
    IPresentationSnapshotView Item { get; }
}