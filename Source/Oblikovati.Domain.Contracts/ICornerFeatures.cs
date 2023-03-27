namespace Oblikovati.Domain.Contracts;

public interface ICornerFeatures : IList<ICornerFeatures>
{

    ICornerFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICornerFeature Add(ICornerDefinition CornerDefinition);
    ICornerDefinition CreateCornerDefinition(IEdgeCollection Edges, bool RippedCorner);
}
