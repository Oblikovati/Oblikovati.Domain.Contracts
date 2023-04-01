namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ClientFeature;

public interface IClientFeatureElements : IList<IClientFeatureElements>
{
    IClientFeatureElement Item { get; }

    IClientFeatureElement Add(object Element, bool BrowserVisible);
}