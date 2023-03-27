namespace Oblikovati.Domain.Contracts;

public interface IContourFlangeFeatures : IList<IContourFlangeFeatures>
{

    IContourFlangeFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IContourFlangeFeature Add(IContourFlangeDefinition ContourFlangeDefinition);
    IContourFlangeDefinition CreateContourFlangeDefinition(IPath Path, object Edges);
}
