namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.BossFeature;

public interface IBossFeatures : IList<IBossFeatures>
{
    IBossFeature Item { get; }
}