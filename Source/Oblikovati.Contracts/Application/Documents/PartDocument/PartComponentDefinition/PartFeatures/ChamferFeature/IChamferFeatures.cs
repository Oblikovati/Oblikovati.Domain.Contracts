using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ChamferFeature;

public interface IChamferFeatures : IList<IChamferFeatures>
{
    IChamferFeature Item { get; }


    IChamferFeature AddUsingDistance(IEdgeCollection Edges, object Distance, bool AutomaticEdgeChain,
        bool CornerSetback, bool PreserveAllFeatures);

    IChamferFeature AddUsingDistanceAndAngle(IEdgeCollection Edges, IFace Face, object Distance, object Angle,
        bool AutomaticEdgeChain, bool PreserveAllFeatures);

    IChamferFeature AddUsingTwoDistances(IEdgeCollection Edges, IFace Face, object DistanceOne, object DistanceTwo,
        bool AutomaticEdgeChain, bool PreserveAllFeatures);
}