namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;

public interface IFeatureDimensions : IList<IFeatureDimensions>
{
    IFeatureDimension Item { get; }

    void Show();
}