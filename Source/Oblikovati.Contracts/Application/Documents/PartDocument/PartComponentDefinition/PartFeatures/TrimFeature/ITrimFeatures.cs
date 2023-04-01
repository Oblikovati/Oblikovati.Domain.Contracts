namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.TrimFeature;

public interface ITrimFeatures : IList<ITrimFeatures>
{
    ITrimFeature Item { get; }
}