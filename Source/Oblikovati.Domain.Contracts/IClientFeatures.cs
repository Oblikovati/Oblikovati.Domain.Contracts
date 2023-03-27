namespace Oblikovati.Domain.Contracts;

public interface IClientFeatures : IList<IClientFeatures>
{

    int Count { get; }
    IClientFeature Item { get; }
    IEnumerator GetEnumerator();
    IClientFeatureDefinition CreateDefinition(string FeatureType, object StartElement, object EndElement, object FeatureInputs);
    IClientFeature Add(IClientFeatureDefinition Definition, string ClientId);
}
