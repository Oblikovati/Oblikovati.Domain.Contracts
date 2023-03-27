namespace Oblikovati.Domain.Contracts;

public interface ICornerRoundFeatures : IList<ICornerRoundFeatures>
{

    ICornerRoundFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICornerRoundFeature Add(ICornerRoundDefinition CornerRoundDefinition);
    ICornerRoundDefinition CreateCornerRoundDefinition(IEdgeCollection CornerEdges, object Radius);
}
