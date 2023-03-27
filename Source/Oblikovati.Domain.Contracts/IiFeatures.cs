namespace Oblikovati.Domain.Contracts;

public interface IiFeatures : IList<IiFeatures>
{

    int Count { get; }
    IiFeature Item { get; }
    IEnumerator GetEnumerator();
    IiFeature Add(IiFeatureDefinition Definition);
    IiFeatureDefinition CreateiFeatureDefinition(string FullFileName);
}
