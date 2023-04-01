namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;

public interface IiFeatureInputs : IList<IiFeatureInputs>
{
    IiFeatureInput Item { get; }
}