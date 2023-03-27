namespace Oblikovati.Domain.Contracts;

public interface IFlangeFeatures : IList<IFlangeFeatures>
{

    IFlangeFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IFlangeFeature Add(IFlangeDefinition FlangeDefinition);
    IFlangeDefinition CreateFlangeDefinition(IEdgeCollection Edges, object FlangeAngleOrFlangeAngleReferencePlane, object Distance);
}
