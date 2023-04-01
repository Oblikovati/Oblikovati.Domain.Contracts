namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SnapFitFeature;

public interface ISnapFitFeatures : IList<ISnapFitFeatures>
{
    ISnapFitFeature Item { get; }
}