namespace Oblikovati.Domain.Contracts;

public interface ITrail : IList<ITrail>
{

    IPresentationExplodedView Parent { get; }
    int Count { get; }
    ITrailSegment Item { get; }
    void SetVisibility(bool Visible);
    IEnumerator GetEnumerator();
}
