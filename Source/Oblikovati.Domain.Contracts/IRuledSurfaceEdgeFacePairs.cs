namespace Oblikovati.Domain.Contracts;

public interface IRuledSurfaceEdgeFacePairs : IList<IRuledSurfaceEdgeFacePairs>
{
    int Count { get; }
    IRuledSurfaceEdgeFacePair Item { get; }
    IRuledSurfaceEdgeFacePair Add(IEdge Edge, IFace Face);
    IEnumerator GetEnumerator();
}
