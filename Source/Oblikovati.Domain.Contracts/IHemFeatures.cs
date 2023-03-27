namespace Oblikovati.Domain.Contracts;

public interface IHemFeatures : IList<IHemFeatures>
{

    IHemFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IHemFeature Add(IHemDefinition HemDefinition);
    IHemDefinition CreateHemDefinition(IEdgeCollection Edges);
}
