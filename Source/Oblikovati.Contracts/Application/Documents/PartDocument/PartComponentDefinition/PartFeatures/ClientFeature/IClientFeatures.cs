namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ClientFeature;

public interface IClientFeatures : IList<IClientFeatures>
{
    IClientFeature Item { get; }

    IClientFeatureDefinition CreateDefinition(string FeatureType, object StartElement, object EndElement,
        object FeatureInputs);

    IClientFeature Add(IClientFeatureDefinition Definition, string ClientId);
}