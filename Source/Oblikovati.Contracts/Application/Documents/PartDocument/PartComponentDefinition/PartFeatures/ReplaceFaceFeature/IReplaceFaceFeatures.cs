namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    ReplaceFaceFeature;

public interface IReplaceFaceFeatures : IList<IReplaceFaceFeatures>
{
    IReplaceFaceFeature Item { get; }
}