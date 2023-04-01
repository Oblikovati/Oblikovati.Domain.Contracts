namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;

public interface IiFeatures : IList<IiFeatures>
{
    IiFeature Item { get; }

    IiFeature Add(IiFeatureDefinition Definition);
    IiFeatureDefinition CreateiFeatureDefinition(string FullFileName);
}