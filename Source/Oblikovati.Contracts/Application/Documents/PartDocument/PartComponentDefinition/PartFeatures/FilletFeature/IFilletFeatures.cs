using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FilletFeature;

public interface IFilletFeatures : IList<IFilletFeatures>
{
    IFilletFeature Item { get; }


    IFilletFeature AddSimple(IEdgeCollection Edges, object Radius, bool AllFillets, bool AllRounds,
        bool AutomaticEdgeChain, bool RollAlongSharpEdges, bool RollingBallWherePossible, bool PreserveAllFeatures);

    IFilletFeature Add(IFilletDefinition FilletDefinition, bool AutomaticEdgeChain, bool SmoothRadiusTransition,
        bool RollAlongSharpEdges, bool RollingBallWherePossible, bool PreserveAllFeatures);

    IFilletDefinition CreateFilletDefinition();
}