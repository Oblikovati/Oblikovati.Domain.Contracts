namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.GrillFeature;

public interface IGrillFeatures : IList<IGrillFeatures>
{
    IGrillFeature Item { get; }
}