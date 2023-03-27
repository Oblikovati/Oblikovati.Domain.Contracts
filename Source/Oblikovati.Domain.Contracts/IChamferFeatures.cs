namespace Oblikovati.Domain.Contracts;

public interface IChamferFeatures : IList<IChamferFeatures>
{

    IChamferFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IChamferFeature AddUsingDistance(IEdgeCollection Edges, object Distance, bool AutomaticEdgeChain, bool CornerSetback, bool PreserveAllFeatures);
    IChamferFeature AddUsingDistanceAndAngle(IEdgeCollection Edges, IFace Face, object Distance, object Angle, bool AutomaticEdgeChain, bool PreserveAllFeatures);
    IChamferFeature AddUsingTwoDistances(IEdgeCollection Edges, IFace Face, object DistanceOne, object DistanceTwo, bool AutomaticEdgeChain, bool PreserveAllFeatures);
}
