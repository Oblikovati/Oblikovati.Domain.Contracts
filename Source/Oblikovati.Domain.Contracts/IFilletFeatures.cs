namespace Oblikovati.Domain.Contracts;

public interface IFilletFeatures : IList<IFilletFeatures>
{

    IFilletFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IFilletFeature AddSimple(IEdgeCollection Edges, object Radius, bool AllFillets, bool AllRounds, bool AutomaticEdgeChain, bool RollAlongSharpEdges, bool RollingBallWherePossible, bool PreserveAllFeatures);
    IFilletFeature Add(IFilletDefinition FilletDefinition, bool AutomaticEdgeChain, bool SmoothRadiusTransition, bool RollAlongSharpEdges, bool RollingBallWherePossible, bool PreserveAllFeatures);
    IFilletDefinition CreateFilletDefinition();
}
