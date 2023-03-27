namespace Oblikovati.Domain.Contracts;

public interface IBendFeatures : IList<IBendFeatures>
{

    IBendFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IBendFeature Add(IBendDefinition BendDefinition);
    IBendDefinition CreateBendDefinition(IEdgeCollection Edges);
}
