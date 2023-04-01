namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.FreeformFeature;

public interface IFreeformFeatures : IList<IFreeformFeatures>
{
    IFreeformFeature Item { get; }
}