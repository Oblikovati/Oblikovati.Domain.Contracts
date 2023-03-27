namespace Oblikovati.Domain.Contracts;

public interface IPresentationSnapshotViews : IList<IPresentationSnapshotViews>
{

    int Count { get; }
    IPresentationSnapshotView Item { get; }
    IEnumerator GetEnumerator();
}
