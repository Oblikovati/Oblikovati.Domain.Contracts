namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CircularPatternFeature;

public interface IFeaturePatternElements : IList<IFeaturePatternElements>
{
    IFeaturePatternElement Item { get; }
}