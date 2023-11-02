namespace Oblikovati.Contracts.NotClassified;

public interface IRuledSurfaceEdgeFacePairs : IList<IRuledSurfaceEdgeFacePairs>
{
    IRuledSurfaceEdgeFacePair Item { get; }
    IRuledSurfaceEdgeFacePair Add(IEdge Edge, IFace Face);
}